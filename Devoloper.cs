using HRproject;

public class Devoloper : Employee
{
   
    private bool TaskCompleated { get; set; }=false;
    public decimal Bonus()
    {
        if (TaskCompleated)
        {
            return Totel() * 3 / 100;
        }
        else
         return 0; 
    }
    public override decimal Totel()
    {
        return base.Totel() + Bonus();
    }
    public override string ToString()
    {
        return "\t\tDevoloper" +
               "----------------------------" +
               base.ToString() +
               $"Task Compleated : {TaskCompleated}" +
               $"Bonus : {Bonus()}" +
               $"Net Salary : {Totel()}";

    }
}