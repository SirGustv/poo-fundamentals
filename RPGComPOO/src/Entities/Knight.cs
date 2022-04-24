namespace RPGComPOO.src.Entities
{
    public class Knight : Person
    {
        public Knight(string name, int level, string typePerson) : base(name, level, typePerson)
        {
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua espada.";
        }
    }
}