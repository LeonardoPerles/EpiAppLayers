using EpiApp.App.Base;
using EpiApp.App.Cadastro;
using EpiApp.App.Infra;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
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
        protected override void CarregaGrid()
        {
            entities = _service.ListAll<Epi>(false).ToList();
            dataGridViewConsulta.DataSource = entities;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            var cadastroForm = ConfigureDI.ServicesProvider!.GetService<EpiCadastro>();
            cadastroForm!.CarregaCampos(linha);
            _principal.openChildForm<EpiCadastro>(cadastroForm);           
        }

        protected override void Novo()
        {
            base.Novo();
            _principal.openChildForm<EpiCadastro>();
        }

        protected override bool Editar()
        {
            if(base.Editar())
            {
                _principal.openChildForm<EpiCadastro>();
                return true;
            } else
            {
                return false;
            }
        }

        protected override void Remover()
        {
            base.Remover();
        }
        #endregion
    }
}
