using EpiApp.App.Base;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EpiApp.App.Cadastro
{
    public partial class FuncionarioCadastro : BaseCadastro<Funcionario, FuncionarioModel, FuncionarioValidator>
    {
        #region Dependencias
        IBaseService<Funcionario> _funcionarioService;
        #endregion

        #region Constructor
        public FuncionarioCadastro(IBaseService<Funcionario> funcionarioService) : base("Funcionario Cadastro")
        {
            _funcionarioService = funcionarioService;
            InitializeComponent();
        }
        #endregion

        #region Override
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(materialTextBoxId.Text, out var id))
                    {
                        var funcionario = _funcionarioService.GetById<Funcionario>(id);
                        PreencheObjeto(funcionario);
                        funcionario = _funcionarioService.Update<Funcionario, Funcionario, FuncionarioValidator>(funcionario);
                    }
                }
                else
                {
                    var funcionario = new Funcionario();
                    PreencheObjeto(funcionario);
                    _funcionarioService.Create<Funcionario, Funcionario, FuncionarioValidator>(funcionario);

                }
                //  Redirecionar para outro formulário?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Embal",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Funções Internas
        private void PreencheObjeto(Funcionario funcionario)
        {
            funcionario.Nome = materialTextBoxNome.Text;
            funcionario.Documento = materialTextBoxDocumento.Text;            
            funcionario.DataNascimento = poisonDateTimeDataNascimento.Value;
            funcionario.Ativo = checkBoxAtivo.Checked;            
        }
        #endregion
    }
}
