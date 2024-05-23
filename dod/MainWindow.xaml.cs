using RPG090524.Kasy;
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

namespace dod
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Character character;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ll1.Items.Clear();
            if (cm.IsChecked == true)
            {
                ll1.Items.Add("Wybrales klase maga");
                character = CharacterCreator.Create(1);
            }
            else
            {
                if (cr.IsChecked == true)
                {

                    ll1.Items.Add("Wybrales klase Rouge");
                    character = CharacterCreator.Create(2);
                }
                else
                {
                    if (cs.IsChecked == true)
                    {

                        ll1.Items.Add("Wybrales klase szamana");
                        character = CharacterCreator.Create(3);
                    }
                    else
                    {
                        if (cw.IsChecked == true)
                        {

                            ll1.Items.Add("Wybrales klase wojownika");
                            character = CharacterCreator.Create(0);
                        }
                    }
                }
            }
            window1 okno=new window1(character);
            okno.Show();
        }
    }
}
