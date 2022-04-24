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
        public override string Attack()
        {
            return this.Name + " Lançou magia de luz!";
        }
        public override string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return "'Supernova' com bônus de " + bonus;
            }
            else
            {
                return "'Feixe de luz' com bônus de " + bonus;
            }

        }
    }
}