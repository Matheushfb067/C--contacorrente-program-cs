// See https://aka.ms/new-console-template for more information
using System;


namespace meuPrimeiroProjeto
{
    class Program
    {
     static void Main(string[] args)
        {
         // 3° Modo de fazer:
            ContaCorrente conta_matheus = new ContaCorrente ("Matheus", 12345, 789, 10); // Variável do tipo conta corrente
            ContaCorrente conta_henrique = new ContaCorrente ("Henrique", 12345, 790, 200); // Variável do tipo conta corrente
            ContaCorrente conta_anamariobros = new ContaCorrente ("Ana Livia Mario Bros", 12345, 800, -1000); // Variável do tipo conta corrente

            conta_matheus.Titular = "Matheus";
            conta_matheus.Agencia = 12345;
            conta_matheus.Numero = 789;
            conta_matheus.Saldo = 10; 

            Console.WriteLine("A conta do (a)" + conta_matheus.Titular + "A agencia é " + conta_matheus.Agencia + 
            "O numero da conta é " + conta_matheus.Numero + "O saldo é de " + conta_matheus.Saldo + ".");

            Console.WriteLine("A conta do (a)" + conta_henrique.Titular + "A agencia é " + conta_henrique.Agencia + 
            "O numero da conta é " + conta_henrique.Numero + "O saldo é de " + conta_henrique.Saldo + ".");

            Console.WriteLine("A conta do (a)" + conta_anamariobros.Titular + "A agencia é " + conta_anamariobros.Agencia + 
            "O numero da conta é " + conta_anamariobros.Numero + "O saldo é de " + conta_anamariobros.Saldo + ".");
        }
    }
}