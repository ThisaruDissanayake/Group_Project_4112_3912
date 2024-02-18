using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Group.Model;
using Group.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Group.ViewModel
{
    public partial class AddDoctorDetailsOtherVM:ObservableObject
    {

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string ward;

        [ObservableProperty]
        public string clinicTime;

        [ObservableProperty]
        public string username;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public int telephone;

        [ObservableProperty]
        ObservableCollection<Doctor> doctors;

        [ObservableProperty]
        public Patient selectedDoctor;

        public AddDoctorDetailsOtherVM()
        {
            doctors = new ObservableCollection<Doctor>();
        }

        [RelayCommand]
        public void Add()
        {
            Doctor doctor = new Doctor()
            {
                FirstName = Firstname,
                LastName = Lastname,
                Ward = Ward,
                ClinicTime = ClinicTime,
                UserName = Username,
                Password = Password,
                Telephone = Telephone,
                Role = "D",
            };

            if (doctor != null)
            {
                using (var db = new UserDataContext())
                {
                    db.Doctors.Add(doctor);
                    db.SaveChanges();
                }

                doctors.Add(doctor);
                LoadData();
            }
            else
            {
                MessageBox.Show("Doctor is null");
            }
        }


        [RelayCommand]
        public void LoadData()
        {
            using (var db = new UserDataContext())
            {
                var list = db.Doctors.OrderBy(p => p.Did).ToList();
                doctors.Clear();
                foreach (var doctor in list)
                {
                    doctors.Add(doctor);
                }
            }
        }
    }
}
