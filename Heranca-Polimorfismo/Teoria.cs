//Herança
//• É um tipo de associação que permite que uma classe herde dados e
//comportamentos de outra
//• Definições importantes
//• Vantagens
//• Reuso
//• Polimorfismo
//• Sintaxe
//• : (estende)
//• base(referência para a superclasse)



//Exemplo
//Suponha um negócio de banco que possui uma conta comum e uma conta para
//empresas, sendo que a conta para empresa possui todos membros da conta
//comum, mais um limite de empréstimo e uma operação de realizar empréstimo.

//_______________________________________________________________________________________________________________________________________________
//Upcasting / Downcasting

// Upcasting
//• Casting da subclasse para superclasse
//• Uso comum: polimorfismo
//• Downcasting
//• Casting da superclasse para subclasse
//• Palavra as
//• Palavra is
//• Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)

//_______________________________________________________________________________________________________________________________________________
//Sobreposição ou sobrescrita


//• É a implementação de um método de uma superclasse na subclasse
//• Para que um método comum (não
//abstrato) possa ser sobreposto, deve
//ser incluído nele o prefixo "virtual"
//• Ao sobrescrever um método, devemos
//incluir nele o prefixo "override

//_______________________________________________________________________________________________________________________________________________
//É possível chamar a implementação da superclasse usando a palavra base.
//public override void Withdraw(double amount)
//{
//    base.Withdraw(amount);
//    Balance -= 2.0;
//}
//Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque
//normalmente da superclasse (Account), e depois descontar mais 2.0.


//_______________________________________________________________________________________________________________________________________________
//Classes e métodos selados

//• Palavra chave: sealed
//• Classe: evita que a classe seja herdada • Nota: ainda é possível extender a funcionalidade de uma classe selada usando "extension methods"
//namespace Course
//{
//    sealed class SavingsAccount
//    {
//• Método: evita que um método sobreposto possa ser sobreposto novamente • Só pode ser aplicado a métodos sobrepostos

//Pra quê?
//• Segurança: dependendo das regras do negócio, às vezes é desejável
//garantir que uma classe não seja herdada, ou que um método não
//seja sobreposto.
//• Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
//podem ser uma porta de entrada para inconsistências
//• Performance: atributos de tipo de uma classe selada são analisados
//de forma mais rápida em tempo de execução.
//• Exemplo clássico: string

//_______________________________________________________________________________________________________________________________________________
//Introdução ao polimorfismo

//Em Programação Orientada a Objetos, polimorfismo é recurso que permite
//que variáveis de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos diferentes, tendo assim comportamentos diferentes
//conforme cada tipo específico.

//Importante entender
//• A associação do tipo específico com o tipo genérico é feita em tempo de
//execução (upcasting).
//• O compilador não sabe para qual tipo específico a chamada do método
//Withdraw está sendo feita (ele só sabe que são duas variáveis tipo Account):

//_______________________________________________________________________________________________________________________________________________
//Classes e métodos selados
//• Palavra chave: sealed
//• Classe: evita que a classe seja herdada • Nota: ainda é possível extender a funcionalidade de uma classe selada usando "extension methods"
//namespace Course
//{
//    sealed class SavingsAccount
//    {
//• Método: evita que um método sobreposto possa ser sobreposto novamente • Só pode ser aplicado a métodos sobrepostos

//_______________________________________________________________________________________________________________________________________________
//Classes abstratas
//• São classes que não podem ser instanciadas
//• É uma forma de garantir herança total: somente subclasses não
//abstratas podem ser instanciadas, mas nunca a superclasse abstrata

//_______________________________________________________________________________________________________________________________________________
//Métodos abstratos
//• São métodos que não possuem implementação.
//• Métodos precisam ser abstratos quando a classe
//é genérica demais para conter sua
//implementação.
//• Se uma classe possuir pelo menos um método
//abstrato, então esta classe também é abstrata.
//• Notação UML: itálico
//• Exercício resolvido





using Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Heranca_Polimorfismo
{
    class Teoria
    {
        static void Main(string[] args)
        {


            //HERANÇA

            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);  //criando uma BusinessAccount

            //Console.WriteLine(account.Balance);

            //account.Balance = 200.0; //error

            //__________________________________________________________________________________________________________________________

            //DOWN/UP CASTING

            //Account acc = new Account(1001, "Alex", 0.0);   //criando uma Account
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0); // criando uma BusinessAccount

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); //criando uma nova conta Business partindo de uma conta
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);  //criando uma nova conta Poupança partindo de uma conta 

            //// DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2; //Precisa fazer um casting (BusinessAccount) para fazer o downcasting antes da variavel
            //acc4.Loan(100.0);

            //// BusinessAccount acc5 = (BusinessAccount)acc3;              //invalidCastException para converter
            //if (acc3 is BusinessAccount)                                 //se acc3 is(FOR) uma BusinessAccount (o que não é)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;          //Sintaxe normal
            //    BusinessAccount acc5 = acc3 as BusinessAccount;          //Sintaxe alternativa de ^
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;             //Sintaxe normal
            //    SavingsAccount acc5 = acc3 as SavingsAccount;            //Sintaxe alternativa de ^
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}


            //__________________________________________________________________________________________________________________________

            //SOBREPOSIÇÃO, PALAVRAS: VIRTUAL, OVERRIDE E BASE


            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.1);


            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance); // com taxa
            //Console.WriteLine(acc2.Balance); // sem taxa

            //__________________________________________________________________________________________________________________________

            //BASE

            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.1);


            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance); // com taxa normal
            //Console.WriteLine(acc2.Balance); // sem taxa normal mais 2 reais (usando base.)

            //___________________________________________________________________________________________________________________________

            //Classes abstratas ->aplicando o region só para ver como funciona
            //#region 
            //List<Account> list = new List<Account>();

            //list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            //list.Add(new BusinessAccount(1001, "Maria", 500.0, 400.0));
            //list.Add(new SavingsAccount(1001, "Bob", 500.0, 0.01));
            //list.Add(new BusinessAccount(1001, "Anna", 500.0, 500.0));

            //#endregion

            //double sum = 0.0;


            //foreach (Account acc in list)
            //{
            //    sum += acc.Balance;
            //}

            //Console.WriteLine("Total balance: " + sum.ToString("F2"));

            //foreach (Account acc in list)
            //{
            //    acc.Withdraw(10.0);
            //}



            //foreach (Account acc in list)
            //{
            //    Console.WriteLine("Updated balance for account "
            //        + acc.Number
            //        + ": "
            //        + acc.Balance.ToString("F2")
            //        );
            //}


            //___________________________________________________________________________________________________________________________
            //MÉTODOS ABSTRATOS










        }
    }
}