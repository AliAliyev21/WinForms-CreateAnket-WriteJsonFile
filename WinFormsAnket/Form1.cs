using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


//Tapışırıq 1
//Anket formu düzəldin, həmin formu json seriallaşdırın, və hazır anketləri
//deseriallaşdırıb yenidən forma qaytarın. Anketi save edərkən , .json faylın
//adı anket müəllifinin adı ilə eyni olmalıdır.

namespace WinFormsAnket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class User
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime BirthDate { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Adress { get; set; }
            public string Nationality { get; set; }
            public string Speciality { get; set; }

            public User() { }

            public User(string name, string surname, DateTime birthDate,
                string email, string phoneNumber, string adress,
                string nationality, string speciality, string nationality1)
            {
                Name = name;
                Surname = surname;
                BirthDate = birthDate;
                Email = email;
                PhoneNumber = phoneNumber;
                Adress = adress;
                Nationality = nationality;
                Speciality = speciality;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxtb.Text;
            string surname = surnameTxtb.Text;
            DateTime birthDate = birthdateDtp.Value;
            string email = emailTxtb.Text;
            string phoneNumber = phoneMtbx.Text;
            string address = adressTxtb.Text;
            string nationality = azeRdb.Checked ? "Azerbaijani" : "English";
            string speciality = specCmb.Text;

            string message = $"Name: {name}\nSurname: {surname}\n" +
                $"Birth Date: {birthDate}\nEmail: {email}" +
                $"\nPhone Number: {phoneNumber}\nAddress: {address}" +
                $"\nNationality: {nationality}\nSpeciality: {speciality}";


            User user = new User(name, surname, birthDate, email, phoneNumber,
                address, nationality, speciality, nationality);

            string fileName = $"{name}.json";
            string existingData = File.Exists(fileName) ? File.ReadAllText(fileName) : "";
            string newJson = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText(fileName, existingData + "\n" + newJson);
            saveBtn.Text += newJson + Environment.NewLine;
 
            MessageBox.Show(message, "Anket Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"The survey was successfully saved and written to a {name}.json file","Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
