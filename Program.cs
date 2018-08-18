using System;
using System.Text;

namespace Class6_FullNameAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, there. Please enter your first name: ");
            //Assign user's input into firstName string.
            string firstName = Console.ReadLine();
            //Add space after firstName to get space between first and last name.
            firstName += " ";

            Console.Write("Please enter your last name: ");
            //Assign user's input into lastName string.
            string lastName = Console.ReadLine();

            //Create StringBuilder classes for first and last name strings, in order to
            //append lastName string to firstName string.
            StringBuilder input1 = new StringBuilder(firstName);
            StringBuilder input2 = new StringBuilder(lastName);
     
            //How to append strings from StringBuilder class together: input1.Append(input2);
           
            //Print the entire name by executing new StringBuilder variable input1 and appending
            //variable input2.
            Console.WriteLine($"Your full name is: {input1.Append(input2)}.");
            Console.ReadLine();

        }

       
    }
}
