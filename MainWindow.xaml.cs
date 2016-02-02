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
            FillList();
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

        public void FillList()
        {

            foreach (var item in Konstverk.Artwork)
            {
                ListViewItem Listitem = new ListViewItem();
                Listitem.BorderBrush = Brushes.Black;
                WrapPanel pnl = new WrapPanel();

                Image img = new Image();
                var uriSource = new Uri(item.ImagePath, UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                pnl.Children.Add(img);

                TextBlock txt = new TextBlock();
                txt.Text = item.Name + " ";
                pnl.Children.Add(txt);

                txt = new TextBlock();
                txt.Text = item.Artist + " ";
                pnl.Children.Add(txt);

                txt = new TextBlock();
                txt.Text = item.Room;
                pnl.Children.Add(txt);

                Listitem.Content = pnl;

                ArtworkListView.Items.Add(Listitem);
            }
        }

        private void PictureClick(object sender, RoutedEventArgs e)
        {
            // Opens a new window with big picture. Window is maximized from the start.
            Window picture1 = new Window();
            picture1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            picture1.SourceInitialized += (s, a) => picture1.WindowState = WindowState.Maximized;
            picture1.Title = "Bildspel";
            Image BigPicture = new Image();
            var uriSource = new Uri("bild1.JPG", UriKind.Relative);
            BigPicture.Source = new BitmapImage(uriSource);
            picture1.Show();
        }
    }
}
