using EpiApp.App.Infra;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Controls;

namespace EpiApp.App.Base
{    
        public partial class BaseConsultaForm : BaseForm
    {
        #region Construtor
        public BaseConsultaForm(string labelFormularioNome) : base(labelFormularioNome)
        {
            InitializeComponent();
        }
        public BaseConsultaForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover();
        }
        #endregion

        #region CRUD
        protected virtual void Novo()
        {
        }

        protected virtual void Editar()
        {
        }

        protected virtual void Remover()
        {
        }
        #endregion

    }
}
