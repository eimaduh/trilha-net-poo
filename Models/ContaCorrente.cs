using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor){
            if(saldo >= valor){
                saldo -= valor;
                Console.WriteLine("Saldo realizado com sucesso!");
            }else{
                Console.WriteLine("O valor do saque é maior que seu saldo disponível!");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"O seu saldo disponível é de: {saldo}");
        }


    }
}