using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppVerifica_Git
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Libro> l = new List<Libro>();
        Biblioteca b = new Biblioteca("Pinocchio", "via dei matti, 0", "10:00", "16:00", l);
        public MainWindow()
        {
            InitializeComponent();
            
            Libro l1 = new Libro("Kafka", "La Metamorfosi", "1913", "Mondadori", 170);
            Libro l2 = new Libro("Orwell", "1984", "1943", "Mondadori", 410);
            Libro l3 = new Libro("Christie", "Il nome alla rosa", "1928", "Mondadori", 320);
            l.Add(l1);
            l.Add(l2);
            l.Add(l3);
            
            
        }

        private void btnNome_Click(object sender, RoutedEventArgs e)
        {
            nome_txt.Text = b.Nome;
        }

        private void btnCreaLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro l = new Libro(tbxAutore.Text, tbxTitolo.Text, tbxAnno.Text, tbxEditore.Text, int.Parse(tbxPagine.Text));
            l.Add(l);
        }


    }
}