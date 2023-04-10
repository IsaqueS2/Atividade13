namespace Atividade13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente conta1 = new ContaCorrente();
            conta1.saldo = 1500;
            conta1.numero = 13;
            conta1.limite = 0;
            conta1.especial = true;
            conta1.movimentacoes = new Movimentacao[10];

            conta1.Sacar(250);

            conta1.Depositar(350);

            conta1.Depositar(250);

            conta1.Sacar(250);


            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 500;
            conta2.numero = 14;
            conta2.limite = 0;
            conta2.especial = true;
            conta2.movimentacoes = new Movimentacao[10];

            conta1.Transferir(conta2, 450);

            conta1.ExibirExtrato();


            Console.ReadKey();
         
        }
    }
}