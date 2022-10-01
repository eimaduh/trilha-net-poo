using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            /*assim instanciamos a propriedade nome nas filhas que herdam da classe pessoa pois agora
            ela é obrigatória*/
        }
        public decimal Salario { get; set; }

        /* OVERRIDE - usado para sobreescrever o método 
           SEALED - a calsse pode ser herdada mas o método Apresentar não pode ser sobrescrito*/
        public sealed override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, meu salário é {Salario}!");
        }
    }
}