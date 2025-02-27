namespace EpiApp.App.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Documento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
    }

    public class FuncionarioSetorModel
    {
        public int IdFuncionario { get; set; }
        public int IdSetor { get; set; }
    }

    public class FuncionarioEpiModel
    {
        public int IdFuncionario { get; set; }
        public int IdEpi { get; set; }
        //public DateTime DataEntrega { get; set; }
        //public DateTime DataDevolucao { get; set; }
        //public bool IsAberto { get; set; }
    }
}
