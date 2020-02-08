//Create a C# Console application that demonstrates a Method with the following instructions:
//1. As the user to enter their name
//2. Write a method that prints to the Console: "Hello users name!".
//Here's an example of the User Input and Output:
//INPUT: Clinton Daniel
//OUTPUT: Hello Clinton Daniel!


using System;

namespace Deliverable_3___Methods
{
    public class Program
    {
        static void Main(string[] args)

        {
            //Have user enter their first and last name
            Console.WriteLine("Please enter your first and last name: ");

            //declare the user's input as a string
            string Nameinput = Console.ReadLine();
            {

                //display user's input     
                Console.WriteLine("Hello " + "" + Nameinput + "!");
                    
                //Request user select any key to exit
                Console.WriteLine("Hit any key to exit the program");


            }
     
        }
    }
}




