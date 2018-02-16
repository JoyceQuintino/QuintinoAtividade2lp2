using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2EFCoreClassLib.Entidades
{
    public class Solicitacao
    {
        public Solicitacao(){
            ClientesSolicitacoes = new List<ClienteSolicitacao>();
        }

        public int Id {get; set;}
        public string Text {get; set;}

        public int AgenciaId {get; set;}
        public virtual Agencia Agencia {get; set;}

        public virtual ICollection<ClienteSolicitacao> ClientesSolicitacoes{get; set;}
    }
}