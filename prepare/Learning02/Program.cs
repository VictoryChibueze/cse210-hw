using System;

using learning02;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer"; 
        job1._company = "Apple";
        job1._startYear = 2006;
        job1._endYear = 2011;
        
        Job job2 = new Job();
        job2._jobTitle = "Product Designer";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2020;


        Resume myResume = new Resume();
        myResume.personName = "Victory Chibueze";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

       



    }
}

 






// public class Resume
// {
//    string _name;
//    List<string> job = new List<string>();
   
// }

