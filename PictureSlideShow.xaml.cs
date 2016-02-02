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
            //BitMapImage

            BitmapImage bmi = new BitmapImage();
            bmi.BeginInit();
            bmi.UriSource = new Uri(@"C:\Users\Admin\Desktop\Git\OGTavlor\OGTavlor\bild1.JPG");
            bmi.EndInit();

            var image = sender as Image;
            image.Source = bmi;
            
        }
    }
}
