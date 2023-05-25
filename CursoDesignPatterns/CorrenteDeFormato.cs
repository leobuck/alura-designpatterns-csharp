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
        Formatador f1;
        Formatador f2;
        Formatador f3;

        f3 = new FormatadorPorPorcento(null);
        f2 = new FormatadorPorCSV(f3);
        f1 = new FormatadorPorXML(f2);

        return f1.Formata(requisicao, conta);
    }
}
