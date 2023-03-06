using SF2022User311_1_NN_LibWPF.model;
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

namespace SF2022User311_1_NN_LibWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Core db = new Core();
        public AuthorizationPage()
        {
            InitializeComponent();

        }

        private void AuthButtonClick(object sender, RoutedEventArgs e)
        {
            if (db.context.Patients.Where(x => x.LastName == LastNameTextBox.Text && x.IdPatient== PolisIdTextBox.Text).FirstOrDefault()!=null)
            {
                this.NavigationService.Navigate(new BreakPage());
            }
        }

        private void AdminButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddSchedulePage());
        }
    }
}
