using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class ContaBancaria
{
    public double Saldo { get; private set; }

    public ContaBancaria(double saldo)
    {
        Saldo = saldo;
    }

    public void Deposita(double valor)
    {
        if (valor >= 0)
            Saldo += valor;
    }
}
