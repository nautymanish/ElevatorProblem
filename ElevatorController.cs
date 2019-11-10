using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProblem
{/// <summary>
/// This is kind of observer pattern where in the client can add any number of elevators/ person according to thier implementation
/// </summary>
    public class ElevatorController
    {
        private List<Elevator> _elevators = new List<Elevator>();
        private Person _person;
        public Person PersonRequested { get { return this._person; }  set { this._person = value; NotifyPersonForTheLift(); } } // this is considering single person for multiple request it can be in List
        public void Attach(Elevator elevator)
        {
            _elevators.Add(elevator);
        }

        public void Detach(Elevator elevator)
        {
            _elevators.Remove(elevator);
        }
        public void SetFloor(Elevator e, int floor)
        {
            foreach (var elevator in _elevators)
            {
                if (elevator.ElevatorName == e.ElevatorName)// this can be ID as well
                {
                    elevator.SetFloor = floor;
                    NotifyPersonForTheLift();
                }
            }

        }
        /// <summary>
        /// THis is the notifier function and will be called any time the elevator changes it floor
        /// </summary>
        public void NotifyPersonForTheLift()
        {
            if (PersonRequested != null)
            {
                Elevator el = null;
                foreach (Elevator elevator in _elevators)
                {
                    var diff = Int32.MaxValue;// use to calculate the less different elevator than the person
                    if (elevator.MovingLocation == PersonRequested.DirectionPressed || elevator.MovingLocation == Direction.NULL)
                    {

                        if (Math.Abs(Math.Abs(elevator.GetCurrentFloor()) - Math.Abs(PersonRequested.CurrentFloor)) >= 0 && Math.Abs(Math.Abs(elevator.GetCurrentFloor()) - Math.Abs(PersonRequested.CurrentFloor)) <= diff)
                        {
                            diff = Math.Abs(Math.Abs(elevator.GetCurrentFloor()) - Math.Abs(PersonRequested.CurrentFloor));
                            el = elevator;
                            if (diff == 0) //means elevator and person at same location
                                break;
                            
                        }
                    }
                }
                if(el!=null)
                PersonRequested.Update(el);
            }
        }
    }
}
