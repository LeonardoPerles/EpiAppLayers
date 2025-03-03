using EpiApp.App.Base;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using System.Configuration;

namespace EpiApp.App.Consulta
{
    public partial class EpiConsulta : BaseConsulta
    {
        #region Depedências
        private readonly IBaseService<Epi> _epiService;
        private List<Epi>? epis;
        #endregion

        #region Constructor
        public EpiConsulta(IBaseService<Epi> epiService) : base("Epi Consulta")
        {
            _epiService = epiService;
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Funções Sobrepostas
        protected override void CarregaGrid ()
        {
            epis = _epiService.ListAll<Epi>(false).ToList();
            dataGridViewConsulta.DataSource = epis;
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
