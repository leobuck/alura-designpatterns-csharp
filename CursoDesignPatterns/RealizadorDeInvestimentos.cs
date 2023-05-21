using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class RealizadorDeInvestimentos
{
    public void RealizaCalculo(ContaBancaria conta, Investimento investimento)
    {
        double valor = investimento.Calcula(conta);
        Console.WriteLine($"Valor do investimento: {valor}");
        conta.Deposita(valor * 0.75);
        Console.WriteLine($"Saldo final: {conta.Saldo}");
    }
}
