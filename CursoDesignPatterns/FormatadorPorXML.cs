using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class FormatadorPorXML : Formatador
{
    public Formatador Proximo { get; set; }

    public string Formata(Requisicao requisicao, ContaBancaria conta)
    {
        if (requisicao.Formato == Formato.XML)
        {
            return @$"<ContaBancaria>
    <NomeTitular>{conta.NomeTitular}</NomeTitular>
    <Saldo>{conta.Saldo}</Saldo>
</ContaBancaria>";
        }

        return Proximo.Formata(requisicao, conta);
    }
}
