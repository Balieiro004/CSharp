using System;
namespace Series2.src.Entities
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Nome {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string nome, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            return "\nGenero: " + this.Genero + "\n Nome: " + this.Nome + "\n Descroão: " + this.Descricao + "\n Ano: " + this.Ano + "\n Excluido: " + this.Excluido;
            // string retorno = "";
            // retorno += "Gênero: " + this.Genero + Environment.NewLine;
            // retorno += "Nome: " + this.Nome + Environment.NewLine;
            // retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            // retorno +=  "Ano: " + this.Ano + Environment.NewLine;
            // retorno += "Excluido: " + this.Excluido;
            // return retorno;
        }
        public string retornaTitulo(){
            return this.Nome;
        }
        public int retornaId(){
            return this.Id;
        }
        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}