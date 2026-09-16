using MyNotesApp.Services;
using MyNotesApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyNotesApp.Views
{
    /// <summary>
    /// Логика взаимодействия для NotesPage.xaml
    /// </summary>
    public partial class NotesPage : Page
    {
        private readonly NotesViewModel _viewModel;

        public NotesPage()
        {
            InitializeComponent();
            _viewModel = new NotesViewModel(new NotesService());
            LstNotes.ItemsSource = _viewModel.Notes;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNote.Text))
            {
                _viewModel.AddNote(TxtNote.Text);
                TxtNote.Clear();
            }
        }
    }
}
