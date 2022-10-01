using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    //A classe Abstrata só pode ser usada como herença ela nunca é instanciada no Program.cs
    public abstract class ContaModeloAbstrato
    {
        protected decimal saldo;//O protected pode ser acessedo das classe filhas diferente do private!
        public abstract void Creditar(decimal valor);// não tem corpo pq é abstrata, 
        //deve ser instanciada na classe que a herdar
        public void ExibirSaldo(){
            Console.WriteLine($"O saldo da sua conta é de: R${saldo}");
        }

    }
}