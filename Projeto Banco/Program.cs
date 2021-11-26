using System;

namespace Projeto_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito = 0;
            Console.WriteLine("Entre o numero da Conta:");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do Titular da Conta:");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial?\n[s] Sim\n[*] Qualquer tecla para Não");
            string escolha = Console.ReadLine();
            
            if (escolha == "s")
            {
                Console.WriteLine("Entre valor para saldo inicial:");
                deposito = Convert.ToDouble(Console.ReadLine());
            }
            var user1 = new Banco(nome, numeroConta, deposito);
            Console.Clear();
            Console.WriteLine(user1);
            
            Console.WriteLine("Entre um valor para deposito:");
            user1.Deposito(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(user1);

            Console.WriteLine("Insira um valor para saque:");
            user1.Saque(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(user1);
        }
    }
}
