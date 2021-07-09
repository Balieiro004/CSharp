namespace Heranca.src.Entities
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public double Salario {get; set;}

        public virtual double CalculaBonificacao(){
            return this.Salario * 0.1;
        }

        public virtual void DadosFuncionario(){
            System.Console.WriteLine($"Nome: {this.Nome}");
            System.Console.WriteLine($"Salario: R$ {this.Salario}");
            System.Console.WriteLine($"Bonificação: R$ {this.CalculaBonificacao()}");
        }
    }
}