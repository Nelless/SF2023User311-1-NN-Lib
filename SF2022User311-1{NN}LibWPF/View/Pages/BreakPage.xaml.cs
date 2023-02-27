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

namespace SF2022User311_1_NN_LibWPF.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для BreakPage.xaml
    /// </summary>
    public partial class BreakPage : Page
    {
        Core db = new Core();
        int eventTypes;

        public BreakPage()
        {
            InitializeComponent();

            EventComboBox.ItemsSource = db.context.TypesEvent.ToList();
            EventComboBox.DisplayMemberPath = "TypeTitle";
            EventComboBox.SelectedValuePath = "IdType";
        }

        private void SchaduleButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Appointments appoint = new Appointments()
                {
                    TypeEventId = eventTypes,
                    DoctorScheduleId = 1,
                    StartTime = TimeSpan.Parse(TimeTextBox.Text),
                    EndTime = TimeSpan.Parse(TimeTextBox.Text) + new TimeSpan(0, Convert.ToInt32(DurationTextBox.Text), 0),
                };
                db.context.Appointments.Add(appoint);
                if (db.context.SaveChanges() > 0)
                {
                    MessageBox.Show(
                        "Добавление выполнено успешно!",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show(
                        "Критический сбой в работе приложения:",
                        "Предупреждение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);

            }
        }


        private void EventComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             eventTypes = Convert.ToInt32(EventComboBox.SelectedValue);
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSchedulePage());
        }
    }
}
