using System;

namespace HRproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager man = new Manager { Id = 1 ,Name="dotse",LoggedHours=200,Wage=10};   
            Console.WriteLine(man);
            Console.ReadKey();
        }
    }
}
