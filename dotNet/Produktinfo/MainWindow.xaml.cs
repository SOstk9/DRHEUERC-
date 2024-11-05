using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Produktinfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Kategorie> comboBox = new List<Kategorie>();
        public MainWindow()
        {
            InitializeComponent();

            FileStream fs = new FileStream("C:\\Users\\ITA5-TN15\\OneDrive - IT-Akademie Dr. Heuer GmbH\\Programmieren\\dotNet\\Produkte.json", FileMode.OpenOrCreate);
            comboBox = JsonSerializer.Deserialize<List<Kategorie>>(fs);


            List<string> neu = new List<string>();

            foreach (Kategorie k in comboBox)
            {
                neu.Add(k.ToString());
                Combo.Items.Add(k.CategoryName);
            }





        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch (Combo.SelectedIndex)
            {
                case 0:
                    if (Listi.Items.Count != 0)
                    {
                        Listi.Items.Clear();
                    }


                    foreach (Products p in comboBox[0].Products)
                    {
                        Listi.Items.Add(p.Name);
                    }

                    break;
                case 1:
                    if (Listi.Items.Count != 0)
                    {
                        Listi.Items.Clear();

                    }

                    foreach (Products p in comboBox[1].Products)
                    {
                        Listi.Items.Add(p.Name);
                    }

                    break;
                case 2:
                    if (Listi.Items.Count != 0)
                    {
                        Listi.Items.Clear();

                    }

                    foreach (Products p in comboBox[2].Products)
                    {
                        Listi.Items.Add(p.Name);
                    }


                    break;
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexCategory = Combo.SelectedIndex;
            int index = Listi.SelectedIndex;

            if (Listi.SelectedItem != null)
            {
                TextBoxPName.Text = Listi.SelectedItem.ToString();
                TextBoxPreis.Text = comboBox[indexCategory].Products[index].Price.ToString();
            }
        }

        private void Combo_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {



        }


    }
}