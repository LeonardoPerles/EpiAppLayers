using EpiApp.App.Base;
using EpiApp.App.Cadastro;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Consulta
{
    public partial class FuncionarioConsulta : BaseConsulta<Funcionario, FuncionarioModel, FuncionarioValidator, FuncionarioCadastro>
    {
        #region Constructor
        public FuncionarioConsulta(IBaseService<Funcionario> funcionarioService) : base(funcionarioService, "Funcionário Consulta")
        {
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Metodos Sobrepostos
        protected override void CarregaGrid()
        {
            entities = _service.ListAll<Funcionario>(false).ToList();
            dataGridViewConsulta.DataSource = entities;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.ReadOnly = true;
        }

        protected override FuncionarioModel PreencheObjeto(FuncionarioModel? model, DataGridViewRow linha)
        {

            model!.Id = linha?.Cells["Id"].Value as int? ?? 0;
            model.Nome = linha?.Cells["Nome"].Value?.ToString() ?? string.Empty;
            model.Documento = linha?.Cells["Documento"].Value?.ToString() ?? string.Empty;
            model.Ativo = linha?.Cells["Ativo"].Value as bool? ?? false;
            model.DataNascimento = linha?.Cells["DataNascimento"].Value as DateTime? ?? DateTime.MinValue;
            
            return model;
        }
        protected override void Novo()
        {
            base.Novo();
        }

        protected override void Editar()
        {
            base.Editar();
        }

        protected override void Remover()
        {
            base.Remover();
        }
        #endregion
    }
}
