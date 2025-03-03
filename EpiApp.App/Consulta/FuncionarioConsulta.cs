using EpiApp.App.Base;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;

namespace EpiApp.App.Consulta
{
    public partial class FuncionarioConsulta : BaseConsulta
    {
        #region Dependências
        private readonly IBaseService<Funcionario> _funcionarioService;
        private List<Funcionario>? funcionarios;
        #endregion

        #region Constructor
        public FuncionarioConsulta(IBaseService<Funcionario> funcionarioService) : base("Funcionário Consulta")
        {
            _funcionarioService = funcionarioService;
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Funções Sobrepostas
        protected override void CarregaGrid()
        {
            funcionarios = _funcionarioService.ListAll<Funcionario>(false).ToList();
            dataGridViewConsulta.DataSource = funcionarios;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
        }
        protected override void Novo()
        {
        }
        protected override void Editar()
        {
        }
        protected override void Deletar(int id)
        {
        }
        #endregion
    }
}
