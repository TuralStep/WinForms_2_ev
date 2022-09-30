using System;
using System.Text.Json;
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
                Name = name_txt.Text.removeStart(),
                Surname = surname_txt.Text.removeStart(),
                Father = father_txt.Text.removeStart(),
                Country = country_txt.Text.removeStart(),
                City = city_txt.Text.removeStart(),
                Phone = phone_txt.Text,//.removeStart(),
                BirthDate = dateOnly,
                IsMale = male_rb.Checked
            };
            string path = user.Name + ".json";

            File.WriteAllText(path, JsonSerializer.Serialize(user));

            MessageBox.Show("Succesfully saved user...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void load_Click(object sender, EventArgs e)
        {
            string name = loadName_txt.Text.removeStart();
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
            user = JsonSerializer.Deserialize<User>(File.ReadAllText(path))!;


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