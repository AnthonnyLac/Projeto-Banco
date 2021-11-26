using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Banco
{
    class Banco
    {
        private string _nome;
        private const int Taxa = 5;
        public int NumeroConta { get; private set; }
        public double Saldo {get; set;}

        public Banco(string nome, int numeroConta) 
        {
            _nome = nome;
            NumeroConta = numeroConta;
        }
        public Banco(string nome, int numeroConta, double saldo ) : this (nome, numeroConta)
        {
            Saldo = saldo;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public void Deposito(double deposito) 
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque;
            Saldo -= Taxa;
        }

        public override string ToString()
        {
            return $"Dados Atualizados!\nConta {NumeroConta}, Titular: {_nome}, Saldo: R${Saldo.ToString("F2")}";
        }
    }
}
