using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class Cliente
    {
        public Cliente(){
            ClientesSolicitacoes = new List<ClienteSolicitacao>();
        }

        public int Id {get; set;}
        public string Nome {get; set;}

        public virtual Conta Conta{get; set;}
        public virtual ICollection<ClienteSolicitacao> ClientesSolicitacoes{get; set;}
        
    }
}
