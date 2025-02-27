using EpiApp.Domain.Base;

namespace EpiApp.Domain.Entities
{
    public class Setor : BaseEntity<int>
    {
        public Setor()
        {
            Epis = new List<EpiSetor>();
            Funcionarios = new List<FuncionarioSetor>();
        }

        public Setor(int id, string nome, List<EpiSetor> epis, List<FuncionarioSetor> funcionarios) : base(id)
        {            
            Nome = nome;
            Epis = epis;
            Funcionarios = funcionarios;
        }

        public string? Nome { get; set; }
        public virtual List<EpiSetor> Epis {  get; set; }
        public virtual List<FuncionarioSetor> Funcionarios { get; set; }
    }
}