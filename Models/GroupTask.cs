using Papply.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PapplyAppli.Classes
{
    public class GroupTask
    {
        List<Papply.Models.Task> _listtask = new List<Papply.Models.Task>();
        public int _id { get; set; }
        public bool _isvalid { get; set; }
        public double _total { get; set; }
        public string _title { get; set; }
        public string _desc { get; set; }


        public List<Papply.Models.Task> GetTasks()
        {
            return _listtask;
        }
        public void SetTasks(List<Papply.Models.Task> list)
        {
            this._listtask = list;
        }

        public double CalculTotal()
        {
            double res = 0;
            foreach(Papply.Models.Task task in _listtask)
            {
                res += task._pointtask;
            }
            return res;
        }

        public GroupTask(int id, bool isvalid, List<Papply.Models.Task> listtask, string desc,string title)
        {
            _id = id;
            this._isvalid = isvalid;
            _listtask = listtask;
            _total = CalculTotal();
            _desc = desc;
            _title = title;

           
        }

        public GroupTask(int id, bool isvalid, List<Papply.Models.Task> listtask)
        {
            _id = id;
            this._isvalid = isvalid;
            _listtask = listtask;
            _total = CalculTotal();

        }

    }
}
