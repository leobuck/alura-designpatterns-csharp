using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class FiltroMaiorQue500MilReais : Filtro
{
    public FiltroMaiorQue500MilReais()
    {
    }

    public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro)
    {
    }

    public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
    {
        IList<ContaBancaria> fraudulentas = new List<ContaBancaria>();
        
        foreach (var conta in contas)
        {
            if (conta.Saldo > 500000)
            {
                fraudulentas.Add(conta);
            }
        }

        foreach (var conta in Proximo(contas))
        {
            fraudulentas.Add(conta);
        }

        return fraudulentas;
    }
}
