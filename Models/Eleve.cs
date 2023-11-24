using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papply.Models
{
    internal class Eleve
    {
        public int IdEleve { get; set; }
        public string NomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public string MailEleve { get; set; }
        public string PasswordEleve { get; set; }


        public Eleve(int idEleve, string nomEleve, string prenomEleve, string mailEleve, string passwordEleve) 
        { 
            this.IdEleve = idEleve;
            this.NomEleve = nomEleve;
            this.PrenomEleve = prenomEleve;
            this.MailEleve = mailEleve;
            this.PasswordEleve = passwordEleve;
        }


    }
}
