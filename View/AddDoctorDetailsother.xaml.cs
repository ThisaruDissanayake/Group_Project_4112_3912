using Group.Model;
using Group.ViewModel;
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

namespace Group.View
{
    /// <summary>
    /// Interaction logic for AddDoctorDetailsother.xaml
    /// </summary>
    public partial class AddDoctorDetailsother : UserControl
    {
        public List<Doctor> DBDoctors { get; private set; }
        public AddDoctorDetailsother()
        {
            DataContext = new PatientDataInputWindowVM();
            InitializeComponent();
        }

        public void Delete()
        {
            using (UserDataContext context = new UserDataContext())
            {
                Doctor selectedDoctor = ItemList.SelectedItem as Doctor;
                if (selectedDoctor != null)
                {
                    Doctor doctor = context.Doctors.Single(x => x.Did == selectedDoctor.Did);
                    context.Remove(doctor);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Select a Doctor", "Error");
                }

                DBDoctors = context.Doctors.ToList();
                ItemList.ItemsSource = DBDoctors;
            }
        }


        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ItemList.Items.Clear();

        }
    }
}
