using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class ContaPoupanca : Conta
    {
        private decimal taxaJuros;
        private DateTime dataAniversario;
        private double v;
        private DateTime data;
        private string cliente;

        public ContaPoupanca(decimal j, DateTime d, string t):base(t)
        {
            taxaJuros = j;
            dataAniversario = d;
        }

        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public DateTime DataAniversario
        {
            get { return dataAniversario; }
        }

        public void AdicionarRendimento()
        {
            if(DateTime.Now.Equals(dataAniversario))
            {
                decimal rendimento;
                rendimento = Saldo * taxaJuros;
                Depositar(rendimento);
            }
        }
    }
}
