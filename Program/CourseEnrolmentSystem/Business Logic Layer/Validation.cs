using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Business_Layer
 
    public class Validation
    {
        public static bool isNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isEmailValid(string email)
        {
            bool isValid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }
        public static bool isInt(string value)
        {
            bool isValid = false;
            try
            {
                int testInteger = Int32.Parse(value);
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
