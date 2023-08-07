using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVisaProcessing
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string role;
        protected void Page_Load(object sender, EventArgs e)
        {
            role=string.Empty;
            RadioButton1.Checked=false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && role != string.Empty)
            {
                sql_ad obj = new sql_ad();
                DataSet ds = obj.GetData("select * from credentials where id = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "' and role = '" + role + "'");
                int i = ds.Tables[0].Rows.Count;
                if (i == 1)
                {
                    if (role == "admin")
                        Response.Redirect("admin.aspx");
                    else if (role == "hr")
                        Response.Redirect("hr.aspx");
                    else if (role == "emp")
                        Response.Redirect("employee.aspx");
                }
                else
                    Response.Write("Please Enter correct details");
            }
            else
                Response.Write("Please Enter all Details!");

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            role = "admin";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            role = "hr";
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            role = "emp";
        }
    }
}