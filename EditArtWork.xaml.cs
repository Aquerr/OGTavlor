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
using System.Windows.Shapes;
using TavelProjektPT;

namespace OGTavlor
{
    /// <summary>
    /// Interaction logic for EditArtWork.xaml
    /// </summary>
    public partial class EditArtWork : Window
    {
        public EditArtWork()
        {
            InitializeComponent();
        }

        private void BtnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Konstverkets ändringar har nu blivit sparade!");
            MainWindow StartSida = new MainWindow();
            this.Close();
            StartSida.Show();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow StartSida = new MainWindow();
            this.Close();
            StartSida.Show();
        }
    }
}
