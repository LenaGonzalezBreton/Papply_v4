using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Wpf.Ui.Controls;

namespace PapplyAppli.Classes
{
    public class GroupTask
    {
        List<Task> _listtask = new List<Task>();
        public int _id { get; set; }
        public bool _isvalid { get; set; }
        public double _total { get; set; }
        public string _title { get; set; }
        public string _desc { get; set; }

        public Card grptaskcard { get; set; }

        public List<Task> GetTasks()
        {
            return _listtask;
        }
        public void SetTasks(List<Task> list)
        {
            this._listtask = list;
        }

        public double CalculTotal()
        {
            double res = 0;
            foreach(Task task in _listtask)
            {
                res += task._pointtask;
            }
            return res;
        }

        public GroupTask(int id, bool isvalid, List<Task> listtask, string desc,string title)
        {
            _id = id;
            this._isvalid = isvalid;
            _listtask = listtask;
            _total = CalculTotal();
            _desc = desc;
            _title = title;

            grptaskcard = new Card();
            grptaskcard.Width = 283;
            grptaskcard.Height = double.NaN; // Auto
            grptaskcard.MaxHeight = 180;
            grptaskcard.Margin = new Thickness(0, 0, 25, 0);


            SolidColorBrush backgroundBrush = new SolidColorBrush(Color.FromRgb(255, 61, 0)); // #FFFF3D00 en RGB
            grptaskcard.Background = backgroundBrush;

            StackPanel stackPanel = new StackPanel();

            Wpf.Ui.Controls.Button deleteButton = new Wpf.Ui.Controls.Button();
            deleteButton.Content = "Supprimer la Carte";
            deleteButton.Click += DeleteButton_Click; // Associez un gestionnaire d'événements pour la suppression
            deleteButton.HorizontalAlignment = HorizontalAlignment.Right;
            deleteButton.VerticalAlignment = VerticalAlignment.Top;
            deleteButton.Margin = new Thickness(0,0,0,10);
            stackPanel.Children.Add(deleteButton);

            Wpf.Ui.Controls.TextBox titlebox = new Wpf.Ui.Controls.TextBox();
            titlebox.Text = this._title;
            titlebox.FontSize = 18;
            titlebox.VerticalAlignment = VerticalAlignment.Top;
            stackPanel.Children.Add(titlebox);

            Wpf.Ui.Controls.TextBox descbox = new Wpf.Ui.Controls.TextBox();
            descbox.TextWrapping = TextWrapping.Wrap;
            descbox.Width = 252;
            descbox.Height = 220;
            descbox.Padding = new Thickness(10, 12, 10, 12);
            descbox.Text = this._desc;
            stackPanel.Children.Add(descbox);

            grptaskcard.Content = stackPanel;
        }

        public GroupTask(int id, bool isvalid, List<Task> listtask)
        {
            _id = id;
            this._isvalid = isvalid;
            _listtask = listtask;
            _total = CalculTotal();

            grptaskcard = new Card();
            grptaskcard.Width = 283;
            grptaskcard.Height = double.NaN; // Auto
            grptaskcard.MaxHeight = 180;
            grptaskcard.Margin = new Thickness(0, 0, 25, 0);

            SolidColorBrush backgroundBrush = new SolidColorBrush(Color.FromRgb(255, 61, 0)); // #FFFF3D00 en RGB
            grptaskcard.Background = backgroundBrush;

            StackPanel stackPanel = new StackPanel();

            Wpf.Ui.Controls.TextBox titlebox = new Wpf.Ui.Controls.TextBox();
            titlebox.Text = this._title;
            titlebox.FontSize = 18;
            titlebox.VerticalAlignment = VerticalAlignment.Top;
            titlebox.Margin= new Thickness(0,15,0,0);
            stackPanel.Children.Add(titlebox);

            Wpf.Ui.Controls.TextBox descbox = new Wpf.Ui.Controls.TextBox();
            descbox.TextWrapping = TextWrapping.Wrap;
            descbox.Width = 252;
            descbox.Height = 220;
            descbox.Padding = new Thickness(10, 12, 10, 12);
            descbox.Text = this._desc;
            stackPanel.Children.Add(descbox);

            Wpf.Ui.Controls.Button deleteButton = new Wpf.Ui.Controls.Button();
            deleteButton.Content = "x";
            deleteButton.Click += DeleteButton_Click; // Associez un gestionnaire d'événements pour la suppression
            deleteButton.HorizontalAlignment = HorizontalAlignment.Right;
            deleteButton.VerticalAlignment = VerticalAlignment.Top;

            stackPanel.Children.Add(deleteButton);

            grptaskcard.Content = stackPanel;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Code pour gérer la suppression de la carte
            // Vous pouvez utiliser le sender pour identifier la carte à supprimer
        }
    }
}
