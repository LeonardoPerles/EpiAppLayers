namespace EpiApp.App.Base
{
    partial class BaseCadastroForm
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
        /// 
        /// </summary>
        /// 
        private new void InitializeComponent()
        {
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(533, 412);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(66, 26);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(645, 412);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(66, 26);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // BaseCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Name = "BaseCadastro";
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnSalvar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private Button btnCancelar;
        private Button btnSalvar;        
    }
}