using EpiApp.Domain.Base;

namespace EpiApp.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario()
        {
            Setores = new List<FuncionarioSetor>();
            Epis = new List<FuncionarioEpi>();
        }

        public Funcionario(int id, string nome, string documento, bool ativo, 
            DateTime dataNascimento, List<FuncionarioSetor> setores,
            List<FuncionarioEpi> epis) : base(id)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;
            Ativo = ativo;
            Setores = setores;
            Epis = epis;
        }

        public string? Nome { get; set; }
        public string? Documento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual List<FuncionarioSetor> Setores { get; set; }
        public virtual List<FuncionarioEpi> Epis { get; set; }
    }

    public class FuncionarioSetor : BaseEntity<int>
    {
        public FuncionarioSetor()
        {

        }

        public FuncionarioSetor(int id, int funcionarioId, int setorId) : base(id)
        {
            FuncionarioId = funcionarioId;
            SetorId = setorId;
        }

        public int FuncionarioId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
        public int SetorId { get; set; }
        public virtual Setor? Setor { get; set; }
    }
    public class FuncionarioEpi : BaseEntity<int>
    {
        public FuncionarioEpi()
        {

        }

        public FuncionarioEpi(int id, int funcionarioId, int epiId) : base(id)
        {
            FuncionarioId = funcionarioId;
            EpiId = epiId;
        }

        public int FuncionarioId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
        public int EpiId { get; set; }
        public virtual Epi? Epi { get; set; }


        // Data Entrega
        // public dateTime
        // Data Devolução
    }
}