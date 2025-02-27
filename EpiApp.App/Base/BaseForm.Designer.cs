namespace EpiApp.App.Base
{
    partial class BaseForm
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
        public void InitializeComponent(string nomeFormulario)
        {
            panel1 = new Panel();
            labelEmpresa = new Label();
            labelFormulario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(labelEmpresa);
            panel1.Controls.Add(labelFormulario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 33);
            panel1.TabIndex = 0;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("Albertus Medium", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEmpresa.Location = new Point(44, 0);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(107, 33);
            labelEmpresa.TabIndex = 1;
            labelEmpresa.Text = "Embal :";
            // 
            // labelFormulario
            // 
            labelFormulario.AutoSize = true;
            labelFormulario.Font = new Font("Albertus Medium", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFormulario.Location = new Point(157, 0);
            labelFormulario.Name = "labelFormulario";
            labelFormulario.Size = new Size(149, 33);
            labelFormulario.TabIndex = 0;
            labelFormulario.Text = nomeFormulario;            
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "BaseForm";
            Text = "BaseForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelFormulario;
        private Label labelEmpresa;
    }
}