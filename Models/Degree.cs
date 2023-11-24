using DynamicData;
using DynamicData.Alias;
using Papply.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Papply.Models
{
    public class Degree
    {
        // attributs
        public int IDDegree { get; set; } 
        public string TitreDegree { get; set; }

        public string DescDegree {  get; set; }

        private readonly ReadOnlyObservableCollection<Models.Task> _tasks;
        public ReadOnlyObservableCollection<Models.Task> Tasks => _tasks;

        public DateTime test { get; set; }

    public double Total;

        public Degree(int idDegree, string libDegree)
        {
            IDDegree = idDegree;
            TitreDegree = libDegree;
            DescDegree = libDegree + " Description";
            DataStorage.Tasks
                .Connect()
                .Where(t => t.IdDegree == this.IDDegree)
                .Bind(out _tasks)
                .Subscribe();
            test = DateTime.Now;
        }

        public Degree()
        {
            IDDegree += 1;
            TitreDegree += "Titre";
            DescDegree += "Description";
            DataStorage.Tasks
                .Connect()
                .Where(t=>t.IdDegree== this.IDDegree).Bind(out _tasks).Subscribe();
            test = DateTime.Now;
        }
    }
}
