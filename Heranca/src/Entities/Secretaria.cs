namespace Heranca.src.Entities
{
    public class Secretaria: Funcionario
    {
        public int Ramal {get; set;}

        public override void DadosFuncionario(){
            base.DadosFuncionario();
            System.Console.WriteLine($"Ramal: {this.Ramal}");
        }
    }
}