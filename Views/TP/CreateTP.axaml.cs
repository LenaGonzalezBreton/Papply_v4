using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.ViewModels;

namespace Papply.Views.TP
{
    public partial class CreateTP : UserControl
    {
        PapplyAppli.Classes.Degree DegreeInstance { get; set; }

        public CreateTP()
        {
            InitializeComponent();
            DegreeInstance = new PapplyAppli.Classes.Degree(1, "");
            CreateTPViewModel vm = new CreateTPViewModel(DegreeInstance);
            DataContext = vm;
        }

        private void btn_addpart_Click(object sender, RoutedEventArgs e)
        {
            /* PARTIE SANS LIAISON DE DONNEES
            var cardControl = new Papply.Models.CardControl();
            pan_part.Children.Add(cardControl);
            */
        }

        private void btn_addspart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
