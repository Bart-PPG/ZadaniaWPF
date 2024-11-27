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

namespace zad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int bok;
            int obwod;

            if (int.TryParse(bokFigury.Text, out bok))
            {
                //MessageBox.Show(bok.ToString());
                string figura1 = figura.Text;
                
                if(figura1 == "Kwadrat")
                {
                    obwod = bok * 4;
                    MessageBox.Show("pole wynosi: " + obwod);
                }

                if(figura1 == "Trojkat")
                {
                    obwod = bok * 3;
                    MessageBox.Show("pole wynosi: " + obwod);
                }
                if (figura1 == "Pieciokat")
                {
                    obwod = bok * 5;
                    MessageBox.Show("pole wynosi: " + obwod);
                }
            }
            else
            {
                MessageBox.Show("to nie jest liczba");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float iloscWaluty;
            float wynik = 0;
            if (float.TryParse(ilosc.Text, out iloscWaluty))
            {

              if (euro.IsChecked == true)
                {
                    wynik =(float)( iloscWaluty * 0.26);
                }

               else if (frank.IsChecked == true)
                {
                    wynik = (float)(iloscWaluty * 0.22);
                }
               else if (dolar.IsChecked == true)
                {
                    wynik = (float)(iloscWaluty * 0.24);

                }
                MessageBox.Show(wynik.ToString());
            }
            else
            {
                MessageBox.Show("to nie jest liczba");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
    }

