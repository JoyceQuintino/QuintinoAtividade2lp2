using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class Conta
    {
        public int Id {get; set;}
        public int ClienteId {get; set;}
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
