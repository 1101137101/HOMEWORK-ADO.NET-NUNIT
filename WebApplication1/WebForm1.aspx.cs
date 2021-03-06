﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MingConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "Select * From Students Where Name Like @Name";
                    cmd.Parameters.Add(new SqlParameter("@Name", "%" + txtSearch.Text + "%"));

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        gvResult.DataSource = ds;
                        gvResult.DataMember = "Table";
                        gvResult.DataBind();
                        da.Fill(ds);
                    }
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MingConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "Select * From Students";
                    cmd.Parameters.Add(new SqlParameter("@Name", "%" + txtSearch.Text + "%"));

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        DataSet ds = new DataSet();
                        ds.Clear();
                        da.Fill(ds);
                        DataTable dt = ds.Tables["Table"];
                        DataRow dr = dt.NewRow();
                        dr["Name"] = txtName.Text;
                        dr["Gender"] = txtGender.Text;
                        dr["Age"] = txtAge.Text;
                        dt.Rows.Add(dr);
                        da.Update(dt);

                        btnSearch_Click(null, null);
                    }
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MingConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "Select * From Students";

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        DataSet ds = new DataSet();
                        ds.Clear();
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        DataRow dr = dt.Select(string.Format("StudentID = {0}", txtE_ID.Text)).First();
                        dr["Name"] = txtE_Name.Text;
                        dr["Age"] = txtE_Age.Text;
                        dr["Gender"] = txtE_Gender.Text;
                        da.Update(dt);

                        btnSearch_Click(null, null);
                    }
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MingConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "Select * From Students";

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        DataSet ds = new DataSet();
                        ds.Clear();
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        DataRow dr = dt.Select(string.Format("StudentID = {0}", txtD_ID.Text)).First();
                        dr.Delete();
                        da.Update(dt);

                        btnSearch_Click(null, null);
                    }
                }
            }
        }
    }
}