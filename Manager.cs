using HRproject;

public class Manager : Employee
{
   

    public decimal Allowance()
    {

        return base.Totel() * 5 / 100;

    }
    public override decimal Totel()
    {
        return base.Totel() + Allowance();
    }
    public override string ToString()
    {
        return "\t\tManager" +
               "\n----------------------------" +
               base.ToString() +
               $"\nAllowance : {Allowance()}" +
               $"\nNet Salary : {this.Totel()}";
    }
}