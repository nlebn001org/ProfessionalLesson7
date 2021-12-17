using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Reflector
{
    class Logic
    {
        public static void GetAll(Type[] types, TextBox textBox)
        {
            foreach (Type type in types)
            {
                textBox.Text += "Type:  " + type + Environment.NewLine;
                var methods = type.GetMethods();
                if (methods != null)
                {
                    foreach (var method in methods)
                    {
                        string methStr = "Method:" + method.Name + "\n";
                        var methodBody = method.GetMethodBody();
                        if (methodBody != null)
                        {
                            var byteArray = methodBody.GetILAsByteArray();
                            foreach (var b in byteArray)
                                methStr += b + ":";
                        }
                        textBox.Text += methStr + Environment.NewLine;
                    }
                }
            }
        }
        public static void GetMethods(Type[] types, TextBox textBox)
        {
            foreach (Type type in types)
            {
                MethodInfo[] methods = type.GetMethods();
                if (methods != null)
                    foreach (MethodInfo method in methods)
                        textBox.Text += "Mehtod:  " + method.Name + " in class " + type.Name + Environment.NewLine;
            }
        }
        public static void GetProperties(Type[] types, TextBox textBox)
        {
            foreach (Type type in types)
            {
                PropertyInfo[] properties = type.GetProperties();
                if (properties != null)
                    foreach (PropertyInfo property in properties)
                        textBox.Text += "Property:  " + property.Name + " in class " + type.Name + Environment.NewLine;
            }
        }
        public static void GetWithAttributes(Type[] types, TextBox textBox)
        {
            foreach (Type type in types)
            {
                object[] attributes = (object[]) type.GetCustomAttributes();
                if (attributes != null)
                    foreach (Attribute attribute in attributes)
                        textBox.Text += "Attributes:  " + attribute + " in class " + type.Name + Environment.NewLine;
            }
        }
    }
}