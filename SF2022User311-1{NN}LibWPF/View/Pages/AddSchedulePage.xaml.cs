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
using SF2022User311_1_NN_LibWPF.model;
using SF2023User311_1_NN_Lib;

namespace SF2022User311_1_NN_LibWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddSchedulePage.xaml
    /// </summary>
    public partial class AddSchedulePage : Page
    {
        Core db = new Core();

        Calculations calc = new Calculations();
        public AddSchedulePage()
        {
            InitializeComponent();

            FLPComboBox.ItemsSource = db.context.Doctors.ToList();
            FLPComboBox.DisplayMemberPath = "FullName";
            FLPComboBox.SelectedValuePath = "Id";
        }

        private void SheduleButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
