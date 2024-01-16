using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Jr DevOps";
        job1._startYear = 2022;
        job1._endYear = 2023;

        job1.Display();
    }


              
}