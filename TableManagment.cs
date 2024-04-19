using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurant
{
    public partial class TableManagment : Form
    {
        // Data Connection
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        public TableManagment()
        {
            InitializeComponent();
        }

        private void TableManagment_Load(object sender, EventArgs e)
        {
            DisplayList();

            connect.Open();

            List<int> EMPID = new List<int>();

            cmd = new SqlCommand("exec GetEmployeeID", connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    decimal empidDecimal = reader.GetDecimal(0);
                    int empid = (int)empidDecimal;
                    EMPID.Add(empid);
                }
            }

            EIDCmb.DataSource = EMPID;
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            AdminHomePage homePage = new AdminHomePage();
            homePage.Show();
            this.Close();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            ReportsDetails reports = new ReportsDetails();
            reports.Show();
            this.Close();
        }

        private void TableLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TableLst.Rows[e.RowIndex];

                TableIDTxt.Text = row.Cells["TableID"].Value.ToString();
                CapcityTxt.Text = row.Cells["Capecity"].Value.ToString();
                EIDCmb.Text = row.Cells["EmployeeID"].Value.ToString();
            }
        }

        private void EIDCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int EID = Convert.ToInt32(EIDCmb.Text);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }

            cmd = new SqlCommand("exec EmployeeView " + EID, connect);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ENameTxt.Text = reader["EmployeeName"].ToString();
                    SalaryTxt.Text = reader["Salary"].ToString();
                }
            }
        }

        void clear()
        {
            TableIDTxt.Clear();
            SearchCap.SelectedIndex = 0;
            CapcityTxt.Clear();
        }
        void DisplayList()
        {
            clear();
            cmd = new SqlCommand("exec ListTable", connect);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TableLst.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try // For any Exception handaling 
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                int Capacity = Convert.ToInt32(CapcityTxt.Text);

                int IsOccupied;
                if (OccupiedCheck.Checked = true)
                {
                    IsOccupied = 0;
                }
                else
                {
                    IsOccupied = 1;
                }

                int EmpID = Convert.ToInt32(EIDCmb.Text);

                //Calling the Stored Procedures to Insert the Data in the Table
                cmd = new SqlCommand("EXEC InsertTable '" + Capacity +
                    "','" + IsOccupied + "','" + EmpID + "'", connect);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Table has been Added...");
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error Occured" + ex,
                    "Connection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                int tableid = Convert.ToInt32(TableIDTxt.Text), Capacity = Convert.ToInt32(CapcityTxt.Text);

                int IsOccupied;
                if (OccupiedCheck.Checked = true)
                {
                    IsOccupied = 0;
                }
                else
                {
                    IsOccupied = 1;
                }

                int EmpID = Convert.ToInt32(EIDCmb.Text);

                // Call the stored procedure to update the dish
                cmd = new SqlCommand("EXEC UpdateTable '" + tableid + "','" + Capacity +
                    "','" + IsOccupied + "','" + EmpID + "'", connect);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Table Updated...");
                DisplayList();
            }
            catch
            {
                MessageBox.Show("Can not Find Table");
            }
            finally
            {
                connect.Close();
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                int tableid = Convert.ToInt32(TableIDTxt.Text);

                // Call the stored procedure to update the dish
                cmd = new SqlCommand("EXEC RemoveTable " + tableid, connect);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Table Removed...");
                DisplayList();
            }
            catch
            {
                MessageBox.Show("Can not find Table");
            }
            finally
            {
                connect.Close();
            }
        }

        private void SearchCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchCap.SelectedIndex >= 0)
            {
                try
                {
                    int cap = Convert.ToInt32(SearchCap.SelectedItem);

                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    cmd = new SqlCommand("EXEC SearchCap " + cap, connect);

                    sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    TableLst.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Can not find Dish");
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}