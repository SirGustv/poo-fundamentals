

namespace RPGComPOO.src.Entities
{

    public class Person
    {
        public Person(string name, int level, string typePerson, string hP, string mP)
        {
            this.Name = name;
            this.Level = level;
            this.TypePerson = typePerson;
            this.MP = mP;
            this.HP = hP;
        }

        public Person() { }

        public string Name;
        public int Level;
        public string TypePerson;
        public string HP;
        public string MP;

        public override string ToString()
        {
            return this.Name + "\n Lv." + this.Level + " " + this.TypePerson + "\n HP " + this.HP + "\n MP " + this.MP;
        }
        public virtual string Attack()
        {
            return this.Name + " Atacou!";
        }
    }
}