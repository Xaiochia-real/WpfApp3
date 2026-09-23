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

namespace WpfApp3
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var targetTextbox = sender as TextBox;
            var targetStackPanel = targetTextbox.Parent as StackPanel;
            var targetNameLabel = targetStackPanel.Children[0] as Label;
            var targetPriceLabel = targetStackPanel.Children[1] as Label;

            int amount;
            bool success = int.TryParse(targetTextbox.Text, out amount);
            if (!success)
            {
                MessageBox.Show("請輸入正確數值", "輸入錯誤");
            }
            else
            {
                string drinkName = targetNameLabel.Content.ToString();
                int price = Convert.ToInt32(targetPriceLabel.Content.ToString().Substring(0, 2));
                ResultTextBlock.Text = $"您選擇了 {drinkName}，數量為 {amount}，總價為 {price * amount} 元\n";
            }
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}