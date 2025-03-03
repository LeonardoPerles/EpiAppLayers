using EpiApp.App.Base;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;

namespace EpiApp.App.Consulta
{
    public partial class SetorConsulta : BaseConsulta
    {
        #region Dependências
        private readonly IBaseService<Setor> _setorService;
        private List<Setor>? setores;
        #endregion

        #region Constructor
        public SetorConsulta(IBaseService<Setor> setorService) : base("Setor Consulta")
        {
            _setorService = setorService;
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Metodos Sobrepostos
        protected override void CarregaGrid()
        {
            setores = _setorService.ListAll<Setor>(false).ToList();
            dataGridViewConsulta.DataSource = setores;
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
