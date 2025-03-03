﻿namespace EpiApp.App.Cadastro
{
    partial class FuncionarioCadastro
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
            materialTextBoxDocumento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            poisonDateTimeDataNascimento = new ReaLTaiizor.Controls.PoisonDateTime();
            checkBoxAtivo = new CheckBox();
            materialTextBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            materialTextBoxNome.Location = new Point(65, 86);
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
            materialTextBoxNome.Size = new Size(177, 48);
            materialTextBoxNome.TabIndex = 6;
            materialTextBoxNome.TabStop = false;
            materialTextBoxNome.Text = "Nome";
            materialTextBoxNome.TextAlign = HorizontalAlignment.Left;
            materialTextBoxNome.TrailingIcon = null;
            materialTextBoxNome.UseSystemPasswordChar = false;
            // 
            // materialTextBoxDocumento
            // 
            materialTextBoxDocumento.AnimateReadOnly = false;
            materialTextBoxDocumento.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxDocumento.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxDocumento.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxDocumento.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxDocumento.Depth = 0;
            materialTextBoxDocumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxDocumento.HideSelection = true;
            materialTextBoxDocumento.LeadingIcon = null;
            materialTextBoxDocumento.Location = new Point(65, 166);
            materialTextBoxDocumento.MaxLength = 32767;
            materialTextBoxDocumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxDocumento.Name = "materialTextBoxDocumento";
            materialTextBoxDocumento.PasswordChar = '\0';
            materialTextBoxDocumento.PrefixSuffixText = null;
            materialTextBoxDocumento.ReadOnly = false;
            materialTextBoxDocumento.RightToLeft = RightToLeft.No;
            materialTextBoxDocumento.SelectedText = "";
            materialTextBoxDocumento.SelectionLength = 0;
            materialTextBoxDocumento.SelectionStart = 0;
            materialTextBoxDocumento.ShortcutsEnabled = true;
            materialTextBoxDocumento.Size = new Size(177, 48);
            materialTextBoxDocumento.TabIndex = 7;
            materialTextBoxDocumento.TabStop = false;
            materialTextBoxDocumento.Text = "Documento";
            materialTextBoxDocumento.TextAlign = HorizontalAlignment.Left;
            materialTextBoxDocumento.TrailingIcon = null;
            materialTextBoxDocumento.UseSystemPasswordChar = false;
            // 
            // poisonDateTimeDataNascimento
            // 
            poisonDateTimeDataNascimento.AccessibleDescription = "";
            poisonDateTimeDataNascimento.Location = new Point(65, 288);
            poisonDateTimeDataNascimento.MinimumSize = new Size(0, 29);
            poisonDateTimeDataNascimento.Name = "poisonDateTimeDataNascimento";
            poisonDateTimeDataNascimento.Size = new Size(200, 29);
            poisonDateTimeDataNascimento.TabIndex = 11;
            // 
            // checkBoxAtivo
            // 
            checkBoxAtivo.AutoSize = true;
            checkBoxAtivo.Location = new Point(72, 241);
            checkBoxAtivo.Name = "checkBoxAtivo";
            checkBoxAtivo.Size = new Size(54, 19);
            checkBoxAtivo.TabIndex = 12;
            checkBoxAtivo.Text = "Ativo";
            checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxId
            // 
            materialTextBoxId.AnimateReadOnly = false;
            materialTextBoxId.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxId.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxId.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxId.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxId.Depth = 0;
            materialTextBoxId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxId.HideSelection = true;
            materialTextBoxId.LeadingIcon = null;
            materialTextBoxId.Location = new Point(477, 86);
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
            materialTextBoxId.TabIndex = 13;
            materialTextBoxId.TabStop = false;
            materialTextBoxId.Text = "Id";
            materialTextBoxId.TextAlign = HorizontalAlignment.Left;
            materialTextBoxId.TrailingIcon = null;
            materialTextBoxId.UseSystemPasswordChar = false;
            // 
            // FuncionarioCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialTextBoxId);
            Controls.Add(checkBoxAtivo);
            Controls.Add(poisonDateTimeDataNascimento);
            Controls.Add(materialTextBoxDocumento);
            Controls.Add(materialTextBoxNome);
            Name = "FuncionarioCadastro";
            Text = "FuncionarioCadastro";
            Controls.SetChildIndex(materialTextBoxNome, 0);
            Controls.SetChildIndex(materialTextBoxDocumento, 0);
            Controls.SetChildIndex(poisonDateTimeDataNascimento, 0);
            Controls.SetChildIndex(checkBoxAtivo, 0);
            Controls.SetChildIndex(materialTextBoxId, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxDocumento;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTimeDataNascimento;
        private CheckBox checkBoxAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxId;
    }
}