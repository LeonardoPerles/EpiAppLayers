    using EpiApp.App.Base;
using EpiApp.App.Models;
using EpiApp.Domain.Base;
using EpiApp.Domain.Entities;
using EpiApp.Services.Validators;
using ReaLTaiizor.Controls;
using System.Diagnostics;

namespace EpiApp.App.Cadastro
{
    public partial class SetorCadastro : BaseCadastro<Setor, SetorModel, SetorValidator>
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

        public SetorCadastro(IBaseService<Setor> setorService, SetorModel setorModel) : base("Setor Cadastro")
        {
            _setorService = setorService;
            InitializeComponent();
            CarregaCampos(setorModel);
        }
        #endregion

        #region Metodos sobrepostos
        protected override void CarregaCampos(SetorModel setorModel)
        {
            materialTextBoxId.Text = setorModel.Id.ToString();
            materialTextBoxNome.Text = setorModel.Nome;
        }
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
