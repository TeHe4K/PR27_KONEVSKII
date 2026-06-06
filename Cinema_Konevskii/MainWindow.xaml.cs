using Cinema_Konevskii.Classes;
using Cinema_Konevskii.Models;
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

namespace Cinema_Konevskii
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(new Pages.Kinoteatr.Main());
            init = this;
        }
        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }

        private void OpenKino(object sender, RoutedEventArgs e)
        {
            OpenPage(new Pages.Kinoteatr.Main());
        }

        private void OpenAfisha(object sender, RoutedEventArgs e)
        {
            OpenPage(new Pages.Afisha.Main());
        }
    }
}
