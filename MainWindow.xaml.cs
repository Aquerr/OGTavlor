using OGTavlor;
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
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" }); //Temporary
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" }); //Temporary
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Mail = "sammy.doe@gmail.com" }); //Temporary
            lvDataBinding.ItemsSource = items; //lvDataBinding = name for the ListView
        }

        public class User //Temporary! to be replaced with the class artwork but not yet!
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Mail { get; set; }

            public override string ToString()
            {
                return this.Name + ", " + this.Age + " years old";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Opens a window for adding artwork.
            //KVAR ATT ÖVERSÄTTA!

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

            MessageBoxResult result = MessageBox.Show("Är du säker på att du vill ta bort konstverket?", "Ta bort konstverk",MessageBoxButton.YesNo);
            if(result==MessageBoxResult.Yes)    //"Yes" button
            {
                MessageBox.Show("Du har nu tagit bort detta konstverk", "Borttagget konstverk.");
            }
            if(result==MessageBoxResult.No) //"No" button.
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
    }
}
