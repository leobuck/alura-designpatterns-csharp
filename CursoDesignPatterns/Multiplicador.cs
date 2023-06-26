using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Multiplicador : AcaoAposGerarNota
{
    public double Fator { get; private set; }

    public Multiplicador(double fator)
    {
        Fator = fator;
    }

    public void Executar(NotaFiscal nf)
    {
        double valor = nf.ValorBruto * Fator;
        Console.WriteLine(valor);
    }
}
