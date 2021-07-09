namespace Heranca.src.Entities
{
    public class Gerente : Funcionario
    {
        public string Usuario {get; set;}
        public string Senha {get; set;}

        public override double CalculaBonificacao()
        {
            return this.Salario * 0.6 + 100;
        }

        public override void DadosFuncionario(){
            base.DadosFuncionario();
            System.Console.WriteLine($"Usuario: {this.Usuario}");
            System.Console.WriteLine($"Senha: {this.Senha}");
        }
    }
}