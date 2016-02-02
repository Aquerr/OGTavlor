using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //SqlConnection cn = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; AttachDbFilename = C:\Users\Admin\Databas\Tavlor.mdf; Initial Catalog = ArtWork; Integrated Security = True");
            //cn.Open();

            //SqlCommand cm = new SqlCommand("");
            
            //cn.Close();
            
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
