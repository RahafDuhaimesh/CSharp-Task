using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_7_2024_Task1
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Text1.Text;
            string email = Text2.Text;
            string id = Text3.Text;
            string gender = RadioButton1.Checked ? "Female" : (RadioButton2.Checked ? "Male" : "");
            string url = $"SecondPage.aspx?name={name}&email={email}&id={id}&gender={gender}";
            string courses = string.Empty;
            if (CheckBox1.Checked)
            {
                courses += "C ";
            }
            if (CheckBox3.Checked)
            {
                courses += "C++ ";
            }
            if (CheckBox2.Checked)
            {
                courses += "C# ";
            }


            string box = TextBox1.Text;
            string x = $"DataLoginPage.aspx?name={name}&email={email}&id={id}&gender={gender}&courses={courses}&box={box}";
            Response.Redirect(x);

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}