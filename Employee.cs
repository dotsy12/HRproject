namespace HRproject
{
    abstract public class Employee
    {
        private const int MinLoggedHours = 176;
        private const decimal RateOfOverTime = 1.25m;
        private bool taskCompleated;

     
       
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }

        public decimal calculateBaseSalary()
        {
            return MinLoggedHours * Wage;
        }

        public   decimal calculateOverTime()
        {
            if (LoggedHours > MinLoggedHours)
            {
                return (LoggedHours - MinLoggedHours) * RateOfOverTime * Wage;
            }
            else
            {
                return 0;
            }
        }
        public virtual decimal Totel()
        {
            return calculateBaseSalary() + calculateOverTime();
        }

        public override string ToString()
        {
                return $"\nId : {Id}" +
                       $"\nName : {Name}" +
                       $"\nLogged Hours : {LoggedHours}" +
                       $"\nWage : {Wage}/hr" +
                       $"\nBase Salary : {calculateBaseSalary()}" +
                       $"\nOver Time : {calculateOverTime()}";
                
        }

    }
}
