using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class RelatorioComplexo : TemplateRelatorio
{
    public override void Cabecalho(Banco banco)
    {
        Console.WriteLine("*******************************************************");
        Console.WriteLine($"Banco {banco.Nome}");
        Console.WriteLine($"Endereço: {banco.Endereco}");
        Console.WriteLine($"Telefone: {banco.Telefone}");
        Console.WriteLine("*******************************************************");
    }

    public override void Corpo(List<ContaBancaria> contas)
    {
        foreach (var conta in contas)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Titular: {conta.NomeTitular}");
            Console.WriteLine($"Agência: {conta.Agencia} - Conta: {conta.NumeroConta}");
            Console.WriteLine($"Saldo: R$ {conta.Saldo}");
            Console.WriteLine("-------------------------------------------------------");
        }
    }

    public override void Rodape(Banco banco)
    {
        Console.WriteLine("*******************************************************");
        Console.WriteLine($"E-mail: {banco.Email}");
        Console.WriteLine($"Data Atual: {DateTime.Now}");
        Console.WriteLine("*******************************************************");
    }
}
