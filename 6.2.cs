using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(3, 8);
            string[] arr = new string[n];
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                int m = rnd.Next(5, 10);
                string temp = "";
                for(int j = 0; j < m; j++)
                {
                    char letter = (char)rnd.Next(0x0061, 0x007A);
                    temp += letter;
                    if(letter !='a' || letter != 'e' || letter != 'i' || letter != 'o' || letter != 'u' || letter != 'y')
                    {
                        count++;
                    }                    
                }
                arr[i] = temp;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Number of consonants is: " + count);
        }
    }
}
