using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BUS_QLSV
{
    public class BUS_Xuly
    {
        public void ClearAllTextBox(Control ctr)//ctr truyền vào 1 form, hoặc 1 usercontrol, hoặc 1 groupbox chứa các textbox......
        {
            if (ctr.GetType() == typeof(TextBox))
            {
                ctr.Text = "";

            }
            else if (ctr.GetType() == typeof(NumericUpDown))
            {
                ctr.Text = "0";
            }
            else if (ctr.GetType() == typeof(DateTimePicker))
            {
                ctr.Text = DateTime.Now.ToString();
            }
            //Duyệt tất cả các textbox trên form
            foreach (Control iCtr in ctr.Controls)
            {
                ClearAllTextBox(iCtr);
            }
        }

        public void AddControl(Panel pn, UserControl uc)
        {
            pn.BackgroundImage = null;
            pn.Controls.Clear();
            pn.Controls.Add(uc);
        }
    }
}
