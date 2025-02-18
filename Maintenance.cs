using HRproject;

public class Maintenance : Employee
{
    private const int Haredship  = 100;

  
    public override decimal Totel()
    {
        return base.Totel() + Haredship ;
    }

    public override string ToString()
    {
        return "\t\tMaintenance" +
               "----------------------------" +
               base.ToString() +
               $"Haredship : {Haredship}" +
               $"Net Salary : {Totel()}";

    }
}