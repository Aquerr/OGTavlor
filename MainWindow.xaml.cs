using OGTavlor;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TavelProjektPT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //FillList();
            FillTheListWithDB();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Opens a window for adding artwork.
            AddArtwork AddArt = new AddArtwork();
            this.Close();
            AddArt.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e) //Ta bort konstverk
        {
            //Opens a messagebox with a question and 3 buttons (Yes, No or Cancel)

            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill ta bort konstverket?", "Ta bort konstverk", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)    //"Yes" button
            {
                MessageBox.Show("Du har nu tagit bort detta konstverk", "Borttagget konstverk.");
            }
            if (result == MessageBoxResult.No) //"No" button.
            {
                MessageBox.Show("Konstverket har inte tagits bort", "Konstverket ej raderat");
            }
        }

        private void RedigeraKonstverk_Click(object sender, RoutedEventArgs e)
        {





            //Opens a window for editing artwork.
            EditArtWork EditArt = new EditArtWork();
            this.Close();
            EditArt.Show();
        }

        private void SearchBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            SearchBox.Text = "";
        }

        //public void FillList()
        //{

        //    foreach (var item in Konstverk.Artwork)
        //    {
        //        ListViewItem Listitem = new ListViewItem();
        //        Listitem.BorderBrush = Brushes.Black;
        //        WrapPanel pnl = new WrapPanel();

        //        Image img = new Image();
        //        var uriSource = new Uri(item.ImagePath, UriKind.Relative);
        //        img.Source = new BitmapImage(uriSource);
        //        pnl.Children.Add(img);

        //        TextBlock txt = new TextBlock();
        //        txt.Text = item.Name + " ";
        //        pnl.Children.Add(txt);

        //        txt = new TextBlock();
        //        txt.Text = item.Artist + " ";
        //        pnl.Children.Add(txt);

        //        txt = new TextBlock();
        //        txt.Text = item.Room;
        //        pnl.Children.Add(txt);

        //        Listitem.Content = pnl;

        //        ArtworkListView.Items.Add(Listitem);

        //    }
        //}


        public void FillTheListWithDB()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename=C:\Users\Aquerr\Databas\Tavlor.mdf;Initial Catalog=ArtWorks;Integrated Security=True");
            //Open connection to Database
            cn.Open();

            //Simple Exception. (Simple look if getting data from database is working. If not then program will not crash.)
            try
            {
                SqlCommand cm = new SqlCommand("SELECT * FROM Artwork", cn);
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {

                    ListViewItem Listitem = new ListViewItem();
                    Listitem.BorderBrush = Brushes.Black;
                    WrapPanel pnl = new WrapPanel();

                    Image img = new Image();
                    var uriSource = new Uri(dr[10].ToString(), UriKind.RelativeOrAbsolute);
                    img.Source = new BitmapImage(uriSource);
                    img.MaxWidth = 200;
                    img.MaxHeight = 150;
                    img.Stretch = Stretch.Fill;
                    pnl.Children.Add(img);

                    TextBlock txt = new TextBlock();
                    txt.Text = dr[1].ToString() + " ";
                    pnl.Children.Add(txt);

                    txt = new TextBlock();
                    txt.Text = dr[2].ToString() + " ";
                    pnl.Children.Add(txt);

                    txt = new TextBlock();
                    txt.Text = dr[3].ToString();
                    pnl.Children.Add(txt);

                    Button btn = new Button();
                    btn.HorizontalAlignment = HorizontalAlignment.Right;
                    btn.VerticalAlignment = VerticalAlignment.Bottom;
                    btn.Name = "TaBort";
                    btn.Content = "Ta Bort";
                    btn.Width = 60;
                    btn.Height = 30;
                    pnl.Children.Add(btn);

                    Listitem.Content = pnl;

                    ArtworkListView.Items.Add(Listitem);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with database. " + "Exception: " + ex);
            }

        }

        private void PictureClick(object sender, RoutedEventArgs e)
        {
            // Opens a new window with big picture. Window is maximized from the start.
            PictureSlideShow SlideShow = new PictureSlideShow();
            this.Close();
            SlideShow.Show();
        }




        //Search function
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Search function
            if (e.Key == Key.Enter)
            {
                if (SearchBox.Text == "")
                {
                    MessageBox.Show("Du har inte sökt efter någonting, sök igen", "Tom sökruta");
                }

                //if (SearchBox.Text=="Uggla")
                //{

                //}
            }

        }
    }
}
