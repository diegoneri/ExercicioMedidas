using System;

namespace ExercicioMedidas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            //Falar para o usuario sobre o programa
            Console.WriteLine("--- Conversor de Metros para Km ---");
            // pedir para ele digitar quantos metros que ele quer converter
            Console.WriteLine("");
            Console.Write("Digite...: ");
            string Metros = Console.ReadLine();
            //apagar
            Console.Clear();
            //Converter para kilometros / 1000
            Console.WriteLine("--- Conversão para Km ---");
            Console.WriteLine("");
            Console.WriteLine($"Metros...: {Metros} m");
            Console.WriteLine("");
            Decimal Mdigt = Convert.ToDecimal(Metros);
            Decimal X = 1000;
            Decimal Rkm = Mdigt / X;
            //mostrar o resultado
            Console.WriteLine($"Kilometros: {Rkm} Km");
            //Converter para centimetros * 100
            Decimal Y = 100;
            Decimal Rcm = Mdigt * Y;
            //apagar
            Console.ReadKey();            
            Console.Clear();
            //mostrar metros e a conversao para cm
            Console.WriteLine("--- Conversão para Centimetros ---");
            Console.WriteLine("");
            Console.WriteLine($"Metros...: {Metros} m");
            Console.WriteLine("");
            Console.WriteLine($"Centimetros: {Rcm} Cm");

            //apagar
            Console.ReadKey();            
            Console.Clear();
            //mostrar o resultado
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------Resultado---------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine($"{Metros} m");
            Console.WriteLine("");
            Console.WriteLine($"{Rkm} Km");
            Console.WriteLine("");
            Console.WriteLine($"{Rcm} Cm");
            Console.WriteLine("");
            Console.WriteLine("--------------------------");

            Console.ReadKey();
            Console.Clear();







        }
    }
}
