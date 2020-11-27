namespace ElevatorProblem
{
    public class Person 
    {
        public int CurrentFloor { get; set; }
        public Direction DirectionPressed { get; set; }
        private void DoFirst()
        {
        }
        public void Update(Elevator elevator)
        {
            int num = 0;
            // Non compliant code  
                try  
                {  
                  // Code that might have exception  
                    if (num < 0)  
{  
  DoFirst();  
  
}  
else if (num > 1 && num < 3)  
{  
  DoFirst();  // Duplicate code  
 
}  
else  
{  
  DoSomething();  
}  
                }  
                finally  
                {  
                   throw new Exception("Error in finally");  
                }  
        }
        
    }
}
