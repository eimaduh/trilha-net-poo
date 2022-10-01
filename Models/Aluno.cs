using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    //SEALED essa classe não pode ser herdada 
    public sealed class Aluno : Pessoa //HERANÇA - a classe aluno herdou as propiedades da classe pessoa.
    {
        public Aluno(string nome) : base(nome)
        {
            /*assim instanciamos a propriedade nome nas filhas que herdam da classe pessoa pois agora
            ela é obrigatória*/
        }
       public double Nota { get; set; } 

        /* OVERRIDE usado para sobreescrever o método */
       public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, minha nota é {Nota}!");
        }
    }
}