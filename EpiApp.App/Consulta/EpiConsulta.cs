using EpiApp.App.Base;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;
using System.Configuration;

namespace EpiApp.App.Consulta
{
    public partial class EpiConsulta : BaseConsulta<Epi, EpiModel, EpiValidator>
    {

        #region Constructor
        public EpiConsulta(IBaseService<Epi> epiService) : base(epiService, "Epi Consulta")
        {            
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Funções Sobrepostas
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
