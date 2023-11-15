using Papply.Models;
using Papply.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace PapplyAppli.Classes
{
    public class GroupTask : ViewModelBase
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        public List<Papply.Models.Task> _listtask = new List<Papply.Models.Task>();
        public int _id;
        public bool _isvalid;

        public double PointTask {

            get { return _total; }
            set
            {
                _total = value;
            }
        }
        private double _total;

        public string Title;
        private string _title;

        public string Description;
        private string _desc;
        public CardControl _partcard {  get; set; } = new CardControl(1);






        public List<Papply.Models.Task> GetTasks()
        {
            return _listtask;
        }
        public void SetTasks(List<Papply.Models.Task> list)
        {
            this._listtask = list;
        }

        public void addTask(Papply.Models.Task task)
        {
            _listtask.Add(task);
        }

        public void removeTaskbyID(int pos)
        {
            _listtask.RemoveAt(pos);
        }

        public double CalculTotal()
        {
            double res = 0;
            foreach(Papply.Models.Task task in _listtask)
            {
                res += task.PointTask;
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

        public GroupTask()
        {
            _id =0;
            _isvalid = false;
            _total = this.CalculTotal();
            _title = "Titre";
            _desc = "Description";
            _listtask.Add(new Papply.Models.Task());
        }

    }
}
