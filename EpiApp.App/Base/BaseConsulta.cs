using EpiApp.App.Cadastro;
using EpiApp.App.Infra;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpiApp.App.Base
{
    public partial class BaseConsulta<TEntity, TModel, TValidator, TCadastro> : BaseConsultaForm
        where TEntity : IBaseEntity
        where TModel : class
        where TValidator : AbstractValidator<TEntity>
        where TCadastro : BaseCadastro<TEntity, TModel, TValidator>
    {
        #region Dependências    

        protected readonly IBaseService<TEntity> _service;        
        protected readonly FormPrincipal _principal;
        protected readonly Func<TModel, TCadastro> _editaCadastroFactory;
        protected TModel? model;
        protected List<TEntity>? entities;       
        #endregion

        #region Construtor
        public BaseConsulta(IBaseService<TEntity> service, string labelFormularioNome) : base(labelFormularioNome)
        {
            _editaCadastroFactory = ConfigureDI.ServicesProvider?.GetRequiredService<Func<TModel, TCadastro>>()!;
            _principal = ConfigureDI.ServicesProvider!.GetRequiredService<FormPrincipal>();
            _service = service;
            InitializeComponent();
        }
        public BaseConsulta(IBaseService<TEntity> service)
        {
            _editaCadastroFactory = ConfigureDI.ServicesProvider?.GetRequiredService<Func<TModel, TCadastro>>()!;
            _principal = ConfigureDI.ServicesProvider!.GetRequiredService<FormPrincipal>();
            _service = service;
            InitializeComponent();
        }
        #endregion

        #region Metodos dos Eventos
        protected override void Novo()
        {        
            LimpaCampos();
            _principal.openChildForm<TCadastro>();
        }

        protected override void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];                
                model = CarregaRegistro(linha);                                 
                TCadastro editaCadastro = _editaCadastroFactory?.Invoke(model)!;                
                _principal.openChildForm(editaCadastro);
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }

        protected override void Remover()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"Embal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                    
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value!;
                    Deletar(id);
                    CarregaGrid();                    
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Embal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                
        }
        #endregion
        
        #region Metodos Virtuais
        protected virtual void CarregaGrid()
        {
            // ... // Sobreposto por classes filhas
        }
        protected virtual TModel PreencheObjeto(TModel? model, DataGridViewRow linha)
        {
            // Sobreposto por classes filhas
            // passa os dados da linha do grid para o model
            // depois retorna o model preenchido
            return model!;
        }
        #endregion

        #region Metodos Privados
        private void Deletar(int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private TModel CarregaRegistro(DataGridViewRow linha)
        {
            // Criando uma instância de TModel
            var tModel = ConfigureDI.ServicesProvider?.GetService<TModel>();
            
            // Preenchendo a instância
            tModel = PreencheObjeto(tModel, linha);            

            return tModel;
        }
        #endregion
    }
}
