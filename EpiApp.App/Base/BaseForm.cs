using ReaLTaiizor.Controls;

namespace EpiApp.App.Base
{
    public partial class BaseForm : Form
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Constructor
        public BaseForm(string labelFormularioNome)
        {
            InitializeComponent();
            SetLabelFormularioText(labelFormularioNome);
        }
        public BaseForm()
        {
            InitializeComponent();            
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
        private void SetLabelFormularioText(string nomeFormulario)
        {
            labelFormulario.Text = nomeFormulario;
        }
        #endregion
    }
}
