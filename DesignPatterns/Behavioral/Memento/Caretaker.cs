using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private List<Memento<T>> _mementos = new List<Memento<T>>();
        private T _originator;
        public Caretaker(T originator)
        {
            _originator = originator;
        }
        public void SaveState()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            _mementos.Add(new Memento<T>((T)_originator.Clone()));
        }
        public void RestoreState(DateTime from)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= from);
            if (memento == null)
                return;

            Restore(memento);
        }

        private void Restore(Memento<T> memento)
        {
            Console.WriteLine("Caretaker: Restoring state to: " + memento.DateTime);
            _originator.Restore(memento.State);
        }

        public void RestoreLastState()
        {
            if (!_mementos.Any())
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);
            Restore(memento);
        }
    }
}
