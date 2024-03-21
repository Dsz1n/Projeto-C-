using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_C_
{
   public class Industria
    {
        public string Nome {get; set;} = "";
        public string Localizacao {get; set;} = "";
        public int AnoFundacao {get; set;}
        public List<LinhaProducao> LinhaProducao = new List<LinhaProducao>();

        public void ExibirInformacao()
        {
            Console.WriteLine($"{Nome}, {Localizacao}, {AnoFundacao}");

                foreach(var linha in LinhaProducao)
                {
                    linha.ExibirInformacao();
                }
        }

        public void AdicionarLinhaProducao(LinhaProducao linhaProducao)
        {
            this.LinhaProducao.Add(linhaProducao);
        }
    }
}