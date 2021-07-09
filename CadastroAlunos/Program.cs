﻿using System;
using CadastroAlunos.src.Entities;

namespace CadastroAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = menuOpcao();

             while(opcaoUsuario.ToUpper() != "X"){

                 switch(opcaoUsuario){
                 
                     case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                 
                    case "2":
                        foreach(var a in alunos){
                            if (!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;
                    
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for(int i=0; i< alunos.Length; i++){
                            
                            if (!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral < 2){
                            conceitoGeral = Conceito.E;    
                        }else if(mediaGeral < 4){
                            conceitoGeral = Conceito.D;
                        }else if(mediaGeral < 6){
                            conceitoGeral = Conceito.C;
                        }else if(mediaGeral < 8){
                            conceitoGeral = Conceito.B;
                        }else{
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                 }
                 opcaoUsuario = menuOpcao();
             }

        }

        private static string menuOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a Opção desejada");
            Console.WriteLine("1 - Cadastrar Novo Aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular Média Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}