using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{
    public class Elevator
    {
        private int _floorNumber;
        public Direction MovingLocation{get; set;}

        public virtual int GetCurrentFloor()
        {
            return _floorNumber;
        }

        public int SetFloor { set { _floorNumber = value; } }
        public string ElevatorName { get; set; }
        public Elevator(string name, int floor, Direction direction)
        {
            this.ElevatorName = name;
            this._floorNumber = floor;
            this.MovingLocation = direction;
        }
    }

}
