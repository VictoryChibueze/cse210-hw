using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment = new Assignment("Samuel Burnet","Multiplication");
        Console.WriteLine(assigment.GetSummary());
        Console.WriteLine("");

        MathAssignment assigment2 = new MathAssignment("Samuel Burnet","Fraction","Section 7.3","Problems 8-19");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment assigment3 = new WritingAssignment("Felix Navizdad","African Culture","The evolution of black Nok culture");

        Console.WriteLine(assigment3.GetSummary());
        Console.WriteLine(assigment3.GetWritingInformation());
    }
}