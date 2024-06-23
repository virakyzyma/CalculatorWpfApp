using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWpfApp
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
        private void CalculateTotal_Click(object sender, RoutedEventArgs e)
        {
            if(!decimal.TryParse(purchaseTextBox.Text, out decimal purchaseAmount))
            {
                MessageBox.Show("Bвеедите корректное значение стоимости покупки.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(totalTextBlock.Tag == null)
            {
                totalTextBlock.Tag = 0m;
            }
            decimal total = (decimal)totalTextBlock.Tag + purchaseAmount;
            totalTextBlock.Tag = total;
            totalTextBlock.Text = $"Oбщая сумма: {total}$";
            purchaseTextBox.Text = "";
        }
    }
}