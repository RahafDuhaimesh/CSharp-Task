using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_7_2024_Task1
{
    public partial class DataLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = Request.QueryString["name"];
                string email = Request.QueryString["email"];
                string id = Request.QueryString["id"];
                string gender = Request.QueryString["gender"];
                string courses = Request.QueryString["courses"];
                string box = Request.QueryString["box"];

                LabelName.Text = "Name: " + name;
                LabelEmail.Text = "Email: " + email;
                LabelID.Text = "ID: " + id;
                LabelGender.Text = "Gender: " + gender;
                LabelCourses.Text = "Courses: " + courses;
                LabelDescription.Text = "Description: " + box;
            }
        }
    }
}