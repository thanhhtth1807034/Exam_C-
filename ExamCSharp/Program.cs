using System;
using System.Text.RegularExpressions;

namespace ExamCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// fig:1
            var people = new People("",true, 25 );
            if (people.Gender)
            {
                Console.WriteLine("Name = {0}, Gender = Male, Age = {1}", people.Name, people.Age);
            }
            
            people.Age += 10;
            
            if (people.Gender){
                
                Console.WriteLine("Name = {0}, Gender = Male, Age = {1}", people.Name, people.Age);
            }
            
            ///Fig:2
            Console.WriteLine("Enter a String: ");
            var strg = Console.ReadLine();
            Console.WriteLine("Enter a word to search: ");
            var word = Console.ReadLine();
            var found = Regex.Matches(strg, word).Count;
            Console.WriteLine("Word found {0} times in the string", found);
        }
    }
}