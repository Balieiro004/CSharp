using System;
using ex6.src.Entities;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Funcionarios.ValeRefeicaoDiario);
            Funcionarios.ValeRefeicaoDiario = 15;
            Console.WriteLine(Funcionarios.ValeRefeicaoDiario);

            Funcionarios.ReajusteValeRefeicao(0.1);
            Console.WriteLine(Funcionarios.ValeRefeicaoDiario);
        }
    }
}
