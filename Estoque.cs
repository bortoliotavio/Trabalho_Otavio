using System;

namespace POOII
{
    public class Estoque : Loja
    {


        public string Produto
        {
        get;
        set;
        }
        public int Quantidade_produto
        {
        get;
        set;
        }
        public string Fornecedor
        {
        get;
        set;
        }

        private int contador = (for (int i = 0; i < length; i++)
        {
            
        });
        Produto p = new Produto();
        public override string ToString()
        {
            return Produto + "\t" + Quantidade_produto + "\t" + Fornecedor;
        }

        public void Resumo(){
            foreach (var Produto in Estoque)
            {
                Console.WriteLine()
            }
            
        }
    }
}