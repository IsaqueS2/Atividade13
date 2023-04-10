using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade13
{
    internal class ContaCorrente
    {
        public int numero, quantMovimentacoes;
        public double saldo, limite, limiteSaque;
        public bool especial;
        public Movimentacao[] movimentacoes;


        internal void Sacar(int ValorSaque)
        {
         limiteSaque = saldo + limite;

            if(ValorSaque <= limiteSaque)
            {
                saldo = saldo - ValorSaque;
                movimentacoes[quantMovimentacoes] = new Movimentacao(ValorSaque, "Débito");
                quantMovimentacoes++;
            }
            else
            { 
                    Console.WriteLine("\nImpossível realizar saque!");
            }
        }


        internal void Depositar(int ValorDeposito)
        {
            saldo = saldo + ValorDeposito;
            movimentacoes[quantMovimentacoes] = new Movimentacao(ValorDeposito, "Saque");
            quantMovimentacoes++;
        }


        internal void ExibirExtrato()
        {
            for (int i = 0; i < quantMovimentacoes; i++)
            {
                if (movimentacoes[i].tipo != null && movimentacoes[i].valor != null)
                    Console.WriteLine("Operação:"+ movimentacoes[i].tipo +"\nValor:" + movimentacoes[i].valor + "\n");
                else
                {
                    Console.WriteLine("");
                }
            }
        }


        internal void Transferir(ContaCorrente conta, int ValorTransferencia)

        {
            if (ValorTransferencia <= limiteSaque)
            {
                saldo = saldo - ValorTransferencia;
                conta.saldo = conta.saldo + ValorTransferencia;
                movimentacoes[quantMovimentacoes] = new Movimentacao(ValorTransferencia, "Transferencia");
                quantMovimentacoes++;

            }
            else
            {
                Console.WriteLine("\nNão á como realizar transferência!");
            }

        }

    }



}


