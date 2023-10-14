using System.Drawing;


namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Multiplication Table

            bool validUserInput;
            int validUserOutput;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t\t|-+-+-+-+-+-+-+-+-+-+-+-+|");
                Console.WriteLine("\t\t\t\t\t\t|* MULTIPLICATION TABLE *|");
                Console.WriteLine("\t\t\t\t\t\t|-+-+-+-+-+-+-+-+-+-+-+-+|");
                Console.WriteLine("\n");

                Console.Write(" Enter a number: ");
                Console.ForegroundColor = ConsoleColor.Green;

                validUserInput = int.TryParse(Console.ReadLine(), out validUserOutput);
                Console.WriteLine("\n");

            } while (validUserInput == !true);
            
            for (int i = validUserOutput; i <= 10000; i += validUserOutput)
            {
                Console.Write($"{i}\t");
            }
                Console.ReadLine();


            
            
            

                
        }  
    }
}