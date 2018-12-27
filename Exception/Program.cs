using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Ops! Don't Panic " + e.Message);
                Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Ops! Don't Panic " + e.Message);
                Console.ReadLine();
            }
            

        }
    }
}
