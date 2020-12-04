//Uma empresa possui funcionários próprios e terceirizados.
//Para cada funcionário, deseja-se registrar nome, horas
//trabalhadas e valor por hora. Funcionários terceirizados
//possuem ainda uma despesa adicional.
//O pagamento dos funcionários corresponde ao valor da hora
//multiplicado pelas horas trabalhadas, sendo que os
//funcionários terceirizados ainda recebem um bônus
//correspondente a 110% de sua despesa adicional.
//Fazer um programa para ler os dados de N funcionários (N
//fornecido pelo usuário) e armazená-los em uma lista. Depois
//de ler todos os dados, mostrar nome e pagamento de cada
//funcionário na mesma ordem em que foram digitados.
//Construa o programa conforme projeto:

//Enter the number of employees: 3
//Employee #1 data:
//Outsourced(y/n)? n
//Name: Alex
//Hours: 50
//Value per hour: 20.00
//Employee #2 data:
//Outsourced(y/n)? y
//Name: Bob
//Hours: 100
//Value per hour: 15.00
//Additional charge: 200.00
//Employee #3 data:
//Outsourced(y/n)? n
//Name: Maria
//Hours: 60
//Value per hour: 20.00
//PAYMENTS:
//Alex - $ 1000.00
//Bob - $ 1720.00
//Maria - $ 1200.00





using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Resolvido.Entities;

namespace Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
