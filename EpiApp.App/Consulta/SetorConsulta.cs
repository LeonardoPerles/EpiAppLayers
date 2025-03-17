using EpiApp.App.Base;
using EpiApp.App.Cadastro;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Consulta
{
    public partial class SetorConsulta : BaseConsulta<Setor, SetorModel, SetorValidator, SetorCadastro>
    {                
        #region Constructor
        public SetorConsulta(IBaseService<Setor> setorService) : base(setorService, "Setor Consulta")
        {            
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Metodos Sobrepostos
        protected override void CarregaGrid()
        {
            entities = _service.ListAll<Setor>(false).ToList();
            dataGridViewConsulta.DataSource = entities;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.ReadOnly = true;
        }
        protected override SetorModel PreencheObjeto(SetorModel? model, DataGridViewRow linha)
        {

            model!.Id = linha?.Cells["Id"].Value as int? ?? 0;
            model.Nome = linha?.Cells["Nome"].Value?.ToString() ?? string.Empty;

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
