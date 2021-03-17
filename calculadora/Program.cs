using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0){
                Console.WriteLine($"O número {num} é PAR.");
            }else{
                Console.WriteLine($"O número {num} é IMPAR.");
            }
        }
    }
}
