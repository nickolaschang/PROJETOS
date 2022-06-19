using System;
using System.Collections.Generic;
using System.Text;

namespace PogramaBanco
{
    internal class Account
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Account()
        {

        }
        public Account(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public Account(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }
        public override string ToString()
        {
            return ($"Conta: {Numero}, Titular: {Titular}, saldo: ${Saldo:F2}");
        }



    }
}
