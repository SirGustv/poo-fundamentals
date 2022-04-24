namespace RPGComPOO.src.Entities
{
    public class Ninja : Person
    {
        public Ninja(string name, int level, string typePerson, string hP, string mP)
        {
            this.Name = name;
            this.Level = level;
            this.TypePerson = typePerson;
            this.HP = hP;
            this.MP = mP;
        }
        public Ninja()
        {

        }
        public override string Attack()
        {
            return this.Name + " Sai das sombras!";
        }
        public override string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return "'Letalidade furtiva' com bônus de " + bonus;
            }
            else
            {
                return "'Shurikens' com bônus de " + bonus;
            }

        }
    }
}