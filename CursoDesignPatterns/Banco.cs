using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns;

public class Banco
{
    public string Nome { get; private set; }
    public string Telefone { get; private set; }
    public string Email { get; private set; }
    public string Endereco { get; private set; }

    public Banco(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public Banco(
        string nome,
        string telefone,
        string email,
        string endereco)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
        Endereco = endereco;
    }
}
