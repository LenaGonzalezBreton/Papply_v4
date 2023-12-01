using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papply.Models
{
    public class Promotion
    {
        public string IdPromotion;
        public string NomPromotion;
    
        public Promotion(string IdPromotion, string NomPromotion) 
        {
            this.IdPromotion = IdPromotion;
            this.NomPromotion = NomPromotion;
        }
    }
}
