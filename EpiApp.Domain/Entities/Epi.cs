using EpiApp.Domain.Base;

namespace EpiApp.Domain.Entities
{
    public class Epi : BaseEntity<int>
    {
        public Epi()
        {
            Setores = new List<EpiSetor>();
            Funcionarios = new List<FuncionarioEpi>();
        }

        public Epi(int id, string nome, string ca, DateTime validadeCa, 
            int prazoTroca, List<EpiSetor> setores, 
            List<FuncionarioEpi> funcionarios) : base(id)
        {
            Nome = nome;
            Ca = ca;
            ValidadeCa = validadeCa;
            PrazoTroca = prazoTroca;
            Setores = setores;
            Funcionarios = funcionarios;
        }

        public string? Nome { get; set; }
        public string? Ca { get; set; }
        public DateTime? ValidadeCa { get; set; }
        public int PrazoTroca { get; set; }
        public virtual List<EpiSetor> Setores { get; set; }
        public virtual List<FuncionarioEpi> Funcionarios { get; set; }
    }
    
    public class EpiSetor : BaseEntity<int>
    {
        public EpiSetor()
        {

        }

        public EpiSetor(int id, int idEpi, int idSetor) : base(id)
        {            
            IdEpi = idEpi;
            IdSetor = idSetor;
        }

        public int IdEpi { get; set; }
        public Epi? Epi { get; set; }
        public int IdSetor { get; set; }
        public Setor? Setor { get; set; }
    }
}