using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        private string name;
        private DateTime birthDate;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                _updated = DateTime.Now;
            }
        }
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                _updated = DateTime.Now;
            }
        }
        private DateTime _updated;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            Name = state.Name;
            BirthDate = state.BirthDate;
            _updated = state._updated;
        }

        public override string ToString()
        {
            return $"Nazwa: {Name}, Data urodzenia: {BirthDate.ToShortDateString()} ({_updated})";
        }
    }
}