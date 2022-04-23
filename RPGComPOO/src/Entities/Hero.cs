

namespace RPGComPOO.scr.Entities
{

    public class Person
    {
        public Person(string name, int level, string typePerson)
        {
            this.Name = name;
            this.Level = level;
            this.TypePerson = typePerson;
        }

        public string Name;
        public int Level;
        public string TypePerson;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.TypePerson;
        }
    }
}