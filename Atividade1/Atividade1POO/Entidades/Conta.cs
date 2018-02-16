using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1POO.Entidades
{
    public abstract class Conta
    {
        public abstract string Id { get; }
        private decimal saldo;
        private string titular;

        public Conta(string t)
        {
            titular = t;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public string Titular
        {
            get { return titular; }
        }

        //métodos para possibilitar o depósito e a retirda de valores
        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= saldo)
                saldo -= valor;
        }
    }
}
