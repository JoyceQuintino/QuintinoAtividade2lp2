using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class ClienteSolicitacao
    {
        public int ClienteId {get; set;}
        public int SolicitacaoId {get; set;}

        public virtual Cliente Cliente {get; set;}
        public virtual Solicitacao Solicitacao {get; set;}
    }
}