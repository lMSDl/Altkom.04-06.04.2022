using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class GardenCommand : ICommand
    {
        private Garden _garden;
        private GardenAction _action;
        private string _plant;

        public GardenCommand(Garden garden, GardenAction action, string plant)
        {
            _garden = garden;
            _action = action;
            _plant = plant;
        }

        public bool Execute()
        {
            switch (_action)
            {
                case GardenAction.Plant:
                    return _garden.Plant(_plant);
                case GardenAction.Remove:
                    return _garden.Remove(_plant);
            }
            return false;
        }

        public void Undo()
        {
            switch (_action)
            {
                case GardenAction.Remove:
                    _garden.Plant(_plant);
                    break;
                case GardenAction.Plant:
                    _garden.Remove(_plant);
                    break;
            }
        }
    }
}
