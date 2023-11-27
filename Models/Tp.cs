using Avalonia.Controls;
using DynamicData;
using DynamicData.Alias;
using Papply.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Papply.Models
{
    public class Tp
    {
        // attributs
        public string IdTp { get; set; } 
        public string TitreTp { get; set; }
        public string DescriptionTp {  get; set; }

        public double Total {  get; set; }
        private readonly ReadOnlyObservableCollection<Models.Task> _tasks;
        public ReadOnlyObservableCollection<Models.Task> Tasks => _tasks;

        public DateTime test { get; set; }


        public Tp(string id, string titre, string description)
        {
            this.IdTp = id;
            this.TitreTp = titre;
            this.DescriptionTp = description;

            // Récupération des taches du tp
            DataStorage.Tasks
                .Connect()
                .Where(task => task.IdTp == this.IdTp)
                .Bind(out _tasks)
                .Subscribe();
        }

        public static Models.Tp Create () // Crée un TP vide avec un GUID
        {
            var guid = Guid.NewGuid();
            return new Tp(guid.ToString(), "", "");
        }
    }
}
