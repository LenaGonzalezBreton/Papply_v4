using Papply.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task
    {
        public string IdTask { get; set; }
        public double PointTask { get;set;}
        public string TitleTask { get; set; }
        public string DescriptionTask { get; set; }
        public string IdTp {  get; set; }

        public Task(string id,double point, string title, string description,string idTp)
        {
            this.IdTask = id;
            this.PointTask = point;
            this.TitleTask = title;
            this.DescriptionTask = description;
            this.IdTp = idTp;
        }
        public static Models.Task Create() // Crée une Tache vide avec un GUID
        {
            var guid = Guid.NewGuid();
            return new Task(guid.ToString(), 1,"", "", "");
        }
    }
}
