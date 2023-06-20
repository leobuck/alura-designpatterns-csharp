using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Positivo : EstadoDeUmaContaBancaria
{
    public void Deposito(ContaBancaria conta, double valor)
    {
        conta.Saldo += valor * 0.98;
    }

    public void Saque(ContaBancaria conta, double valor)
    {
        conta.Saldo -= valor;

        if (conta.Saldo < 0)
        {
            conta.EstadoAtual = new Negativo();
        }
    }
}
