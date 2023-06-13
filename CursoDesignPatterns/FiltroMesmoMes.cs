using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class FiltroMesmoMes : Filtro
{
    public FiltroMesmoMes()
    {
    }

    public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro)
    {
    }

    public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
    {
        IList<ContaBancaria> fraudulentas = new List<ContaBancaria>();
        
        foreach (var conta in contas)
        {
            if (conta.Abertura.Month == DateTime.Now.Month &&
                conta.Abertura.Year == DateTime.Now.Year)
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
