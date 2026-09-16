using System.Text;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new NotesPage());
        }

        private void BtnNotes_Click(object sender, RoutedEventArgs e) => MainFrame.Navigate(new NotesPage());
        private void BtnCalc_Click(object sender, RoutedEventArgs e) => MainFrame.Navigate(new CalcPage());
        private void BtnAbout_Click(object sender, RoutedEventArgs e) => MainFrame.Navigate(new AboutPage());
    }
}