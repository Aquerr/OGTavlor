using System;
using System.Collections.Generic;
using System.Data;
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
            PopulateFields();

        }

        private void PopulateFields()
        {
            SqlConnection cn = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; AttachDbFilename = C:\Users\Admin\Databas\Tavlor.mdf; Initial Catalog = ArtWork; Integrated Security = True");
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader myReader = null;
            SqlCommand cm = new SqlCommand("select * from Artwork", cn);
            myReader = cm.ExecuteReader();
            while (myReader.Read())
            {
                TxtBxName.Text = (myReader["Title"].ToString());
                TxtBxRoom.Text = (myReader["RoomId"].ToString());
                TxtBxMaterial.Text = (myReader["Material"].ToString());
                TxtBxDate.Text = (myReader["Date"].ToString());
                TxtBxStatus.Text = (myReader["Status"].ToString());
                txbxBredd.Text = (myReader["Width"].ToString());
                txbxHöjd.Text = (myReader["Height"].ToString());
                txbxKonstnär.Text = (myReader["ArtistId"].ToString());
            }
            cn.Close();
        }

        private void BtnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; AttachDbFilename = C:\Users\Admin\Databas\Tavlor.mdf; Initial Catalog = ArtWork; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("UPDATE Artwork SET Title = @Title, RoomId = @RoomId, Material = @Material, Date = @Date, Status = @Status, Width = @Width, Height = @Height, ArtistId = @ArtistId", con);
            con.Open();

            cmd.Parameters.AddWithValue("@Title", TxtBxName.Text);
            cmd.Parameters.AddWithValue("@RoomId", TxtBxRoom.Text);
            cmd.Parameters.AddWithValue("@Material", TxtBxMaterial.Text);
            cmd.Parameters.AddWithValue("@Date", TxtBxDate.Text);
            cmd.Parameters.AddWithValue("@Status", TxtBxStatus.Text);
            cmd.Parameters.AddWithValue("@Width", txbxBredd.Text);
            cmd.Parameters.AddWithValue("@Height", txbxHöjd.Text);
            cmd.Parameters.AddWithValue("@ArtistId", txbxKonstnär.Text);

            cmd.ExecuteNonQuery();
            con.Close();
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
