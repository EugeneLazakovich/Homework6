using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int index1 = name.IndexOf(" ");
            string surname = name.Substring(0, index1);
            string name1 = name.Substring(index1 + 1);
            int index2 = name1.IndexOf(" ");
            string firstName = name1.Substring(0, index2);
            firstName = firstName.Substring(0, 1).ToUpper() + '.';
            string secondName = name1.Substring(index2 + 1);
            secondName = secondName.Substring(0, 1).ToUpper() + '.';
            string[] arr = new string[surname.Length];
            arr[0] = surname[0].ToString().ToUpper();
            surname = arr[0] + surname.Substring(1, surname.Length - 1);
            Console.Write(surname + ' ');
            Console.Write(firstName);
            Console.WriteLine(secondName);
        }
    }
}
