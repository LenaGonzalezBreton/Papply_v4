using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DynamicData;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Papply.Models;
using Papply.Storage;
using Papply.ViewModels;

namespace Papply.Views;

public partial class ListeEleves : UserControl
{
    private Student students;

    public ListeEleves()
    {
        InitializeComponent();

    }

    private void Btn_add_OnClick(object? sender, RoutedEventArgs e)
    {
        FormAddEleve.IsVisible = !FormAddEleve.IsVisible;
    }

    private void EditableCombobox_TextChanged(object sender, RoutedEventArgs e)
    {
        string searchtext = editableComboBox.Text;

        if (!string.IsNullOrWhiteSpace(searchtext))
        {

        }
    }

    private void BtnValider_OnClick(object? sender, RoutedEventArgs e)
    {
        var nomEleve = tbxNom.Text;
        var prenomEleve = tbxPrenom.Text;
        var promoEleve = "sas";
        var idEleve = "dzkdz";

        if (!string.IsNullOrWhiteSpace(nomEleve) && !string.IsNullOrWhiteSpace(prenomEleve))
        {
            // Créer un nouvel étudiant avec les informations saisies
            var newStudent = new Student(idStudent: idEleve, nomStudent: nomEleve, prenomStudent: prenomEleve,
                idPromotion: promoEleve)
            {
                NomStudent = nomEleve,
                PrenomStudent = prenomEleve,
                IdPromotion = promoEleve

                // Autres propriétés de Student
            };

            // Ajouter le nouvel étudiant au DataStorage
            Models.Student.Create();

            // Rafraîchir la source de données du DataGrid pour refléter les modifications
            // dataGrid.ItemsSource = _dataStorage.GetAllStudents();

            // Réinitialiser les TextBox après l'ajout de l'étudiant
            tbxNom.Text = string.Empty;
            tbxPrenom.Text = string.Empty;

        }
    }
}

 