using Cinema_Konevskii.Classes;
using Cinema_Konevskii.Pages.Kinoteatr.Items;
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

namespace Cinema_Konevskii.Pages.Afisha
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        List<AfishaContext> AllKinoteaters = AfishaContext.Select();
        public Main()
        {
            InitializeComponent();
            foreach (AfishaContext items in AllKinoteaters)
            {
                parent.Children.Add(new item(items, this));
            }
        }

        private void AddRecord(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Afisha.Items.Add());
        }
    }
}
