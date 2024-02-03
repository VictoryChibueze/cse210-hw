using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        String verse1 = "John 9: 31 :Now we know that God heareth not sinners: but if any man be a worshipper of God, and doeth his will, him he heareth.";

        Console.WriteLine("Press enter to continue or type 'quit' to finish");

        Word word = new Word("");

        Reference reference = new Reference("Peter",2,12);
        Console.WriteLine(reference._book);

        



        

        
    }
}



