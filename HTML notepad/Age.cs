using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");//user inputs their name
            string name = Console.ReadLine();//this pauses the program while you input a certain name
            Console.Write("Enter your age: ");  // user inputs their age
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " and you are " + age + " years old. ");//this prints out the name and the age of the user
           
            if (age >= 23) //this checks the age of the user if it's greater than or equal to 23 years old
            {
                Console.WriteLine("You're tall at the age of 23");// if the inputted age is above 23 this is the output 
            }
            else // and this else statement checks if the age of the user is below 23
            {
                Console.WriteLine("You're below 5'6 at the age of 23");//and if the age inpputed is belowm 23 this is the output
            }

        }
    }
}  





