namespace EpiApp.App.Models
{
    public class EpiModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Ca { get; set; }
        public DateTime? ValidadeCa { get; set; }
        public int PrazoTroca { get; set; }

    }

    public class EpiSetorModel
    {
        public int IdEpi { get; set; }
        public int IdSetor { get; set; }
    }
}
