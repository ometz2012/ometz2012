using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ometz.RFQ.BLL
{
   //Class for performing all kinds of user data input validation
    public static class Utility
    {

        public static bool InsertNewDataValidation(string userInput)
        {
            if (userInput != "")
            {
                return true;
            }
            return false;
        }
        //public static bool InsertNewDataValidation(string userInput, string messageText)
        //{
        //    if (userInput != "" && userInput != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //     //   MessageBox.Show("You should Enter a valid " + messageText);
        //        return false;
        //    }

       // }
        // Method checks if the integer number (from user's input) is correct
        public static bool InputQuantityValidation(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                if (number <= 0)
                {
                   // MessageBox.Show("The Product Quantity should be more than 0");
                    result = false;
                }

            }
            else
            {
                if (value == null) value = "";
               // MessageBox.Show("You should enter a valid number");
                return result;
            }
            return result;
        }
        // Method checks if the decimal number (from user's input) is correct
        public static bool InputAmountValidation(string value)
        {
           decimal number;
            bool result = decimal.TryParse(value, out number);
            if (result)
            {
                if (number <= 0)
                {
                    // MessageBox.Show("The Product Quantity should be more than 0");
                    result = false;
                }

            }
            else
            {
                if (value == null) value = "";
                // MessageBox.Show("You should enter a valid number");
                return result;
            }
            return result;
        }
     
    }
}
    

