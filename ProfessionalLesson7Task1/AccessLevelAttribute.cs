using System;
using System.Collections.Generic;
using System.Text;

namespace ProfessionalLesson7Task1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    class AccessLevelAttribute : Attribute
    {
        public AccessLevelEnum Access { get; set; }
        public string ErrorMessage { get; set; }
        public string AccessMessage { get; set; }
        public AccessLevelAttribute(AccessLevelEnum access)
        {
            Access = access;
        }
    }
}
