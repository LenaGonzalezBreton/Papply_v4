using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapplyAppli.Classes
{
    public class Degree
    {
        // attributs
        public int IDDegree { get; set; } 
        public string TitreDegree { get; set; }

        public List<Task> Tasks { get; set; }

        public double Total;

        public Degree(int idDegree, string libDegree )
        {
            IDDegree = idDegree;
            TitreDegree = libDegree;
            Tasks = new List<Task>();
        }

        public Degree()
        {
            IDDegree += 1;
            TitreDegree += 1;
            Tasks = new List<Task>();
        }




    }
}
