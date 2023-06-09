﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class FormatadorPorPorcento : Formatador
{
    public Formatador Proximo { get; private set; }

    public FormatadorPorPorcento(Formatador proximo)
    {
        Proximo = proximo;
    }

    public string Formata(Requisicao requisicao, ContaBancaria conta)
    {
        if (requisicao.Formato == Formato.PORCENTO)
        {
            return $"{conta.NomeTitular}%{conta.Saldo}";
        }
        else if (Proximo != null)
        {
            return Proximo.Formata(requisicao, conta);
        }
        else
        {
            throw new Exception("Formato de resposta não encontrado.");
        }
    }
}
