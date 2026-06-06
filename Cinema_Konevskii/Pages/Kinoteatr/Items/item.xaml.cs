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
    /// Логика взаимодействия для item.xaml
    /// </summary>
    public partial class item : UserControl
    {
        KinoteatrContext Kinoteatr;
        Main main;
        public item(KinoteatrContext kinoteatr, Main main)
        {
            InitializeComponent();

            name.Text = kinoteatr.Name;
            countZal.Text = kinoteatr.CountZal.ToString();
            Count.Text = kinoteatr.Count.ToString();
            this.Kinoteatr = kinoteatr;
            this.main = main;
        }

        public item(AfishaContext items, Afisha.Main main1)
        {
        }

        private void EditRecord(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Kinoteatr.Items.Add(Kinoteatr));
        }

        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            Kinoteatr.Delete();
            main.parent.Children.Remove(this);
        }
    }
}
