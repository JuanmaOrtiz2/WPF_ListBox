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

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //Creando la lista de elementos y añadiéndola
            List<Serie> Series = new List<Serie>();
            Series.Add(new Serie() { titulo = "Juego de Tronos", temporadas = 8, capitulos = 73, actual = 73, progreso = 100 });
            Series.Add(new Serie() { titulo="Breaking Bad",temporadas= 5, capitulos=62, actual=20, progreso = 33 });
            Series.Add(new Serie() { titulo="Vikings", temporadas=6, capitulos=89, actual=70,progreso=78 });
            Series.Add(new Serie() { titulo="Peaky Blinders", temporadas=5, capitulos=30, actual=20,progreso=66 });
            MisSeries.ItemsSource = Series;

        }

       

        //Botón Saber más que nos dice cuál es el capitulo que vamos a ver o si la hemos terminado
        private void BtnMas_Click(object sender, RoutedEventArgs e)
        {
            if (MisSeries.SelectedItem == null) MessageBox.Show("No ha seleccionado serie");
            else if((MisSeries.SelectedItem as Serie).capitulos == (MisSeries.SelectedItem as Serie).actual)
            {
                MessageBox.Show("La serie " + (MisSeries.SelectedItem as Serie).titulo + " tiene " +
                         (MisSeries.SelectedItem as Serie).temporadas + " temporadas compuesta de " +
                         (MisSeries.SelectedItem as Serie).capitulos + " capitulos y ya la he terminado. ");
            }
            else
            {
                MessageBox.Show("La serie " + (MisSeries.SelectedItem as Serie).titulo + " tiene " +
                         (MisSeries.SelectedItem as Serie).temporadas + " temporadas compuesta de " +
                         (MisSeries.SelectedItem as Serie).capitulos + " capitulos y actualmente voy por el " +
                         (MisSeries.SelectedItem as Serie).actual + ". ");
            }
          
        }
        

        
        //Si pulsamos en la primera celda, en el título, nos dará la misma descripción de saber más
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MisSeries.SelectedItem != null)
            {
                MessageBox.Show("La serie " + (MisSeries.SelectedItem as Serie).titulo + " tiene " +
                                     (MisSeries.SelectedItem as Serie).temporadas + " temporadas compuesta de " +
                                     (MisSeries.SelectedItem as Serie).capitulos + " capitulos y actualmente voy por el " +
                                     (MisSeries.SelectedItem as Serie).actual + ". ");
            }
                
        }
    }

    
    public class Serie
    {
        public string titulo { get; set; }
        public int temporadas { get; set; }
        public int capitulos { get; set; }
        public int actual { get; set; }
        public int progreso { get; set; }



    }
}
