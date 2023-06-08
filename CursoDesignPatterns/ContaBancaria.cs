using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class ContaBancaria
{
    public string NomeTitular { get; private set; }
    public string Agencia { get; private set; }
    public string NumeroConta { get; private set; }
    public double Saldo { get; private set; }

    public ContaBancaria(string nome, double saldo)
    {
        NomeTitular = nome;
        Saldo = saldo;
    }

    public ContaBancaria(
        string nomeTitular,
        string agencia,
        string numeroConta,
        double saldo)
    {
        NomeTitular = nomeTitular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public void Deposita(double valor)
    {
        if (valor >= 0)
            Saldo += valor;
    }
}
