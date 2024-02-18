using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Group.Model
{
    public class Doctor
    {
        [Key]
        public int Did { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ward { get; set; }
        public string ClinicTime { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Telephone { get; set; }



        public Doctor(string fname,string lname,string name, string password, int tele,string ward,string Ctime)
        {
            FirstName = fname;
            LastName = lname;
            UserName = name;
            Password = password;
            Role = "D";
            Telephone = tele;
            Ward = ward;
            ClinicTime = Ctime;
        }
        public Doctor()
        {
            
        }
    }
}
