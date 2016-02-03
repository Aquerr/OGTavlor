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
using System.Data.SqlClient;
using Microsoft.Win32;

namespace TavelProjektPT
{
    /// <summary>
    /// Interaction logic for LäggTillTavla.xaml
    /// </summary>
    public partial class AddArtwork : Window
    {
        public AddArtwork()
        {
            InitializeComponent();
        }

        private void LäggTill_Click(object sender, RoutedEventArgs e)
        {
            //Connect to SQL-Server.

            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=C:\Users\neoba\Databas\Tavlor.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand($"INSERT INTO Artwork (Title,ArtistId,RoomId) VALUES ('TxtBxName',1,1)", cn);
            cm.Connection = cn;

            cm.ExecuteNonQuery();
            cn.Close();

            OpenMainWindow();
        }

        private void ImagePanel_Drop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                MessageBox.Show(files[0]);
            }
        }

        private void Avbryt_Click(object sender, RoutedEventArgs e)
        {
            OpenMainWindow();
        }

        public void OpenMainWindow()
        {
            //Opens MainWindow and closes the AddArtwork page.
            MainWindow HomePage = new MainWindow();
            this.Close();
            HomePage.Show();
        }

        private void ChangePicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                Image.Source = new BitmapImage(new Uri(op.FileName));
                MessageBox.Show(Image.Source.ToString());
            }
        }
    }
}
