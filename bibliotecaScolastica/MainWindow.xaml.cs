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

namespace bibliotecaScolastica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //forza italia
        Biblioteca b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = new Biblioteca(nome.Text, indirizzo.Text, int.Parse(orarioApertura.Text), int.Parse(orariochiusura.Text));
        }

        private void trovaNLibri_Click(object sender, RoutedEventArgs e)
        {
            numLibri.Text = b.numeroLibri().ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            libriAutore.ItemsSource = null;
            libriAutore.ItemsSource = b.ricercaLibriAutore(aturore.Text);
        }

        private void cerca2_Click(object sender, RoutedEventArgs e)
        {
            risultato2.Text = b.ricercaLibroConTitolo(titolo.Text).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Libro l = libri.SelectedItem as Libro;
            tempolettura.Text = l.readingTine();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            b.AggiuntaLibro(new Libro(aut.Text, tit.Text, new DateTime(int.Parse(anno.Text), 1, 1), edit.Text, int.Parse(nPg.Text)));
            libri.ItemsSource = null;
            libri.ItemsSource = b._libri;
        }
    }
}
