using Papply.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task
    {
        public double PointTask {  get; set; }

        public string Title {  get; set; }

        public string Description {  get; set; }

        public CardControl card { get; set; }

        public Task()
        {
            PointTask = 0;
            Title = "Titre";
            Description = string.Empty;
            card = new CardControl(0);
        }
    }
}
