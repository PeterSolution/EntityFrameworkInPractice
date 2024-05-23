using RPG090524;
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
using System.Windows.Shapes;

namespace dod
{
    /// <summary>
    /// Logika interakcji dla klasy window1.xaml
    /// </summary>
    public partial class window1 : Window
    {
        Character klasapostaci;
        BazaContext db = new BazaContext();
        public window1(Character ch)
        {
            InitializeComponent();
            klasapostaci = ch;
            /*ll2.Items.Add(klasapostaci.GetType().Name);
            ll2.Items.Add("Inteligencja"+klasapostaci.GetIntelligence());
            ll2.Items.Add("Sila"+klasapostaci.GetStrenght());
            ll2.Items.Add("Hp"+klasapostaci.GetVigor());*/
            var lista = db.character.ToList();
            Lista.ItemsSource = lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BazaContext db = new BazaContext();
            PlayerModel pm = new PlayerModel()
            {

                hp = this.klasapostaci.GetVigor(),
                klasa=this.klasapostaci.GetType().Name,
                inteligencja= this.klasapostaci.GetIntelligence(),
                sila=this.klasapostaci.GetStrenght(),
                isdead = false
            };
            db.character.Add(pm);
            db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var postac=Lista.SelectedItem as Character;
        }
    }
}
