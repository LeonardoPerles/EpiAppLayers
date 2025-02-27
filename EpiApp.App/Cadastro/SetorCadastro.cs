using EpiApp.App.Base;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;

namespace EpiApp.App.Cadastro
{
    public partial class SetorCadastro : BaseCadastro
    {
        private IBaseService<Setor> _setorService;
        public SetorCadastro(IBaseService<Setor> setorService) : base("Setor Cadastro")
        {
            _setorService = setorService;
            InitializeComponent();
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(textBoxId.Text, out var id))
                    {
                        var setor = _setorService.GetById<Setor>(id);
                        PreencheObjeto(setor);
                        setor = _setorService.Update<Setor, Setor, SetorValidator>(setor);
                    }
                }
                else
                {
                    var setor = new Setor();
                    PreencheObjeto(setor);
                    _setorService.Create<Setor, Setor, SetorValidator>(setor);

                }
                //  Redirecionar para outro formulário?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Embal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheObjeto(Setor setor)
        {
            setor.Nome = textBoxNome.Text;
            
            throw new NotImplementedException();
        }
    }
}
