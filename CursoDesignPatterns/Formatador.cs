using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public interface Formatador
{
    string Formata(Requisicao requisicao, ContaBancaria conta);
}
