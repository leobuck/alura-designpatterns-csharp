using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Arrojado : Investimento
{
    public double Calcula(ContaBancaria conta)
    {
        int random = new Random().Next(10);
        if (random >= 0 && random <= 1)
        {
            return conta.Saldo * 0.5;
        }
        else if (random >= 2 && random <= 4)
        {
            return conta.Saldo * 0.3;
        }
        else
        {
            return conta.Saldo * 0.006;
        }
    }
}
