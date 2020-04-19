using System;
using System.Buffers.Binary;

namespace BomDiaTardeNoite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual? (HH)");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
                Console.WriteLine("Bom dia!");
            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");
        }
    }
}
