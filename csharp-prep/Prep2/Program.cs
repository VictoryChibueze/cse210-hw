using System;

class Program
{
    static void Main(string[] args)
    {  
        // Prompting the user for his/her grade percentage
        Console.WriteLine("Enter your grade percentage(no % needed): ");
        string userGrade = Console.ReadLine();

        // converting user grade to interger
        int userGradeInInt = int.Parse(userGrade);
        // initializing  the letter variable
        string letter = "";

        // Initializing the specific grade varible
        int specificGrade = userGradeInInt % 10;
        
        // intializing the grade sign and final result variable
        string gradeSignPlus = "+";
        string gradeSignMinus = "-";
        string result ;

        // If block to determine the grade of the user
        if(userGradeInInt >= 90)
        { 
            letter = "A";
           
        }
        else if (userGradeInInt >=80)
        { 
            letter = "B";
            
        }
        else if (userGradeInInt >=70)
        {
            letter = "C";
        }
        else if (userGradeInInt >=60)
        {
            letter = "D";
        }
        else if (userGradeInInt < 60){
            letter = "F";
            
        }

                
        //  Conditional block for instructor evaluation of the user
        if (letter == "A" || letter =="B" || letter == "C")
        {
            Console.WriteLine("Congratulations, you passed!!");

        }
        else
        {
            Console.WriteLine("Sorry, you have to put more effort next time..");

        }

        // conditional block to determine the grade sign and specific grade where signs arent needed
        if ((specificGrade>=7) && (letter == "A" || letter == "F")){
            result = letter;
        }
        else if(specificGrade >=7)
        {
            result = letter + "" + gradeSignPlus;
        }
        else if (specificGrade <3)
        {
            result = letter + "" + gradeSignMinus;

        }
        else{
            result = letter;
        }
        Console.WriteLine($"Your grade is: {result}");

    }

}