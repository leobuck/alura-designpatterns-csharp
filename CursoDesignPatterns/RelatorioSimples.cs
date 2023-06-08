using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class RelatorioSimples : TemplateRelatorio
{
    public override void Cabecalho(Banco banco)
    {
        Console.WriteLine("*******************************************************");
        Console.WriteLine($"Banco {banco.Nome}");
        Console.WriteLine("*******************************************************");
    }

    public override void Corpo(List<ContaBancaria> contas)
    {
        foreach (var conta in contas)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Titular: {conta.NomeTitular} - Saldo: R$ {conta.Saldo}");
            Console.WriteLine("-------------------------------------------------------");
        }
    }

    public override void Rodape(Banco banco)
    {
        Console.WriteLine("*******************************************************");
        Console.WriteLine($"Telefone: {banco.Telefone}");
        Console.WriteLine("*******************************************************");
    }
}
