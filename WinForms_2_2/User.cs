using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinForms_2_2
{
    public class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Father { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        [JsonIgnore]
        public DateTime BirthDate { get; set; }
        public bool IsMale { get; set; }

        public User()
        {
            Name = "NULL";
            Surname = "NULL";
            Father = "NULL";
            Country = "NULL";
            City = "NULL";
            Phone = "NULL";
            BirthDate = new DateTime();
            IsMale = true;
        }

        public User(string name, string surname, string father, string country, string city, string phone, DateTime birthDate, bool isMale)
        {
            Name = name;
            Surname = surname;
            Father = father;
            Country = country;
            City = city;
            Phone = phone;
            BirthDate = birthDate;
            IsMale = isMale;
        }
    }
}
