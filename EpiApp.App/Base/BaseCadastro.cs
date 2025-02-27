using ReaLTaiizor.Controls;

namespace EpiApp.App.Base
{
    public partial class BaseCadastro : BaseForm
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

        #region Events
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        #endregion

        #region Functions
        protected virtual void Salvar()
        {

        }         
        #endregion
    }
}
