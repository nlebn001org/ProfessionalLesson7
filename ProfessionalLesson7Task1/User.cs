using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson7Task1
{
    abstract class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public User(int iD, string name, string surname)
        {
            ID = iD;
            Name = name;
            Surname = surname;
        }
    }
}
