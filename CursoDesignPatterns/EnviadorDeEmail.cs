using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class EnviadorDeEmail : AcaoAposGerarNota
{
    public void Executar(NotaFiscal nf)
    {
        Console.WriteLine("Enviando e-mail...");
    }
}
