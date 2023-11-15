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
        private int _idDegree { get; set; } 
        private string _libDegree { get; set; }
        public List<GroupTask> _gtaskList { get; set; } = new List<GroupTask>();
        


        // constructeur
        public Degree(int idDegree, string libDegree )
        {
            _idDegree = idDegree;
            _libDegree = libDegree;
            _gtaskList.Add(new GroupTask());
        }

        // accesseurs

        // methodes



    }
}
