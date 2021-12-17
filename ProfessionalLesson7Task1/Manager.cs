using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson7Task1
{
    [AccessLevel(AccessLevelEnum.Manager, ErrorMessage = "You dont have access.", AccessMessage = "Access")]
    class Manager : User
    {
        public Manager(int iD, string name, string surname) : base(iD, name, surname)
        {
        }
    }
}
