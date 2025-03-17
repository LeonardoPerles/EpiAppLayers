using EpiApp.App.Base;
using EpiApp.App.Cadastro;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;


namespace EpiApp.App.Consulta
{
    public partial class EpiConsulta : BaseConsulta<Epi, EpiModel, EpiValidator, EpiCadastro>
    {
        #region Constructor
        public EpiConsulta(IBaseService<Epi> epiService) : base(epiService, "Epi Consulta")
        {            
            InitializeComponent();
            CarregaGrid();
        }
        #endregion

        #region Metodos Sobrepostos
        protected override void CarregaGrid()
        {
            entities = _service.ListAll<Epi>(false).ToList();
            dataGridViewConsulta.DataSource = entities;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.ReadOnly = true;
        }

        protected override EpiModel PreencheObjeto(EpiModel? model, DataGridViewRow linha)
        {
            
            model!.Id = linha?.Cells["Id"].Value as int? ?? 0; 
            model.Nome = linha?.Cells["Nome"].Value?.ToString() ?? string.Empty;
            model.PrazoTroca = linha?.Cells["PrazoTroca"].Value as int? ?? 0;
            model.Ca = linha?.Cells["Ca"].Value?.ToString() ?? string.Empty;
            model.ValidadeCa = linha?.Cells["ValidadeCa"].Value as DateTime? ?? DateTime.MinValue;
            
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
