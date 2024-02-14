public class BreathingActivity:Activity
{
    public BreathingActivity(string name = "Breathing", string description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",int duration = 10):base(name,description,duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(startTime < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Now Breath out...");
            ShowCountDown(5);

            Console.WriteLine("");

            startTime = DateTime.Now;
            

        }

        Console.WriteLine("\n");

        DisplayEndingMessage();
        Console.Clear();

    }
}