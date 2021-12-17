using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson7Task1
{
    [AccessLevel(AccessLevelEnum.Worker, ErrorMessage = "You dont have access.", AccessMessage = "Access")]
    class Worker : User
    {
        public Worker(int iD, string name, string surname) : base(iD, name, surname)
        {
        }
    }
}
