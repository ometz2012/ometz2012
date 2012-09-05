using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Ometz.Representative.UI
{
     public class ApplicationServices
    {
         public void EmptyTextMark(Form f)
         {
             foreach (Control ctl in f.Controls)
             {
                 if ((ctl.GetType() == typeof(TextBox)) || (ctl.GetType() == typeof(ComboBox)))
                 {

                     if (ctl.Text.Length == 0)
                     {
                         ctl.Tag = false;
                         ctl.BackColor = Color.Red;
                     }
                     else
                     {
                         ctl.Tag = true;
                         ctl.BackColor = SystemColors.Window;
                     }
                 }

             }

         }



         public bool EmptyTextValidation(Form f)
         {

             bool check = true;

             foreach (Control ctl in f.Controls)
             {
                 if ((ctl.GetType() == typeof(TextBox)) || (ctl.GetType() == typeof(ComboBox)))
                 {

                     if (ctl.Text.ToString().Length == 0)
                     {
                         check = false;
                         break;
                     }
                 }

             }

             return check;
         }

         public static void Number_KeyPress(object sender,
                           System.Windows.Forms.KeyPressEventArgs e)
         {
             if ((e.KeyChar < 46 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 127)
                 e.Handled = true; // Remove the character
         }



    }
}
