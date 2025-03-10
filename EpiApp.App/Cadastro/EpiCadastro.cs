using EpiApp.App.Base;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Cadastro
{
    public partial class EpiCadastro : BaseCadastro<Epi, EpiModel, EpiValidator>
    {
        #region Dependências
        private IBaseService<Epi> _epiService;
        #endregion

        #region Constructor
        public EpiCadastro(IBaseService<Epi> epiService) : base("Epi Cadastro")
        {
            _epiService = epiService;
            InitializeComponent();
            LimpaCampos();
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

        public override void CarregaCampos(DataGridViewRow? linha)
        {
            if (linha != null)
            {
                materialTextBoxId.Text = "100";
                materialTextBoxNome.Text = linha?.Cells["Nome"].Value!.ToString() ?? string.Empty;
                materialTextBoxCa.Text = linha?.Cells["Ca"].Value!.ToString() ?? string.Empty;
                poisonDateTimeValidadeCa.Text = linha?.Cells["ValidadeCa"].Value!.ToString() ?? string.Empty;
                materialTextBoxPrazoTroca.Text = linha?.Cells["PrazoTroca"].Value!.ToString() ?? string.Empty;
            }
            else
            {
                // Aqui você pode exibir uma mensagem de erro, se necessário
                MessageBox.Show("Linha não encontrada.");
            }
        }
        #endregion
    }
}
