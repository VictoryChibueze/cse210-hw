using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Parse("2022-11-03"), 30, 3.0),
            new StationaryBicycles(DateTime.Parse("2022-11-03"), 30, 6.0),
            new Swimming(DateTime.Parse("2022-11-03"), 30, 10)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }    
    }
}