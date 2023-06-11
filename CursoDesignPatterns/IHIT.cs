using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class IHIT : TemplateDeImpostoCondicional
{
    public IHIT()
    {
    }

    public IHIT(Imposto outroImposto) : base(outroImposto)
    {
    }

    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Itens.GroupBy(i => i.Nome).Any(i => i.Count() >= 2);
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return (orcamento.Valor * 0.13) + 100;
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * (0.01 * orcamento.Itens.Count);
    }
}
