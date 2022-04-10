using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            //Imprime o valor da variável ou se não existir, imprime o valor padrão do tipo da variável
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Mostra se existe valor ou não valor na variável
            Console.WriteLine("\n" + x.HasValue);
            Console.WriteLine(y.HasValue);

            //Imprime o valor da variável, mas se a variável tover valor null, o programa quebra, por isso fazemos um if else
            if (x.HasValue)
            {
                Console.WriteLine("\n" + x.Value);
            }
            else 
            { 
                Console.WriteLine("\nX is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            //Da o valor de uma variável, mas se essa variável for null, da um outro valor especificado
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine("\n" + a);
            Console.WriteLine(b);
        }
    }
}