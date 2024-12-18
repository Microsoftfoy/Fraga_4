using System;
namespace Fraga_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String password;

            do
            {
                Console.WriteLine("Ange lösenordet: ");
                Console.WriteLine("Hint: Lösenordet är Hemligt");
                password = Console.ReadLine();
            }   while (password != "Hemligt");



        }
    }
}
