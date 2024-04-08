using System;
using System.ComponentModel.Design;
namespace ComplexIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 100");
            string userValue = Console.ReadLine();  
            int compareValue = int.Parse(userValue);


            if ((compareValue < 1) || (compareValue > 100))

                Console.WriteLine("The number is out of bound");

            else if
            ((compareValue == 42) || (compareValue < 90))
                Console.WriteLine("You found one of the special numbers!");
            else
                Console.WriteLine("You did not find one of the special numnbers");
            Console.ReadLine();
                
           

            
            
        }
    }
}
