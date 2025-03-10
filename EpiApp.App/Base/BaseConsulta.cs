using EpiApp.App.Cadastro;
using EpiApp.App.Infra;
using EpiApp.Domain.Base;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class BaseConsulta<TEntity, TModel, TValidator> : BaseConsultaForm
        where TEntity : IBaseEntity
        where TModel : class
        where TValidator : AbstractValidator<TEntity>
    {
        #region Dependências      
        protected readonly IBaseService<TEntity> _service;
        //protected readonly BaseCadastro<TEntity> _service;
        protected readonly FormPrincipal _principal;
        protected List<TEntity>? entities;
        #endregion

        #region Construtor
        public BaseConsulta(IBaseService<TEntity> service, string labelFormularioNome) : base(labelFormularioNome)
        {
            _principal = ConfigureDI.ServicesProvider!.GetRequiredService<FormPrincipal>();
            _service = service;
            InitializeComponent();
        }
        public BaseConsulta(IBaseService<TEntity> service)
        {
            _principal = ConfigureDI.ServicesProvider!.GetRequiredService<FormPrincipal>();
            _service = service;
            InitializeComponent();
        }
        #endregion

        #region Metodos Sobrepostos
        protected override void Novo()
        {        
            LimpaCampos();
        }

        protected override bool Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                return true;
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        protected override void Remover()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"Embal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Possivelmente nulo?
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();                    
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Embal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                
        }
        protected private void Deletar(int id)
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
        #endregion
        
        #region Metodos Virtuais
        protected virtual void CarregaGrid()
        {
            //entities = _service.ListAll<TEntity>(false).ToList();
            //dataGridViewConsulta.DataSource = entities;
            //ConfiguraGrid();
        }
        //protected virtual void ConfiguraGrid()
        //{
        //}
        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {            

        }
        #endregion
    }
}
