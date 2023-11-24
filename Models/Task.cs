using Papply.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task
    {
        public int IDTask { get; set; }
        public double PointTask { get;set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdDegree {  get; set; }

        static Random index = new Random();

        public Task()
        {
            IDTask = index.Next(0,1000000000);
            PointTask = 0;
            Title = "Titre Sous Partie";
            Description = "Description Sous Partie";
            IdDegree = 0;
        }

        public Task(double pointTask, string title, string description,int fkidtp)
        {
            PointTask = pointTask;
            Title = title;
            Description = description;
            IdDegree = fkidtp;
        }
    }
}
