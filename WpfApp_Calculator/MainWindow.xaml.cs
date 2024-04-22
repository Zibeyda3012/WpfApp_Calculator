using System.Data;
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

namespace WpfApp_Calculator
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void equality_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var Result = dt.Compute(TextLabel.Content.ToString(), "");
                TextLabel.Content = Result.ToString();
            }
            catch
            {
                TextLabel.Content = "";
            }
        }

        private void clear_btn2_Click(object sender, RoutedEventArgs e)
        {
            TextLabel.Content = "";
        }

        private void clear_btn1_Click(object sender, RoutedEventArgs e)
        {
            TextLabel.Content = "";
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string text = TextLabel.Content.ToString();
            if (text == "0")
                text = "";
            text += btn.Content;
            TextLabel.Content = text;
        }
    }
}