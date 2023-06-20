using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class EmAprovacao : EstadoDeUmOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.05;
    }

    public void Aprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("Orçamento em aprovação não pode ir para finalizado direto.");
    }

    public void Reprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Reprovado();
    }
}
