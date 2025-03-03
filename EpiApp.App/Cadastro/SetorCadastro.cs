using EpiApp.App.Base;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;
using System.Diagnostics;

namespace EpiApp.App.Cadastro
{
    public partial class SetorCadastro : BaseCadastro
    {
        #region Dependências/Serviços
        private IBaseService<Setor> _setorService;
        #endregion

        #region Construtor
        public SetorCadastro(IBaseService<Setor> setorService) : base("Setor Cadastro")
        {
            _setorService = setorService;
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
        #endregion

        #region Funções internas
        private void PreencheObjeto(Setor setor)
        {
            setor.Nome = materialTextBoxNome.Text;                        
        }
        #endregion
    }
}
