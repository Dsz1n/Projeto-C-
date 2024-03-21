using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_
{
    public class Maquina
    {
        public int Id {get; set;}
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public Produto Produto = new Produto();

        public void ExibirInformacao()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
        }

        public void IniciarProducao()
        {
            Console.WriteLine("Iniciando produção");
        }
    }    
}