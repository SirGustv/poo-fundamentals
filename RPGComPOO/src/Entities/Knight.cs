namespace RPGComPOO.src.Entities
{
    public class Knight : Person
    {
        public Knight(string name, int level, string typePerson, string hP, string mP)
        {
            this.Name = name;
            this.Level = level;
            this.TypePerson = typePerson;
            this.HP = hP;
            this.MP = mP;
        }
        public Knight()
        {

        }
        public override string Attack()
        {
            return this.Name + " Atacou com sua espada.";
        }
        public override string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return "'Ataque pesado' com bônus de " + bonus;
            }
            else
            {
                return "'Ataque leve' com bônus de " + bonus;
            }

        }
    }
}