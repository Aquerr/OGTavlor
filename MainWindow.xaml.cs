﻿using OGTavlor;
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
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "John Doe", Date = new DateTime(1971, 7, 23).ToString(), ImageUrl= "http://www.wpf-tutorial.com/images/misc/john_doe.jpg" }); //Temporary
            users.Add(new User() { Id = 2, Name = "Jane Doe", Date = new DateTime(1974, 1, 17).ToString() }); //Temp
            users.Add(new User() { Id = 3, Name = "Sammy Doe", Date = new DateTime (1991, 9, 2).ToString() }); //Temp
             //lvDataBinding = namn på ListView

            dgUsers.ItemsSource = users;
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Opens a window for adding artwork.

            LäggTillTavla LäggTill = new LäggTillTavla();
            this.Close();
            LäggTill.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click_1(object sender, RoutedEventArgs e) //Ta bort konstverk
        {
            //Opens a messagebox with a question and 3 buttons (Yes, No or Cancel)

            MessageBoxResult resultatet = MessageBox.Show("Är du säker på att du vill ta bort konstverket?", "Ta bort konstverk",MessageBoxButton.YesNo);
            if(resultatet==MessageBoxResult.Yes)    //"Yes" button
            {
                MessageBox.Show("Du har nu tagit bort detta konstverk", "Borttagget konstverk.");
            }
            if(resultatet==MessageBoxResult.No) //"No" button.
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
    

        public class User //Temp! ersätts sedan med klassen Konstverk MEN INTE ÄN!!!
        {
            public string Name { get; set; }
            public int Id { get; set; }
            //public string Mail { get; set; }
            public string Date { get; set; }
            public string ImageUrl { get; set; }

            //public override string ToString()
            //{
            //    return this.Name + ", " + this.Age + " years old";
            //}
        }
}
