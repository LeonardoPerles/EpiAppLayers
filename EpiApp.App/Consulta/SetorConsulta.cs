using EpiApp.App.Base;

namespace EpiApp.App.Consulta
{
    public partial class SetorConsulta : BaseConsulta
    {
        public SetorConsulta() : base("Setor Consulta")
        {
            InitializeComponent();
        }

        protected override void CarregaGrid()
        {

        }
        protected override void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        protected override void Novo()
        {
            LimpaCampos();
        }
    }
}
