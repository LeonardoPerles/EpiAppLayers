using EpiApp.App.Properties;

namespace EpiApp.App.Base
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidemenu = new Panel();
            panelConsultaSubmenu = new Panel();
            btnConsultaSetores = new Button();
            btnConsultaEpis = new Button();
            btnConsultaFuncionarios = new Button();
            btnConsulta = new Button();
            panelCadastrosSubmenu = new Panel();
            btnCadastroSetores = new Button();
            btnCadastroEpis = new Button();
            btnCadastroFuncionarios = new Button();
            btnCadastro = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelChildForm = new Panel();
            panelSidemenu.SuspendLayout();
            panelConsultaSubmenu.SuspendLayout();
            panelCadastrosSubmenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidemenu
            // 
            panelSidemenu.AutoScroll = true;
            panelSidemenu.BackColor = Color.Maroon;
            panelSidemenu.Controls.Add(panelConsultaSubmenu);
            panelSidemenu.Controls.Add(btnConsulta);
            panelSidemenu.Controls.Add(panelCadastrosSubmenu);
            panelSidemenu.Controls.Add(btnCadastro);
            panelSidemenu.Controls.Add(panelLogo);
            panelSidemenu.Dock = DockStyle.Left;
            panelSidemenu.Location = new Point(0, 0);
            panelSidemenu.Name = "panelSidemenu";
            panelSidemenu.Size = new Size(250, 561);
            panelSidemenu.TabIndex = 0;
            // 
            // panelConsultaSubmenu
            // 
            panelConsultaSubmenu.BackColor = Color.IndianRed;
            panelConsultaSubmenu.Controls.Add(btnConsultaSetores);
            panelConsultaSubmenu.Controls.Add(btnConsultaEpis);
            panelConsultaSubmenu.Controls.Add(btnConsultaFuncionarios);
            panelConsultaSubmenu.Dock = DockStyle.Top;
            panelConsultaSubmenu.Location = new Point(0, 319);
            panelConsultaSubmenu.Name = "panelConsultaSubmenu";
            panelConsultaSubmenu.Size = new Size(250, 129);
            panelConsultaSubmenu.TabIndex = 4;
            // 
            // btnConsultaSetores
            // 
            btnConsultaSetores.Dock = DockStyle.Top;
            btnConsultaSetores.FlatAppearance.BorderSize = 0;
            btnConsultaSetores.FlatStyle = FlatStyle.Flat;
            btnConsultaSetores.ForeColor = Color.LightGray;
            btnConsultaSetores.Location = new Point(0, 80);
            btnConsultaSetores.Name = "btnConsultaSetores";
            btnConsultaSetores.Padding = new Padding(35, 0, 0, 0);
            btnConsultaSetores.Size = new Size(250, 40);
            btnConsultaSetores.TabIndex = 2;
            btnConsultaSetores.Text = "Setores";
            btnConsultaSetores.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaSetores.UseVisualStyleBackColor = true;
            btnConsultaSetores.Click += btnConsultaSetores_Click;
            // 
            // btnConsultaEpis
            // 
            btnConsultaEpis.Dock = DockStyle.Top;
            btnConsultaEpis.FlatAppearance.BorderSize = 0;
            btnConsultaEpis.FlatStyle = FlatStyle.Flat;
            btnConsultaEpis.ForeColor = Color.LightGray;
            btnConsultaEpis.Location = new Point(0, 40);
            btnConsultaEpis.Name = "btnConsultaEpis";
            btnConsultaEpis.Padding = new Padding(35, 0, 0, 0);
            btnConsultaEpis.Size = new Size(250, 40);
            btnConsultaEpis.TabIndex = 1;
            btnConsultaEpis.Text = "Epis";
            btnConsultaEpis.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaEpis.UseVisualStyleBackColor = true;
            btnConsultaEpis.Click += btnConsultaEpis_Click;
            // 
            // btnConsultaFuncionarios
            // 
            btnConsultaFuncionarios.Dock = DockStyle.Top;
            btnConsultaFuncionarios.FlatAppearance.BorderSize = 0;
            btnConsultaFuncionarios.FlatStyle = FlatStyle.Flat;
            btnConsultaFuncionarios.ForeColor = Color.LightGray;
            btnConsultaFuncionarios.Location = new Point(0, 0);
            btnConsultaFuncionarios.Name = "btnConsultaFuncionarios";
            btnConsultaFuncionarios.Padding = new Padding(35, 0, 0, 0);
            btnConsultaFuncionarios.Size = new Size(250, 40);
            btnConsultaFuncionarios.TabIndex = 0;
            btnConsultaFuncionarios.Text = "Funcionários";
            btnConsultaFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaFuncionarios.UseVisualStyleBackColor = true;
            btnConsultaFuncionarios.Click += btnConsultaFuncionarios_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Dock = DockStyle.Top;
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.ForeColor = Color.DarkGray;
            btnConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsulta.Image = Properties.Resources.magnifying_glass_solid;
            btnConsulta.Location = new Point(0, 274);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Padding = new Padding(10, 0, 0, 0);
            btnConsulta.Size = new Size(250, 45);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "  Consulta";
            btnConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnConsulta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // panelCadastrosSubmenu
            // 
            panelCadastrosSubmenu.BackColor = Color.IndianRed;
            panelCadastrosSubmenu.Controls.Add(btnCadastroSetores);
            panelCadastrosSubmenu.Controls.Add(btnCadastroEpis);
            panelCadastrosSubmenu.Controls.Add(btnCadastroFuncionarios);
            panelCadastrosSubmenu.Dock = DockStyle.Top;
            panelCadastrosSubmenu.Location = new Point(0, 145);
            panelCadastrosSubmenu.Name = "panelCadastrosSubmenu";
            panelCadastrosSubmenu.Size = new Size(250, 129);
            panelCadastrosSubmenu.TabIndex = 2;
            // 
            // btnCadastroSetores
            // 
            btnCadastroSetores.Dock = DockStyle.Top;
            btnCadastroSetores.FlatAppearance.BorderSize = 0;
            btnCadastroSetores.FlatStyle = FlatStyle.Flat;
            btnCadastroSetores.ForeColor = Color.LightGray;
            btnCadastroSetores.Location = new Point(0, 80);
            btnCadastroSetores.Name = "btnCadastroSetores";
            btnCadastroSetores.Padding = new Padding(35, 0, 0, 0);
            btnCadastroSetores.Size = new Size(250, 40);
            btnCadastroSetores.TabIndex = 2;
            btnCadastroSetores.Text = "Setores";
            btnCadastroSetores.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastroSetores.UseVisualStyleBackColor = true;
            btnCadastroSetores.Click += btnCadastroSetores_Click;
            // 
            // btnCadastroEpis
            // 
            btnCadastroEpis.Dock = DockStyle.Top;
            btnCadastroEpis.FlatAppearance.BorderSize = 0;
            btnCadastroEpis.FlatStyle = FlatStyle.Flat;
            btnCadastroEpis.ForeColor = Color.LightGray;
            btnCadastroEpis.Location = new Point(0, 40);
            btnCadastroEpis.Name = "btnCadastroEpis";
            btnCadastroEpis.Padding = new Padding(35, 0, 0, 0);
            btnCadastroEpis.Size = new Size(250, 40);
            btnCadastroEpis.TabIndex = 1;
            btnCadastroEpis.Text = "Epis";
            btnCadastroEpis.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastroEpis.UseVisualStyleBackColor = true;
            btnCadastroEpis.Click += btnCadastroEpis_Click;
            // 
            // btnCadastroFuncionarios
            // 
            btnCadastroFuncionarios.Dock = DockStyle.Top;
            btnCadastroFuncionarios.FlatAppearance.BorderSize = 0;
            btnCadastroFuncionarios.FlatStyle = FlatStyle.Flat;
            btnCadastroFuncionarios.ForeColor = Color.LightGray;
            btnCadastroFuncionarios.Location = new Point(0, 0);
            btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            btnCadastroFuncionarios.Padding = new Padding(35, 0, 0, 0);
            btnCadastroFuncionarios.Size = new Size(250, 40);
            btnCadastroFuncionarios.TabIndex = 0;
            btnCadastroFuncionarios.Text = "Funcionários";
            btnCadastroFuncionarios.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastroFuncionarios.UseVisualStyleBackColor = true;
            btnCadastroFuncionarios.Click += btnCadastroFuncionarios_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Dock = DockStyle.Top;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.ForeColor = Color.DarkGray;
            btnCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastro.Image = Properties.Resources.plus_solid;
            btnCadastro.Location = new Point(0, 100);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Padding = new Padding(10, 0, 0, 0);
            btnCadastro.Size = new Size(250, 45);
            btnCadastro.TabIndex = 1;
            btnCadastro.Text = "  Cadastro";
            btnCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkRed;
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.ForeColor = Color.Transparent;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(61, 30);
            label1.Name = "label1";
            label1.Size = new Size(121, 39);
            label1.TabIndex = 0;
            label1.Text = "Embal";
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = SystemColors.ActiveCaption;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(684, 561);
            panelChildForm.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(934, 561);
            Controls.Add(panelChildForm);
            Controls.Add(panelSidemenu);
            Font = new Font("Microsoft Sans Serif", 10F);
            MinimumSize = new Size(950, 600);
            Name = "FormPrincipal";
            panelSidemenu.ResumeLayout(false);
            panelConsultaSubmenu.ResumeLayout(false);
            panelCadastrosSubmenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidemenu;
        private Panel panelLogo;
        private Button btnCadastro;
        private Panel panelCadastrosSubmenu;
        private Button btnCadastroSetores;
        private Button btnCadastroEpis;
        private Button btnCadastroFuncionarios;
        private Button btnConsulta;
        private Panel panelConsultaSubmenu;
        private Button btnConsultaSetores;
        private Button btnConsultaFuncionarios;
        private Button btnConsultaEpis;
        private Panel panelChildForm;
        private Label label1;
    }
}