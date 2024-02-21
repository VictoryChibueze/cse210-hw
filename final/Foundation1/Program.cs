using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Blockchain development","Aderup Jeraph",360);
        video1.AddComment("Ekeh Kings","This is the most enlightening video I have seen on Youtube..Keep it up bro");
        video1.AddComment("Mpuwasa Sultan","Lost hope on understanding basic of blockchain but this is a renewed hope");

        Video video2 = new Video("Using hooks in reactjs","Julius Emmanuel",400);
        video2.AddComment("Jireh Shalom","React hooks are actually difficult concept to understand but you simplified it");
        video2.AddComment("Ibe Favour","More of such content Julius,bravo man!!");

        Video video3 = new Video("Building cryptocurrency bots with python","Micheal Dow",600);
        video3.AddComment("Yemal Lamine","I have being trying to build a crypto bot but here comes a good guide");
        video3.AddComment("Berbatov Guraj","This video deserves more accolade than many paid courses out there");
        Video video4 = new Video("Rudiments of electro-Magnetic field","Jamie Brown",660);
        video4.AddComment("Shawn Mike","I'm in my sophomore and this video have being a great help.");
        video4.AddComment("John Bobs","The best electro-magnetic field tutorial you'll see on the internet");

        List<Video> videoList = new List<Video>{video1,video2,video3,video4};


        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Duration: {video._length}s");
            Console.WriteLine($"Number of Comment: {video.GetNumberComment()} comments");
          
            foreach (Comment textComment in video._comments)
            {
                Console.WriteLine($"{textComment._name}: {textComment._text}");
            }
            Console.WriteLine($"");
            
            
        }

        
    }
}