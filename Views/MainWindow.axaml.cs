using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.Views.TP;
using Papply.Storage;
using Papply.ViewModels;

namespace Papply.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {

    }
    private void btn_dashboard_Click(object sender, RoutedEventArgs e)
    {
        ChangeContent(new DashBoard());
    }
    private void ChangeContent(UserControl newContent)
    {
        MainContent.Content = newContent;
    }

    private void btn_create_Click(object sender, RoutedEventArgs e)
    {
        ChangeContent(new CreateTP());
    }

    private void btn_manage_Click(object sender, RoutedEventArgs e)
    {
        ChangeContent(new GestionTp());
    }

    private void btn_list_Click(object sender, RoutedEventArgs e)
    {
        ChangeContent(new ListeEleves());
    }
    private void btn_historique_Click(object sender, RoutedEventArgs e)
    {
        ChangeContent(new HistoriqueTp());
    }
}