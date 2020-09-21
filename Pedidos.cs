using System;

namespace POOII
{
    public class Pedidos : Loja
    {
        public DateTime Data = DateTime.Today;

        public string Nome_cliente;

        public DateTime Data_envio;

        public void dispache(){

            Console.WriteLine($"{Data}");
        }
    }
}