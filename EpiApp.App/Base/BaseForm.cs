using ReaLTaiizor.Controls;

namespace EpiApp.App.Base
{
    public partial class BaseForm : Form
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Constructor
        public BaseForm()
        {
            InitializeComponent("Formulario");
        }

        public BaseForm(string labelFormularioNome)
        {
            InitializeComponent(labelFormularioNome);
        }
        #endregion

        #region Functions
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in this.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        #endregion
    }
}
