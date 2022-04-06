using ArchitecturalPatterns.Commands;
using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.ViewModel
{
    public class ViewModel : NotifyPropertyChanged
    {
        private string inputValue;

        public Model Model { get; set; }

        public string InputValue
        {
            get => inputValue;
            set
            {
                inputValue = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand { get; set; }
        public Command LoadCommand { get; set; }

        public ViewModel()
        {
            Model = new Model();
            SaveCommand = new Command(x => InputValue != Model.Value, x => Model.Value = InputValue);
            LoadCommand = new Command(x => InputValue != Model.Value, x => InputValue = Model.Value);
        }

    }
}
