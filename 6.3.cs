using System;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] database = new string[3][];
            database[0] = new string[3];
            database[1] = new string[3];
            database[2] = new string[3];
            database[0][0] = "Ann";
            database[0][1] = "20";
            database[0][2] = "Bucha";
            database[1][0] = "Jack";
            database[1][1] = "20";
            database[1][2] = "Irpen";
            database[2][0] = "Sofie";
            database[2][1] = "19";
            database[2][2] = "Bucha";

            Console.WriteLine("Please enter your searching word");
            string search = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < database.Length; i++)
            {
                for(int j = 0; j < database[i].Length; j++)
                {
                    if (search == database[i][j])
                    {
                        Console.Write(database[i][0] + " ");
                        Console.Write(database[i][1] + " ");
                        Console.Write(database[i][2]);
                        Console.WriteLine();
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No coincidence");
            }
        }
    }
}
