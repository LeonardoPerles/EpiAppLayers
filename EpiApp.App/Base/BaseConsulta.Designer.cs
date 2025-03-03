namespace EpiApp.App.Base
{
    partial class BaseConsulta
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
            dataGridViewConsulta = new DataGridView();
            labelBuscar = new Label();
            textBoxBusca = new TextBox();
            btnNovo = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(33, 87);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.Size = new Size(740, 336);
            dataGridViewConsulta.TabIndex = 0;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(45, 47);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(42, 15);
            labelBuscar.TabIndex = 1;
            labelBuscar.Text = "Buscar";
            // 
            // textBoxBusca
            // 
            textBoxBusca.Location = new Point(105, 48);
            textBoxBusca.Name = "textBoxBusca";
            textBoxBusca.Size = new Size(347, 23);
            textBoxBusca.TabIndex = 2;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(479, 48);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(571, 48);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(662, 48);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // BaseConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(textBoxBusca);
            Controls.Add(labelBuscar);
            Controls.Add(dataGridViewConsulta);
            Name = "BaseConsulta";
            Text = "BaseConsulta";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected DataGridView dataGridViewConsulta;
        private Label labelBuscar;
        private TextBox textBoxBusca;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnRemover;
    }
}