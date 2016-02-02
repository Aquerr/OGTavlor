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

namespace OGTavlor
{
    /// <summary>
    /// Interaction logic for PictureSlideShow.xaml
    /// </summary>
    public partial class PictureSlideShow : Window
    {
        public PictureSlideShow()
        {
            InitializeComponent();
              
        }

        private void image_Loaded(object sender, RoutedEventArgs e)
        {
            //Loads the choosen image into the Image in PictureSlideShow.xaml

            BitmapImage bmi = new BitmapImage();
            bmi.BeginInit();
            bmi.UriSource = new Uri(@"C:\Users\Admin\Desktop\Git\OGTavlor\OGTavlor\bild1.JPG");
            bmi.EndInit();

            var picture = sender as Image;
            picture.Source = bmi;
            
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            //Button that will change to the next picture.
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            //Button that will change to the previous picture.
        }
    }
}
