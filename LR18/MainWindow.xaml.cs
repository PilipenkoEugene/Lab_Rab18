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

namespace LW__18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(textBoxN.Text);
                int K = int.Parse(textBoxK.Text);
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);

                double Z = 0;

                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= K; j++)
                    {
                        Z += (Math.Pow(x, i) + Math.Pow(y, j)) / (i * j);
                    }
                }

                textBoxAns.Text = Math.Round(Z, 3).ToString();
            }
            catch
            {
                textBoxAns.Text = "No way";
            }
        }

        private void textBoxX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
