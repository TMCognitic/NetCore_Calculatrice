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

namespace NetCore_Calculatrice
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

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Button button = (Button)e.OriginalSource;
            MessageBox.Show($"On a cliqué sur un bouton mémoire sender {sender.GetType()} {e.OriginalSource.GetType()} {button.Content}");
        }

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Button button = (Button)e.OriginalSource;
            MessageBox.Show($"On a cliqué sur un bouton numérique sender {sender.GetType()} {e.OriginalSource.GetType()} {button.Content}");
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.OriginalSource;
            MessageBox.Show($"On a cliqué sur un bouton opération sender {sender.GetType()} {e.OriginalSource.GetType()} {button.Content}");
        }
    }
}
