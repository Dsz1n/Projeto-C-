using Projeto_C_;

Industria industria = new Industria();
industria.Nome = "pipis";
industria.AnoFundacao = 1990;
industria.Localizacao = "Curitiba";

LinhaProducao linhaProducao1 = new LinhaProducao();
linhaProducao1.Numero = 1;
linhaProducao1.Capacidade = 8;
linhaProducao1.Tipo = "Prensa";

LinhaProducao linhaProducao2 = new LinhaProducao();
linhaProducao2.Numero = 1;
linhaProducao2.Capacidade = 8;
linhaProducao2.Tipo = "Prensa";

Produto produto1 = new Produto();
produto1.Nome = "Farinha";
produto1.Codigo = 40028922;
produto1.Preco = 13.90m;

Produto produto2 = new Produto();
produto2.Nome = "Sorvete";
produto2.Codigo = 40028923;
produto2.Preco = 20.40m;

Produto produto3 = new Produto();
produto3.Nome = "Banana";
produto3.Codigo = 40028924;
produto3.Preco = 10.00m;

Produto produto4 = new Produto();
produto4.Nome = "Picanha";
produto4.Codigo = 40028925;
produto4.Preco = 65.50m;

Maquina maquina1 = new Maquina();
maquina1.Id = 1;
maquina1.Marca = "Bosch";
maquina1.Modelo = "xj6";

Maquina maquina2 = new Maquina();
maquina2.Id = 2;
maquina2.Marca = "Electrolux";
maquina2.Modelo = "xj7";

Maquina maquina3 = new Maquina();
maquina1.Id = 3;
maquina1.Marca = "Bosch";
maquina1.Modelo = "xj6";

Maquina maquina4 = new Maquina();
maquina2.Id = 4;
maquina2.Marca = "Electrolux";
maquina2.Modelo = "xj7";


linhaProducao1.AdicionarMaquina(maquina1);
linhaProducao1.AdicionarMaquina(maquina2);
linhaProducao2.AdicionarMaquina(maquina3);
linhaProducao2.AdicionarMaquina(maquina4);

industria.AdicionarLinhaProducao(linhaProducao1);
industria.AdicionarLinhaProducao(linhaProducao2);

industria.ExibirInformacao();
