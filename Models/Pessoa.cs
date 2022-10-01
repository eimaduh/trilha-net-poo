using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            /*O construtor vazio é uma forma de torna um atributo flexivel mesmo sendo obrigatório
            vc pode escolher passa-lo ou não, mas deve ser passado nas classe filhas!*/
        }
        public Pessoa(string nome)
        {
            Nome = nome; //Nome se torna uma informção obrigatória, devemos instancialas em sua filhas 
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        /* A palavra reservada VIRTUAL permite que o método Apresentar seja sobrescrito nas classes
        que o herdarem (classes filhas) se assim elas desejarem */
        public virtual void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos!");
        }
    }
}