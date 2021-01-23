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

namespace burcnee
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void Aslan_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Aslan").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
            
        }

        private void Koc_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Koç").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Boga_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Boğa").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Ikizler_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("İkizler").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Yengec_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Yengeç").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Basak_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Başak").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Terazi_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Terazi").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Akrep_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Akrep").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Yay_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Yay").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Oglak_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Oğlak").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Kova_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Kova").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }

        private void Balik_Click(object sender, RoutedEventArgs e)
        {
            using (ServisBurc.BurcServisClient servisClient = new ServisBurc.BurcServisClient())
            {
                var model = servisClient.BurcGezegeniGetir("Balık").ToList();
                gezegen.Text = model[0];
                Yorum.Text = model[1];
            }
        }
    }
}
