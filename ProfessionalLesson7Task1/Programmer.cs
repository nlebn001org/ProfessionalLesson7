using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson7Task1
{
    [AccessLevel(AccessLevelEnum.Programmer, ErrorMessage = "You dont have access.", AccessMessage = "Access")]
    class Programmer : User
    {
        public Programmer(int iD, string name, string surname) : base(iD, name, surname)
        {
        }
    }
}
