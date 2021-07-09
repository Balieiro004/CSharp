using System;
using ex7Encapsulamento.src.Entities;

namespace ex7Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.Nome = "Anderson";
            f1.Salario = 3000;
            Console.WriteLine(f1.Nome);
            Console.WriteLine(f1.Salario);

        }
    }
}
