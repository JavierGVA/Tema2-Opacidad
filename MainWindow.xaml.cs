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

namespace Tema2_Opacidad
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

        private void mouse_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Image imagen)
            {
                imagen.Opacity = 1;
            }
        }

        private void mouse_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Image imagen)
            {
                imagen.Opacity = 0.5;
            }
        }
    }
}
