using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Moderado : Investimento
{
    public double Calcula(ContaBancaria conta)
    {
        if (new Random().Next(2) == 0)
        {
            return conta.Saldo * 0.025;
        }
        else
        {
            return conta.Saldo * 0.007;
        }
    }
}
