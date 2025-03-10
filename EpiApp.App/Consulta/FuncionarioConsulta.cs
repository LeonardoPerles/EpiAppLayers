using EpiApp.App.Base;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Consulta
{
    public partial class FuncionarioConsulta : BaseConsulta<Funcionario, FuncionarioModel, FuncionarioValidator>
    {
        #region Constructor
        public FuncionarioConsulta(IBaseService<Funcionario> funcionarioService) : base(funcionarioService, "Funcionário Consulta")
        {
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Funções Sobrepostas
        protected override void CarregaGrid()
        {
            entities = _service.ListAll<Funcionario>(false).ToList();
            dataGridViewConsulta.DataSource = entities;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            // ....
        }
        #endregion
    }
}
