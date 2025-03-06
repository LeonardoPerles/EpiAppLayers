using EpiApp.App.Base;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Consulta
{
    public partial class SetorConsulta : BaseConsulta<Setor, SetorModel, SetorValidator>
    {                
        #region Constructor
        public SetorConsulta(IBaseService<Setor> setorService) : base(setorService, "Setor Consulta")
        {            
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Metodos Sobrepostos
        protected override void ConfiguraGrid()
        {
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
        }
        #endregion
    }
}
