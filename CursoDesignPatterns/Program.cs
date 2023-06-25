using CursoDesignPatterns;

Imposto iss = new ISS(new ICMS());
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

Imposto ihit = new IHIT();
calculador.RealizaCalculo(orcamento, ihit);

Banco banco = new Banco("NewBank", "(19) 3455-0101", "contato@newbank.com", "Rua dos Bancos, 123, Centro");
ContaBancaria conta1 = new ContaBancaria("Maria", "001", "000001", 500001, DateTime.Now);
ContaBancaria conta2 = new ContaBancaria("João", "001", "000020", 500, DateTime.Now);
ContaBancaria conta3 = new ContaBancaria("Luis", "002", "000144", 99, DateTime.Now);
List<ContaBancaria> contas = new List<ContaBancaria>();
contas.Add(conta1);
contas.Add(conta2);
contas.Add(conta3);

RelatorioSimples relatSimples = new RelatorioSimples();
relatSimples.Imprimir(banco, contas);

RelatorioComplexo relComplexo = new RelatorioComplexo();
relComplexo.Imprimir(banco, contas);

Imposto ima = new IMA(new ISS());
calculador.RealizaCalculo(orcamento, ima);

FiltroMenorQue100Reais filtroMenorQue100Reais = new FiltroMenorQue100Reais(new FiltroMaiorQue500MilReais(new FiltroMesmoMes()));
var fraudulentas = filtroMenorQue100Reais.Filtra(contas);
foreach (var fraudulenta in fraudulentas)
{
    Console.WriteLine($"{fraudulenta.NomeTitular} - {fraudulenta.Agencia} {fraudulenta.NumeroConta} - R$ {fraudulenta.Saldo} {fraudulenta.Abertura}");
}

Orcamento reforma = new Orcamento(500);

Console.WriteLine(reforma.Valor);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Aprova();

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Finaliza();

ContaBancaria conta4 = new ContaBancaria("Leonardo", 10);
Console.WriteLine(conta4.Saldo);

conta4.Deposito(5);
Console.WriteLine(conta4.Saldo);

conta4.Saque(20);
Console.WriteLine(conta4.Saldo);

conta4.Deposito(100);
Console.WriteLine(conta4.Saldo);

NotaFiscalBuilder criador = new NotaFiscalBuilder();
criador
    .ParaEmpresa("Caelum Ensino e Inovação")
    .ComCnpj("23.456.789/0001-12")
    .NaDataAtual()
    .ComObservacoes("Uma observação qualquer.")
    .ComItem(new ItemDaNota("Item 1", 100.0))
    .ComItem(new ItemDaNota("Item 2", 200.0));

NotaFiscal nf = criador.Constroi();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);

Console.ReadKey();