using EpiApp.App.Cadastro;
using EpiApp.App.Consulta;
using EpiApp.App.Infra;
using EpiApp.Domain.Base;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System.Diagnostics;

namespace EpiApp.App.Base
{
    public partial class FormPrincipal : Form
    {
        #region Properties
        private Form activeForm = null;
        #endregion

        #region Constructor
        public FormPrincipal()
        {            
            InitializeComponent();
            customiseDesign();
        }

        #endregion

        #region Functions
        private void customiseDesign()
        {
            panelCadastrosSubmenu.Visible = false;
            panelConsultaSubmenu.Visible = false;
            // ..
        }
        private void hideSubmenu()
        {
            if (panelCadastrosSubmenu.Visible == true)
                panelCadastrosSubmenu.Visible = false;
            if (panelConsultaSubmenu.Visible == true)
                panelConsultaSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        public void openChildForm<TFormulario>(TFormulario childForm) where TFormulario : Form
        {
            OpenFormInPanel(childForm);
        }

        public void openChildForm<TFormulario>() where TFormulario : Form 
        {               
            var childForm = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            OpenFormInPanel(childForm!);
        }

        private void OpenFormInPanel(Form childForm)
        {
            if (childForm != null && !childForm.IsDisposed)
            {
                if (activeForm != childForm)
                {
                    if (activeForm != null)
                    {
                        activeForm.Close();
                    }
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panelChildForm.Controls.Add(childForm);
                    panelChildForm.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
            }
        }
        #endregion

        #region Cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCadastrosSubmenu);
        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm<FuncionarioCadastro>();
        }

        private void btnCadastroEpis_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm<EpiCadastro>();            
        }

        private void btnCadastroSetores_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm<SetorCadastro>();
        }
        #endregion

        #region Consulta        
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            showSubmenu(panelConsultaSubmenu);
        }

        private void btnConsultaFuncionarios_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm<FuncionarioConsulta>();
        }

        private void btnConsultaEpis_Click(object sender, EventArgs e)
        {            
            hideSubmenu();
            openChildForm<EpiConsulta>();
        }

        private void btnConsultaSetores_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            openChildForm<SetorConsulta>();
        }
        #endregion
        
    }
}
