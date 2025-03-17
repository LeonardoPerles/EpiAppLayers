namespace EpiApp.App.Forms.Cadastro
{
    partial class SetorCadastroForm
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
        private new void InitializeComponent()
        {
            materialTextBoxNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            labelNome = new ReaLTaiizor.Controls.BigLabel();
            materialTextBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            labelId = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // materialTextBoxNome
            // 
            materialTextBoxNome.AnimateReadOnly = false;
            materialTextBoxNome.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxNome.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxNome.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxNome.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxNome.Depth = 0;
            materialTextBoxNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxNome.HideSelection = true;
            materialTextBoxNome.LeadingIcon = null;
            materialTextBoxNome.Location = new Point(314, 148);
            materialTextBoxNome.MaxLength = 32767;
            materialTextBoxNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxNome.Name = "materialTextBoxNome";
            materialTextBoxNome.PasswordChar = '\0';
            materialTextBoxNome.PrefixSuffixText = null;
            materialTextBoxNome.ReadOnly = false;
            materialTextBoxNome.RightToLeft = RightToLeft.No;
            materialTextBoxNome.SelectedText = "";
            materialTextBoxNome.SelectionLength = 0;
            materialTextBoxNome.SelectionStart = 0;
            materialTextBoxNome.ShortcutsEnabled = true;
            materialTextBoxNome.Size = new Size(250, 48);
            materialTextBoxNome.TabIndex = 6;
            materialTextBoxNome.TabStop = false;
            materialTextBoxNome.Text = "Nome";
            materialTextBoxNome.TextAlign = HorizontalAlignment.Left;
            materialTextBoxNome.TrailingIcon = null;
            materialTextBoxNome.UseSystemPasswordChar = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Segoe UI", 25F);
            labelNome.ForeColor = Color.FromArgb(80, 80, 80);
            labelNome.Location = new Point(314, 76);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(112, 46);
            labelNome.TabIndex = 7;
            labelNome.Text = "Nome";
            // 
            // materialTextBoxId
            // 
            materialTextBoxId.AnimateReadOnly = false;
            materialTextBoxId.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxId.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxId.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxId.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxId.Depth = 0;
            materialTextBoxId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxId.HideSelection = true;
            materialTextBoxId.LeadingIcon = null;
            materialTextBoxId.Location = new Point(28, 148);
            materialTextBoxId.MaxLength = 32767;
            materialTextBoxId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxId.Name = "materialTextBoxId";
            materialTextBoxId.PasswordChar = '\0';
            materialTextBoxId.PrefixSuffixText = null;
            materialTextBoxId.ReadOnly = false;
            materialTextBoxId.RightToLeft = RightToLeft.No;
            materialTextBoxId.SelectedText = "";
            materialTextBoxId.SelectionLength = 0;
            materialTextBoxId.SelectionStart = 0;
            materialTextBoxId.ShortcutsEnabled = true;
            materialTextBoxId.Size = new Size(250, 48);
            materialTextBoxId.TabIndex = 8;
            materialTextBoxId.TabStop = false;
            materialTextBoxId.Text = "Id";
            materialTextBoxId.TextAlign = HorizontalAlignment.Left;
            materialTextBoxId.TrailingIcon = null;
            materialTextBoxId.UseSystemPasswordChar = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.Transparent;
            labelId.Font = new Font("Segoe UI", 25F);
            labelId.ForeColor = Color.FromArgb(80, 80, 80);
            labelId.Location = new Point(28, 76);
            labelId.Name = "labelId";
            labelId.Size = new Size(49, 46);
            labelId.TabIndex = 9;
            labelId.Text = "Id";
            // 
            // SetorCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelId);
            Controls.Add(materialTextBoxId);
            Controls.Add(labelNome);
            Controls.Add(materialTextBoxNome);
            Name = "SetorCadastro";
            Text = "SetorCadastro";
            Controls.SetChildIndex(materialTextBoxNome, 0);
            Controls.SetChildIndex(labelNome, 0);
            Controls.SetChildIndex(materialTextBoxId, 0);
            Controls.SetChildIndex(labelId, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxNome;
        private ReaLTaiizor.Controls.BigLabel labelNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxId;
        private ReaLTaiizor.Controls.BigLabel labelId;
    }
}