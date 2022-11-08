using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentDisconnectedArchiteture
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommandBuilder scb;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con= new SqlConnection(constr);
        }

        public DataSet GetAllStudent()
        {
            da=new SqlDataAdapter("Select * from Student",con);
            da.MissingSchemaAction=MissingSchemaAction.AddWithKey;
            scb=new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds, "student");
            return ds;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["student"].NewRow();
                row["sname"]=txtName.Text;
                row["sub1"] = txtSub1.Text;
                row["sub2"] = txtSub2.Text;
                row["sub3"] = txtSub3.Text;
                row["percentage"] = txtPercentage.Text;
                ds.Tables["student"].Rows.Add(row);
                int result = da.Update(ds.Tables["student"]);
                if(result==1)
                {
                    MessageBox.Show("Record Inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["student"].Rows.Find(txtRollno.Text);
                if(row != null)
                {
                    row["name"] = txtName.Text;
                    row["sub1"] = txtSub1.Text;
                    row["sub2"]=txtSub2.Text;
                    row["sub3"] = txtSub3.Text;
                    row["percentage"]= txtPercentage.Text;
                    int result = da.Update(ds.Tables["student"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["student"].Rows.Find(txtRollno.Text);
                if(row!=null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["student"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["student"].Rows.Find(txtRollno.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtSub1.Text = row["sub1"].ToString();
                    txtSub2.Text = row["sub2"].ToString();
                    txtSub3.Text = row["sub3"].ToString();
                    txtPercentage.Text = row["percentage"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                dataGridView1.DataSource = ds.Tables["student"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
