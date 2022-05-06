namespace AppCadastroSerie
{
    public class Series : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        public Series(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genre + "\n";
            retorno += "Tìtulo: " + this.Title + "\n";
            retorno += "Descrição: " + this.Description + "\n";
            retorno += "Ano: " + this.Year;
            return retorno;
        }

        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId()
        {
            return this.Id;
        }
    }
}