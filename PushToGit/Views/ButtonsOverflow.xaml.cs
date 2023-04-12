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

namespace PushToGit.Views
{
    /// <summary>
    /// Логика взаимодействия для ButtonsOverflow.xaml
    /// </summary>
    public partial class ButtonsOverflow : Page
    {
        public ButtonsOverflow()
        {
            InitializeComponent();
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInPage());
        }
        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WelcomePage());
        }
    }
}
