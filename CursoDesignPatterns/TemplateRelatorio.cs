using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public abstract class TemplateRelatorio
{
    public void Imprimir(Banco banco, List<ContaBancaria> contas)
    {
        Cabecalho(banco);
        Corpo(contas);
        Rodape(banco);
    }

    public abstract void Cabecalho(Banco banco);
    public abstract void Corpo(List<ContaBancaria> contas);
    public abstract void Rodape(Banco banco);
}
