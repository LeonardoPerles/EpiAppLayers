using EpiApp.App.Base;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Cadastro
{
    public partial class EpiCadastro : BaseCadastro
    {
        #region Dependências
        private IBaseService<Epi> _epiService;
        #endregion

        #region Constructor
        public EpiCadastro(IBaseService<Epi> epiService) : base("Epi Cadastro")
        {
            _epiService = epiService;
            InitializeComponent();
        }
        #endregion

        #region Metodos sobrepostos
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(materialTextBoxId.Text, out var id))
                    {
                        var epi = _epiService.GetById<Epi>(id);
                        PreencheObjeto(epi);
                        epi = _epiService.Update<Epi, Epi, EpiValidator>(epi);
                    }
                }
                else
                {
                    var epi = new Epi();
                    PreencheObjeto(epi);
                    _epiService.Create<Epi, Epi, EpiValidator>(epi);

                }
                //  Redirecionar para outro formulário?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Embal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Funções
        private void PreencheObjeto(Epi epi)
        {
            epi.Nome = materialTextBoxNome.Text;
            epi.PrazoTroca = Int32.Parse(materialTextBoxPrazoTroca.Text);
            epi.Ca = materialTextBoxCa.Text;
            epi.ValidadeCa = poisonDateTimeValidadeCa.Value;
        }
        #endregion
    }
}
