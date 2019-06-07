using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();            
            string[] words = name.Split(' ');
            string surname = "";
            string firstName = "";
            string secondName = "";
            for (int i = 0; i < words.Length; i++)
            {
                surname = words[0];
                firstName = words[1];
                secondName = words[2];
            }
            string[] arr = new string[surname.Length];
            arr[0] = surname[0].ToString().ToUpper();
            surname = arr[0] + surname.Substring(1, surname.Length - 1);
            firstName = firstName.Substring(0, 1).ToUpper() + '.';
            secondName = secondName.Substring(0, 1).ToUpper() + '.';
            Console.Clear();
            Console.Write(surname + ' ');
            Console.Write(firstName);
            Console.WriteLine(secondName);
        }
    }
}
