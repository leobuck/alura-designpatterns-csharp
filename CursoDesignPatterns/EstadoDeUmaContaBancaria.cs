using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public interface EstadoDeUmaContaBancaria
{
    void Saque(ContaBancaria conta, double valor);
    void Deposito(ContaBancaria conta, double valor);
}
