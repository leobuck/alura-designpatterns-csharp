using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class CorrenteDeFormato
{
    public string Formata(Requisicao requisicao, ContaBancaria conta)
    {
        Formatador f1 = new FormatadorPorXML();
        Formatador f2 = new FormatadorPorCSV();
        Formatador f3 = new FormatadorPorPorcento();

        f1.Proximo = f2;
        f2.Proximo = f3;

        return f1.Formata(requisicao, conta);
    }
}
