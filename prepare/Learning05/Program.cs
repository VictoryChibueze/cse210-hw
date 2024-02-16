using System;

class Program
{
    static void Main(string[] args)
    {
       Square square = new Square("Red",12.5);
       string squareColor =  square.GetColor();

       Console.WriteLine(squareColor);

       double area = square.GetArea();
       Console.WriteLine(area);
       Console.WriteLine("");

       Circle circle = new Circle("Yellow",32.75);
       string circleColor = circle.GetColor();
       Console.WriteLine(circleColor);

       double circleArea = circle.GetArea();
       Console.WriteLine(circleArea);
       Console.WriteLine("");


       Rectangle rectangle = new Rectangle("Purple",6.23,10.25);
       string rectangleColor = rectangle.GetColor();
       Console.WriteLine(rectangleColor);
      
       double rectangleArea = rectangle.GetArea();
       Console.WriteLine(rectangleArea);



    }
}

