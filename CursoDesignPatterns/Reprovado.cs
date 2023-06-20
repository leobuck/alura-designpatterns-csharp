using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Reprovado : EstadoDeUmOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos reprovados não recebem desconto extra.");
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new Exception("Orçamento já está em estado de reprovação.");
    }

    public void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new Exception("Orçamento reprovado não pode ser aprovado.");
    }
}
