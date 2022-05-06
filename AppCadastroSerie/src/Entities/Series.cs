namespace AppCadastroSerie
{
    public class Series : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Tttle { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
    }
}