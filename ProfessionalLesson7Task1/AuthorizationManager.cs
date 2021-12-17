using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProfessionalLesson7Task1
{
    class AuthorizationManager
    {
        private static AuthorizationManager instance = null;

        private AuthorizationManager()
        {

        }

        public static AuthorizationManager GetAuthorizationManager()
        {
            if (instance == null)
                instance = new AuthorizationManager();
            return instance;
        }

        private bool HasAccessAttribute(User user)
        {
            return user.GetType().GetCustomAttributes(typeof(AccessLevelAttribute)).Any();
        }

        public string HasAccess(User user)
        {
            AccessLevelAttribute a = null;
            if (HasAccessAttribute(user))
            {
                a = user.GetType().GetCustomAttribute(typeof(AccessLevelAttribute)) as AccessLevelAttribute;
                if (a.Access >= AccessLevelEnum.Programmer)
                    return a.AccessMessage;
                else
                    return a.ErrorMessage;
            }
            else
                return a.ErrorMessage;
        }
    }
}