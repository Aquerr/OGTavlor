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
using System.Data;

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
            LoadComboBox();
        }

        string Title;
        string Rum;
        string Material;
        string Date;
        string Status;
        int Width = 0;
        int Height = 0;
        string Comment;
        string ImagePath;

        private void LäggTill_Click(object sender, RoutedEventArgs e)
        {
            //Get Values from TextBoxes.
            GetValues();

            //Connect to SQL-Server.
            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=C:\Users\neoba\Databas\Tavlor.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand($"INSERT INTO Artwork (Title,ArtistId,RoomId,ImagePath) VALUES ('TxtBxName',1,1,Image.Source.ToString())", cn);
            cm.Connection = cn;

            cm.ExecuteNonQuery();
            cn.Close();

            //Clear TextBoxes & assigned values.
            ClearValues();

            //Open Main Window.
            OpenMainWindow();
        }

        private void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=C:\Users\neoba\Databas\Tavlor.mdf;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT ArtistId, Name FROM Artist", cn);
            try
            {
                cm.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "Artist");

                comboBoxArtist.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxArtist.DisplayMemberPath = "Name";
                comboBoxArtist.SelectedValuePath = "ArtistId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading combobox.");
            }
            finally
            {
                cn.Close();
            }
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
                ImagePath = (Image.Source as BitmapImage).UriSource.AbsolutePath;
                MessageBox.Show(ImagePath);
            }
        }

        //This function may be unnecessary.
        private void GetValues()
        {
            Title = TxtBxTitle.Text;
            Rum = TxtBxRoom.Text;
            Material = TxtBxMaterial.Text;
            Date = TxtBxDate.Text;
            Status = TxtBxStatus.Text;
            bool IsWidth = int.TryParse(TxtBxWidth.Text, out Width);
            bool IsHeight = int.TryParse(TxtBxHeight.Text, out Height);
            Comment = TxtBxCommentDescription.Text;
        }

        //This function may be unnecessary.
        private void ClearValues()
        {
            Title = "";
            Rum = "";
            Material = "";
            Date = "";
            Status = "";
            Width = 0;
            Height = 0;
            Comment = "";
            ImagePath = "";
        }
    }
}
