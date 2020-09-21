using System;

namespace POOII
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Loja l1 = new Loja();
            l1.Cod_Loja = 1;

            

            Console.WriteLine($"codigo loja {l1.Cod_Loja}");
        }
    }
}
