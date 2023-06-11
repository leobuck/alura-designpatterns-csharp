using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class IMA : Imposto
{
    public IMA()
    {
    }

    public IMA(Imposto outroImposto) : base(outroImposto)
    {
    }

    public override double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
    }
}
