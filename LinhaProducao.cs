using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_
{
    public class LinhaProducao
    {
        public int Numero {get; set;}
        public string Tipo {get; set;}
        public int Capacidade {get; set;}
        public List<Maquina> Maquina = new List<Maquina>();
    
    public void ExibirInformacao()
    {
        Console.WriteLine(Numero);
        Console.WriteLine(Tipo);
        Console.WriteLine(Capacidade);
        foreach(var maquina in Maquina)
        {
            maquina.ExibirInformacao();
        }
    }
        public void AdicionarMaquina(Maquina maquina)
        {
            this.Maquina.Add(maquina);
        }
    }
}