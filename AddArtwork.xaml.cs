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

            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=C:\Users\Admin\Databas\Tavlor.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand($"INSERT INTO Artwork (Title,ArtistId,RoomId) VALUES ('TxtBxName',1,1)", cn);
            cm.Connection = cn;

            cm.ExecuteNonQuery();
            cn.Close();

            OpenMainWindow();
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

    }
}
