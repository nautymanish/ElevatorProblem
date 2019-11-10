using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{
    public class Person 
    {
        public int CurrentFloor { get; set; }
        public Direction DirectionPressed { get; set; }

        public void Update(Elevator elevator)
        {
            Console.Write("This elevator is goign to be arrving first.");
            Console.Write(elevator.ElevatorName);
        }
    }
}
