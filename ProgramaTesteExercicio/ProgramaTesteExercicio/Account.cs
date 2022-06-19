using System;

namespace ProgramaTesteExercicio
{
    internal class Account
    {
        public int  Numero { get ; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Account(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;            
        }

        public Account(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;  
        }
        public override string ToString()
        {
            return ($"Conta {Numero}, titular: {Nome}, Saldo: ${Saldo:F2}");
        }
    }
}
