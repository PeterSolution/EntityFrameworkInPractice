using RPG090524.Kasy;
using RPG090524.Kasy.Enemies;
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

namespace RPGFront
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character player;
        Enemy enemy;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerujButon_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
