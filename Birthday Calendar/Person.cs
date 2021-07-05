using System;

namespace Birthday_Calendar
{
    public class Person : ICloneable, IEquatable<Person>
    {
        public string name { get; }
        public string birthdate { get; }
        public DateTime getBirthdate()
        {
            return DateTime.Parse(birthdate);
        }

        public object Clone()
        {
            return new Person(this.name, DateTime.Parse(this.birthdate));
        }

        public bool Equals(Person other)
        {
            if (other is null) return false;
            return other.name.Equals(name) && other.birthdate.Equals(birthdate);
        }

        public Person(string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate.ToString(BirthdayContacts.cDateFormat);
        }

        public override string ToString()
        {
            return name + ", *" + birthdate;
        }

    }
}
