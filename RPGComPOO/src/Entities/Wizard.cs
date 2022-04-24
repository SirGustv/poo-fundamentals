namespace RPGComPOO.src.Entities
{
    public class Wizard : Person
    {
        public Wizard(string name, int level, string typePerson, string hP, string mP)
        {
            this.Name = name;
            this.Level = level;
            this.TypePerson = typePerson;
            this.MP = mP;
            this.HP = hP;
        }
        public Wizard() { }
    }
}