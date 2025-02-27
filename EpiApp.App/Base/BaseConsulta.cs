using ReaLTaiizor.Controls;

namespace EpiApp.App.Base
{
    public partial class BaseConsulta : BaseForm
    {
        
        #region Construtor
        public BaseConsulta(string labelFormularioNome) : base(labelFormularioNome)
        {
            InitializeComponent();            
        }
        #endregion
        
        #region Events
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Deletar(1);
        }
        #endregion

        #region CRUD
        protected virtual void CarregaGrid()
        {

        }
        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();            
        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }
        #endregion
    }
}
