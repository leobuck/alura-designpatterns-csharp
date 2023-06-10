using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class ISS : Imposto
{
    public ISS() { }

    public ISS(Imposto outroImposto) : base(outroImposto)
    {
    }

    public override double Calcula(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
    }
}
