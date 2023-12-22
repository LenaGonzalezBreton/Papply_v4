using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papply.Models
{
    public class Promotion
    {
        public string IdPromotion { get; set; }
        public string NomPromotion { get; set; }
        public List<Student> Students { get; set; }
        
        public Tp TravauxPratiques { get; set; }

        public Promotion(string idPromotion, string nomPromotion, List<Student> students, Tp travauxPratiques)
        {
            this.IdPromotion = idPromotion;
            this.NomPromotion = nomPromotion;
            this.Students = students;
            this.TravauxPratiques = travauxPratiques;
        }

        public static Models.Promotion Create()
        {
            var guid = Guid.NewGuid();
            return new Promotion(guid.ToString(), "PROMOTION1", new List<Student>(),new Tp(guid.ToString(), "TPtest", "bla"));
        }
    }
}
