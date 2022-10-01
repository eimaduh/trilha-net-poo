using poo.Models;
using poo.Interfaces;

        Pessoa p1 = new Pessoa();
        p1.Nome = "Maria Eduarda";
        p1.Idade = 19;
        p1.Apresentar();

        ContaCorrente c1 = new ContaCorrente(123, 1000);
        c1.ExibirSaldo();
        c1.Sacar(500);
        c1.ExibirSaldo();

        // ALUNO E PROFESSOR ESTÃO HERDANDO NOME, IDADE E APRESENTAR DA CLASSE PESSOA
        Aluno a1 = new Aluno("Maria");
        //a1.Nome = "Maria";
        a1.Idade = 19;
        a1.Nota = 10;
        a1.Apresentar();

        Professor prof1 = new Professor("Valeria");
        //prof1.Nome = "Valeria";
        prof1.Idade = 25;
        prof1.Salario = 3000;
        prof1.Apresentar();

        ContaCorrenteAbs conta = new ContaCorrenteAbs();
        conta.Creditar(2000);
        conta.ExibirSaldo();


        //CLASSE OBJECT todas as classes herdam da classe object
        Computador comp = new Computador();
        Console.WriteLine(comp.ToString());


        //INTERFASES
        /*interfase*/              /*classe que implementa a interfase*/
        ICalculadora calculadora = new CalculadoraComum();
        Console.WriteLine(calculadora.Somar(5, 6));
        Console.WriteLine(calculadora.Subtrair(20, 6));
        Console.WriteLine(calculadora.Multiplicar(2, 6));
        Console.WriteLine(calculadora.Dividir(18, 6));
