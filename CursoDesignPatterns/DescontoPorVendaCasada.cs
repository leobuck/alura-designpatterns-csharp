using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class DescontoPorVendaCasada : Desconto
{
    public Desconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        if (Existe("Lapis", orcamento) && Existe("Caneta", orcamento))
        {
            return orcamento.Valor * 0.05;
        }

        return Proximo.Desconta(orcamento);
    }

    private bool Existe(string nomeDoItem, Orcamento orcamento)
    {
        foreach (Item item in orcamento.Itens)
        {
            if (item.Nome.Equals(nomeDoItem))
                return true;
        }

        return false;
    }
}
