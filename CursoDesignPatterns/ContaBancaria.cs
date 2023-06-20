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
    public double Saldo { get; set; }
    public DateTime Abertura { get; private set; }
    public EstadoDeUmaContaBancaria EstadoAtual { get; set; }

    public ContaBancaria(string nome, double saldo)
    {
        NomeTitular = nome;
        Saldo = saldo;
        EstadoAtual = new Positivo();
    }

    public ContaBancaria(
        string nomeTitular,
        string agencia,
        string numeroConta,
        double saldo,
        DateTime abertura)
    {
        NomeTitular = nomeTitular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Abertura = abertura;
        EstadoAtual = new Positivo();
    }

    public void Deposita(double valor)
    {
        if (valor >= 0)
            Saldo += valor;
    }

    public void Saque(double valor)
    {
        EstadoAtual.Saque(this, valor);
    }

    public void Deposito(double valor)
    {
        EstadoAtual.Deposito(this, valor);
    }
}
