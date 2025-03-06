using EpiApp.App.Infra;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
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
        public BaseConsulta()
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
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente excluir?", @"Embal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Possivelmente nulo?
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;                    
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"Embal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
