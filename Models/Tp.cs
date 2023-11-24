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
        public int IdTp { get; set; }
        //GUID a la place de l'int


        public string TitreTp { get; set; }
        public string DescriptionTp {  get; set; }

        public double Total {  get; set; }
        private readonly ReadOnlyObservableCollection<Models.Task> _tasks;
        public ReadOnlyObservableCollection<Models.Task> Tasks => _tasks;

        public DateTime test { get; set; }


        public Tp(int id, string titre, string description)
        {
            IdTp = id;
            TitreTp = titre;
            DescriptionTp = description;

            // Récupération des taches du tp
            DataStorage.Tasks
                .Connect()
                .Where(task => task.IdTp == this.IdTp)
                .Bind(out _tasks)
                .Subscribe();
        }

        public static Models.Tp Create ()
        {
            var id = 0;
            return new Tp(id, "", "");
        }
        /*
             Générer un Guid dans la création de TP
            DataSource identificateur
            Réadapte int en Guid
             Création de TP avec les bonnes valeurs
         */
    }
}
