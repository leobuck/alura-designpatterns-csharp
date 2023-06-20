using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Negativo : EstadoDeUmaContaBancaria
{
    public void Deposito(ContaBancaria conta, double valor)
    {
        conta.Saldo += valor * 0.95;

        if (conta.Saldo >= 0)
        {
            conta.EstadoAtual = new Positivo();
        }
    }

    public void Saque(ContaBancaria conta, double valor)
    {
        throw new Exception("Conta negativa não aceita saque.");
    }
}
