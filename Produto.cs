using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_
{
    public class Produto
    {
        public string Nome {get; set;}
        public int Codigo {get; set;}
        public decimal Preco {get; set;}

            public void ExibirInformacao()
            {
                Console.WriteLine(Nome);
                Console.WriteLine(Codigo);
                Console.WriteLine(Preco);
            }

            public void AtualizaValor(decimal novoPreco) 
            {
                this.Preco = novoPreco;
            }
    }
}