namespace EpiApp.App.Cadastro
{
    partial class SetorCadastro
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
            textBoxNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            labelNome = new ReaLTaiizor.Controls.BigLabel();
            textBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            labelId = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.AnimateReadOnly = false;
            textBoxNome.AutoCompleteMode = AutoCompleteMode.None;
            textBoxNome.AutoCompleteSource = AutoCompleteSource.None;
            textBoxNome.BackgroundImageLayout = ImageLayout.None;
            textBoxNome.CharacterCasing = CharacterCasing.Normal;
            textBoxNome.Depth = 0;
            textBoxNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNome.HideSelection = true;
            textBoxNome.LeadingIcon = null;
            textBoxNome.Location = new Point(314, 148);
            textBoxNome.MaxLength = 32767;
            textBoxNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.PasswordChar = '\0';
            textBoxNome.PrefixSuffixText = null;
            textBoxNome.ReadOnly = false;
            textBoxNome.RightToLeft = RightToLeft.No;
            textBoxNome.SelectedText = "";
            textBoxNome.SelectionLength = 0;
            textBoxNome.SelectionStart = 0;
            textBoxNome.ShortcutsEnabled = true;
            textBoxNome.Size = new Size(250, 48);
            textBoxNome.TabIndex = 6;
            textBoxNome.TabStop = false;
            textBoxNome.Text = "Nome";
            textBoxNome.TextAlign = HorizontalAlignment.Left;
            textBoxNome.TrailingIcon = null;
            textBoxNome.UseSystemPasswordChar = false;
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
            // textBoxId
            // 
            textBoxId.AnimateReadOnly = false;
            textBoxId.AutoCompleteMode = AutoCompleteMode.None;
            textBoxId.AutoCompleteSource = AutoCompleteSource.None;
            textBoxId.BackgroundImageLayout = ImageLayout.None;
            textBoxId.CharacterCasing = CharacterCasing.Normal;
            textBoxId.Depth = 0;
            textBoxId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxId.HideSelection = true;
            textBoxId.LeadingIcon = null;
            textBoxId.Location = new Point(28, 148);
            textBoxId.MaxLength = 32767;
            textBoxId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textBoxId.Name = "textBoxId";
            textBoxId.PasswordChar = '\0';
            textBoxId.PrefixSuffixText = null;
            textBoxId.ReadOnly = false;
            textBoxId.RightToLeft = RightToLeft.No;
            textBoxId.SelectedText = "";
            textBoxId.SelectionLength = 0;
            textBoxId.SelectionStart = 0;
            textBoxId.ShortcutsEnabled = true;
            textBoxId.Size = new Size(250, 48);
            textBoxId.TabIndex = 8;
            textBoxId.TabStop = false;
            textBoxId.Text = "Id";
            textBoxId.TextAlign = HorizontalAlignment.Left;
            textBoxId.TrailingIcon = null;
            textBoxId.UseSystemPasswordChar = false;
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
            Controls.Add(textBoxId);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Name = "SetorCadastro";
            Text = "SetorCadastro";
            Controls.SetChildIndex(textBoxNome, 0);
            Controls.SetChildIndex(labelNome, 0);
            Controls.SetChildIndex(textBoxId, 0);
            Controls.SetChildIndex(labelId, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textBoxNome;
        private ReaLTaiizor.Controls.BigLabel labelNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit textBoxId;
        private ReaLTaiizor.Controls.BigLabel labelId;
    }
}