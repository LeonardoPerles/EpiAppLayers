using ReaLTaiizor.Controls;
using System.Diagnostics;

namespace EpiApp.App.Base
{
    public partial class BaseCadastroForm : BaseForm
    {
        #region Constructor
        public BaseCadastroForm(string labelFormularioNome) : base(labelFormularioNome)
        {
            InitializeComponent();
        }
        public BaseCadastroForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            Salvar();
        }
        #endregion

        #region Functions
        protected virtual void Cancelar()
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
            }
        }

        protected virtual void Salvar()
        {
            
        }
        #endregion

    }
}
