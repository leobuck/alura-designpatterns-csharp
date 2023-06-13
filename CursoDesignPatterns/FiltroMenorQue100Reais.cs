using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class FiltroMenorQue100Reais : Filtro
{
    public FiltroMenorQue100Reais()
    {
    }

    public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro)
    {
    }

    public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
    {
        IList<ContaBancaria> fraudulentas = new List<ContaBancaria>();
        
        foreach (var conta in contas)
        {
            if (conta.Saldo < 100)
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
