// See https://aka.ms/new-console-template for more information
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade = 'S';
            int health = 100;
            float attack = 36.5f;

            Console.Write("1000 ; " + health + " / ");
            Console.Write("500 ; " + attack + " / ");

            Console.WriteLine("Hello World!");
            Console.WriteLine("10 ; " + grade);


        }
    }
}