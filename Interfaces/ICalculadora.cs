using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    /*INTERFACE - é um contrato e tudo que for pedido aqui deverá ser instanciado nas classes!*/
namespace poo.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2){
            return num1 / num2;
        }// métodos com corpo tem sua implementação opcional na classe que instanciá-lo

    }
}