using System;
using System.Buffers.Binary;

namespace BomDiaTardeNoite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Qual a hora atual? (HH)");
                int hora = int.Parse(Console.ReadLine());

                if (hora < 12)
                    Console.WriteLine("Bom dia!");
                else if (hora < 18)
                    Console.WriteLine("Boa tarde!");
                else if(hora<25)
                    Console.WriteLine("Boa noite!");
                else
                    Console.WriteLine("Hora inválida");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
