using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class FormatadorPorCSV : Formatador
{
    public Formatador Proximo { get; set; }

    public string Formata(Requisicao requisicao, ContaBancaria conta)
    {
        if (requisicao.Formato == Formato.CSV)
        {
            return $"{conta.NomeTitular};{conta.Saldo}";
        }

        return Proximo.Formata(requisicao, conta);
    }
}
