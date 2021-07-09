using System;
using Heranca.src.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.Nome = "Anderson Balieiro";
            g.Salario = 2500;
            g.Usuario = "Anderson.Balieiro";
            g.Senha = "1234";

            Telefonista t = new Telefonista();
            t.Nome = "Maiara";
            t.Salario = 1800;
            t.EstacaoDeTrabalho = 4;

            Secretaria s = new Secretaria();
            s.Nome = "Daiane";
            s.Salario = 1600;
            s.Ramal = 2;


            // Console.WriteLine($"");
            // Console.WriteLine("Gerente");
            // Console.WriteLine($"Nome: {g.Nome}");
            // Console.WriteLine($"Salario: {g.Salario}");
            // Console.WriteLine($"Usuario: {g.Usuario}");
            // Console.WriteLine($"Senha: {g.Senha}");
            // Console.WriteLine($"Bonificação: {g.CalculaBonificacao()}");

            // Console.WriteLine($"");
            // Console.WriteLine("Telefonista");
            // Console.WriteLine($"Nome: {t.Nome}");
            // Console.WriteLine($"Salario: {t.Salario}");
            // Console.WriteLine($"Estação de trabalho: {t.EstacaoDeTrabalho}");
            // Console.WriteLine($"Bonificação: {t.CalculaBonificacao()}");

            // Console.WriteLine($"");
            // Console.WriteLine($"Secretaia");
            // Console.WriteLine($"Nome: {s.Nome}");
            // Console.WriteLine($"Salario: {s.Salario}");
            // Console.WriteLine($"Ramal: {s.Ramal}");
            // Console.WriteLine($"Bonificação: {s.CalculaBonificacao()}");

            Console.WriteLine("Gerente");
            g.DadosFuncionario();
            Console.WriteLine("");

            Console.WriteLine("Telefonista");
            t.DadosFuncionario();
            Console.WriteLine("");

            Console.WriteLine("Secretaria");
            s.DadosFuncionario();
            Console.WriteLine("");
        }
    }
}
