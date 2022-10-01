using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class ContaCorrenteAbs : ContaModeloAbstrato
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}