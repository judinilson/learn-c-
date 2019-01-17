using System;
using System.Globalization;

namespace contaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor do deposito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, DepositoInicial);
            }else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para Deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para Saque: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);
        }


    }
}
