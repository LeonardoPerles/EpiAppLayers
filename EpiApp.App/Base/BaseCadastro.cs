using EpiApp.Domain.Base;
using FluentValidation;
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
    public partial class BaseCadastro<TEntity, TModel, TValidator> : BaseCadastroForm
        where TEntity : IBaseEntity
        where TModel : class
        where TValidator : AbstractValidator<TEntity>
    {
        #region Constructor
        public BaseCadastro(string labelFormularioNome) : base(labelFormularioNome)
        {
            InitializeComponent();
        }
        public BaseCadastro()
        {
            InitializeComponent();
        }
        #endregion

        #region Functions
        protected override void Cancelar()
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
            }
        }

        protected override void Salvar()
        {

        }
        #endregion
    }
}
