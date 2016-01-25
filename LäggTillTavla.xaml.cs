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

namespace TavelProjektPT
{
    /// <summary>
    /// Interaction logic for LäggTillTavla.xaml
    /// </summary>
    public partial class LäggTillTavla : Window
    {
        public LäggTillTavla()
        {
            InitializeComponent();
        }

        private void LäggTill_Click(object sender, RoutedEventArgs e)
        {
            MainWindow StartSida = new MainWindow(); //öppnar en ny form
            this.Close();
            StartSida.Show();
        }

        private void Avbryt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow StartSida = new MainWindow(); //öppnar en ny form
            this.Close();
            StartSida.Show();
        }
    }
}
