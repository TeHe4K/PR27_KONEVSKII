using Cinema_Konevskii.Classes;
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

namespace Cinema_Konevskii.Pages.Kinoteatr.Items
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        KinoteatrContext kinoteat;
        public Add(KinoteatrContext kinoteat = null)
        {
            InitializeComponent();

            if(kinoteat != null)
            {
                this.kinoteat = kinoteat;
                name.Text = kinoteat.Name;
                countZal.Text = kinoteat.CountZal.ToString();
                Count.Text = kinoteat.Count.ToString();
                bthAdd.Content = "Изменить";
            }
        }


        private void AddRecord(object sender, RoutedEventArgs e)
        {
            int countZalInt = -1;
            int countInt = -1;
            if (name.Text == "")
            {
                MessageBox.Show("Необходимо указать наименование");
                return;
            }
            if (countZal.Text == "" || int.TryParse(countZal.Text, out countZalInt) == false)
            {
                MessageBox.Show("Необходимо указать кол-вво залов");
                return;
            }
            if (Count.Text == "" || int.TryParse(Count.Text, out countInt) == false)
            {
                MessageBox.Show("Необходимо указать кол-во мест");
                return;
            }
            if(this.kinoteat == null)
            {
                KinoteatrContext newKinoteat = new KinoteatrContext(
                    0,
                    name.Text,
                    countZalInt,
                    countInt
                    );
                newKinoteat.Add();
                MessageBox.Show("Запись успешно добавлена");
                MainWindow.init.OpenPage(new Pages.Kinoteatr.Main());
            }
            else
            {
                kinoteat = new KinoteatrContext(
                    kinoteat.Id,
                    name.Text,
                    countZalInt,
                    countInt);
                kinoteat.Update();
                MessageBox.Show("Запись успешно обновлена");
                MainWindow.init.OpenPage(new Pages.Kinoteatr.Main());
            }
        }
    }
}
