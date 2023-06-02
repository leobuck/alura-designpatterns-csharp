using CursoDesignPatterns;

Imposto iss = new ISS();
Imposto icms = new ICMS();
Imposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(500);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();

calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, iccc);

Investimento conservador = new Conservador();
Investimento moderado = new Moderado();
Investimento arrojado = new Moderado();

ContaBancaria conta = new ContaBancaria("Ana", 500);

RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();

realizador.RealizaCalculo(conta, conservador);
realizador.RealizaCalculo(conta, moderado);
realizador.RealizaCalculo(conta, arrojado);

CalculadorDeDescontos calculadorDeDeDescontos = new CalculadorDeDescontos();

orcamento.AdicionaItem(new Item("Caneta", 250));
orcamento.AdicionaItem(new Item("Lapis", 250));
orcamento.AdicionaItem(new Item("Geladeira", 250));
orcamento.AdicionaItem(new Item("Fogão", 250));
orcamento.AdicionaItem(new Item("Microondas", 250));
//orcamento.AdicionaItem(new Item("Xbox", 250));

double desconto = calculadorDeDeDescontos.Calcula(orcamento);
Console.WriteLine($"Desconto: {desconto}");

CorrenteDeFormato formatador = new CorrenteDeFormato();

Requisicao req1 = new Requisicao(Formato.XML);
Requisicao req2 = new Requisicao(Formato.CSV);
Requisicao req3 = new Requisicao(Formato.PORCENTO);

string formato1 = formatador.Formata(req1, conta);
Console.WriteLine(formato1);

string formato2 = formatador.Formata(req2, conta);
Console.WriteLine(formato2);

string formato3 = formatador.Formata(req3, conta);
Console.WriteLine(formato3);

Imposto icpp = new ICPP();
calculador.RealizaCalculo(orcamento, icpp);

Imposto ikcv = new IKCV();
calculador.RealizaCalculo(orcamento, ikcv);

Console.ReadKey();