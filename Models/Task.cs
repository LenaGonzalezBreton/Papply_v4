using Papply.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task
    {
        public int IdTask { get; set; }
        public double PointTask { get;set;}
        public string TitleTask { get; set; }
        public string DescriptionTask { get; set; }
        public int IdTp {  get; set; }

        public Task(int id,double point, string title, string description,int idTp)
        {
            IdTask = id;
            PointTask = point;
            TitleTask = title;
            DescriptionTask = description;
            IdTp = idTp;
        }
    }
}
