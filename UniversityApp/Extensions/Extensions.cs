using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using UniversityApp.Model;

namespace UniversityApp.Extensions
{

    public static class Extensions
    {

        public static string HashPassword(string password)
        {
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashedArray = new SHA256Managed().ComputeHash(byteArray);
            string hashedPassword = ASCIIEncoding.ASCII.GetString(hashedArray);
            //string name = "Aqil";
            //char[] arr =  name.ParseString();
            return hashedPassword;
        }
        public static void InputClearer(this Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
       
        public static string IdentifierGenerator(this string str)
        {
            return new string('0', 6 - str.Length) + str;
        }
        public static string IdentifierGeneratorForTeachers(this string str)
        {
            return new string('0', 4 - str.Length) + str;
        }
        

      
    }
}
