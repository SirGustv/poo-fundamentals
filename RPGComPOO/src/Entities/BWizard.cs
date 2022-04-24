namespace RPGComPOO.src.Entities
{
    public class BWizard : Person
    {
        public BWizard(string name, int level, string typePerson, string hP, string mP)
        {
            this.Name = name;
            this.Level = level;
            this.TypePerson = typePerson;
            this.HP = hP;
            this.MP = mP;
        }
        public BWizard()
        {

        }
        public override string Attack()
        {
            return this.Name + " Lançou magia negra!";
        }
        public override string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return "'Buraco negro' com bônus de " + bonus;
            }
            else
            {
                return "'Náusea' com bônus de " + bonus;
            }

        }
    }
}