using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class Agencia
    {
        public int Id {get; set;}
        public int Numero {get; set;}

        public int BancoId {get; set;}
        public virtual Banco Banco{get; set;}
        
    }
}