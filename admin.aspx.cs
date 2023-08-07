using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVisaProcessing
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void update_hr_table()
        {
            sql_ad obj = new sql_ad();
            DataSet ds = obj.GetData("select * from detail_hr");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void update_emp_table()
        {
            sql_ad obj = new sql_ad();
            DataSet ds = obj.GetData("select * from detail_emp");
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }
        protected void update_app_table()
        {
            sql_ad obj = new sql_ad();
            DataSet ds = obj.GetData("select * from detail_application");
            GridView3.DataSource = ds.Tables[0];
            GridView3.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            update_hr_table();
            update_emp_table();
            update_app_table();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sql_con obj = new sql_con();
            int i = obj.GetData("exec insert_hr_detail '"+ TextBox1.Text+"', " + "'" + TextBox2.Text + "', " + "'" + TextBox3.Text + "', " + "'" + TextBox4.Text + "', " + "'" + TextBox5.Text + "', " + "'" + TextBox6.Text + "' ");
            
             Response.Write(i + " Records inserted!");

             update_hr_table();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.update_hr_table();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex=-1;
            this.update_hr_table();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            sql_con obj = new sql_con();
            int i=obj.GetData("update detail_hr set name='" + ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim() +"', email='"+ ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim() + "', phone='"+ ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.Trim() + "',address='"+ ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text.Trim() + "' where id='"+ ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.Trim() + "'");
            Response.Write(i+" Rows updated!");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            sql_con obj = new sql_con();
            int i = obj.GetData("exec insert_emp_detail '" + TextBox7.Text + "', " + "'" + TextBox8.Text + "', " + "'" + TextBox9.Text + "', " + "'" + TextBox10.Text + "', " + "'" + TextBox11.Text + "', " + "'" + TextBox12.Text + "'");

             Response.Write(i + " Records inserted!");


             update_emp_table();
        }

        // Gridview 2
        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            this.update_emp_table();

        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            this.update_emp_table();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            sql_con obj = new sql_con();
            int i = obj.GetData("update detail_emp set name='" + ((TextBox)GridView2.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim() + "', email='" + ((TextBox)GridView2.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim() + "', phone='" + ((TextBox)GridView2.Rows[e.RowIndex].Cells[4].Controls[0]).Text.Trim() + "',address='" + ((TextBox)GridView2.Rows[e.RowIndex].Cells[5].Controls[0]).Text.Trim() + "' where id='" + ((TextBox)GridView2.Rows[e.RowIndex].Cells[1].Controls[0]).Text.Trim() + "'");
            Response.Write(i + " Rows updated!");
        }


        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            sql_con obj = new sql_con();
            int i = obj.GetData("insert into detail_application values("+ TextBox13.Text+", '"+ TextBox14.Text+"', '"+TextBox15.Text+"',  '"+DropDownList1.SelectedValue+"','"+DropDownList2.SelectedValue+"','"+DropDownList3.SelectedValue+"')");
            Response.Write(i + " Rows updated!");
            update_app_table();
        }
    }
}