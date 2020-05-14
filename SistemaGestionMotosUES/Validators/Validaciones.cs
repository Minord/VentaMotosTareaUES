using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SistemaGestionMotosUES.Validators
{
    public class Validaciones
    {

        public static bool isNumber(string text) {
            int num;
            return Int32.TryParse(text, out num);
        }

        public static bool isDecimal(string text) {
            decimal num;
            return Decimal.TryParse(text, out num);
        }
        public static bool isTelefone(string text)
        {
            return Regex.IsMatch(text, @"^\d{4}-\d{4}$");

        }

        public static bool isEmail(string emailAddress) {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    return true;
                }
            }
            return false;
        }  

        public static bool isEmply(string text) {
            return string.IsNullOrWhiteSpace(text);
        }

        public static bool notContainsNumbers(string text) {
            return Regex.IsMatch(text, @"^[^0-9]+$");
        }

        public static bool notNegative(string text) {
            bool isNotNegative = false;
            if (isDecimal(text)) {
                double result = Convert.ToDouble(text);
                if (result >= 0) {
                    isNotNegative = true;
                }
            }

            return isNotNegative;
        }
    }
}
