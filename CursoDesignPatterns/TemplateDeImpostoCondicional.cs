﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public abstract class TemplateDeImpostoCondicional : Imposto
{
    protected TemplateDeImpostoCondicional()
    {
    }

    protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
    {
    }

    public override double Calcula(Orcamento orcamento)
    {
        if (DeveUsarMaximaTaxacao(orcamento))
        {
            return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
    }

    public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
    public abstract double MinimaTaxacao(Orcamento orcamento);
}
