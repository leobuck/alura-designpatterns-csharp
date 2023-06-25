using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class NotaFiscalBuilder
{
    public string RazaoSocial { get; private set; }
    public string Cnpj { get; private set; }
    public string Observacoes { get; private set; }
    public DateTime Data { get; private set; }
    private double ValorTotal;
    private double Impostos;
    private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

    public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
    {
        RazaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilder ComCnpj(string cnpj)
    {
        Cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder ComObservacoes(string observacoes)
    {
        Observacoes = observacoes;
        return this;
    }

    public NotaFiscalBuilder NaDataAtual()
    {
        Data = DateTime.Now;
        return this;
    }

    public NotaFiscalBuilder ComItem(ItemDaNota item)
    {
        TodosItens.Add(item);
        ValorTotal += item.Valor;
        Impostos += item.Valor * 0.05;
        return this;
    }

    public NotaFiscal Constroi()
    {
        return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);
    }
}
