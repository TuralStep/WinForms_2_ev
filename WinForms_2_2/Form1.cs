using System;
using System.Xml.Serialization;

namespace WinForms_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DateTime dateOnly = date_dtp.Value;
            User user = new()
            {
                Name = name_txt.Text,
                Surname = surname_txt.Text,
                Father = father_txt.Text,
                Country = country_txt.Text,
                City = city_txt.Text,
                Phone = phone_txt.Text,
                BirthDate = dateOnly,
                IsMale = male_rb.Checked
            };
            string path = Environment.GetFolderPath(0) + "\\" + user.Name + ".json";
            MessageBox.Show(path);

            using FileStream file = new(path, FileMode.CreateNew);
            file.Dispose();

            var jsonString = System.Text.Json.JsonSerializer.Serialize(user);
            File.WriteAllText(path, jsonString);

            ClearTextBoxes();
        }

        private void load_Click(object sender, EventArgs e)
        {
            string name = loadName_txt.Text;
            User user = null;
            string path = name + ".json";

            try
            {
                using FileStream yoxla = new FileStream(path, FileMode.Open);
            }
            catch (Exception)
            {
                MessageBox.Show($"No user with name {name}...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
                loadName_txt.Text = "";
                return;
                throw;
            }
            using FileStream fs = new FileStream(path, FileMode.Open);
            user = System.Text.Json.JsonSerializer.Deserialize<User>(fs);


            if (user != null)
            {
                name_txt.Text = user.Name;
                surname_txt.Text = user.Surname;
                father_txt.Text = user.Father;
                country_txt.Text = user.Country;
                city_txt.Text = user.City;
                phone_txt.Text = user.Phone;
                male_rb.Checked = user.IsMale;
                female_rb.Checked = !user.IsMale;
            }

        }

        private void ClearTextBoxes()
        {
            name_txt.Text = "";
            surname_txt.Text = "";
            father_txt.Text = "";
            country_txt.Text = "";
            city_txt.Text = "";
            phone_txt.Text = "";
        }

    }
}