using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AdminHomePage : Form
    {
        // Data Connection
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();

        public AdminHomePage()
        {
            InitializeComponent();
        }

        // Method for Email Validation
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            MessageBox.Show("Method called" + trimmedEmail);
            if (trimmedEmail.EndsWith("."))
            {
                MessageBox.Show("Method Successed");
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        // Method for Phone Number and Salary Validation
        bool IsValidNum(string num)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"[.]");

            return hasNumber.IsMatch(num) || hasSymbols.IsMatch(num);
        }

        // Method for displaying Employee Table into the GridView
        void DisplayEmployee()
        {
            // Calling the Stored Procedures to Display the Data in the Table
            cmd = new SqlCommand("exec ListEmp", connect);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmpListView.DataSource = dt;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // Add Button 
            // All the fields validation
            if (string.IsNullOrEmpty(Enametxt.Text) &&
                Enametxt.Text.Length <= 20)
            {
                EnameError.SetError(Enametxt, "Employee Name " +
                    "can't be empty or more than 20 chars");
                return;
            }
            else if (!IsValidEmail(emailtxt.Text))
            {
                EmailError.SetError(emailtxt, "email not valid");
                return;
            }
            else if (!IsValidNum(phonetxt.Text)
                && phonetxt.Text.Length == 10)
            {
                NumError.SetError(phonetxt, "Invalid Phone Num.");
                return;
            }
            else if (!IsValidNum(salarytxt.Text)
                && Enametxt.Text.Length <= 7)
            {
                SalaryError.SetError(salarytxt, "Invalid Salary Amount.");
                return;
            }
            else // If all the feilds are valid connection will be open
            {
                try // For any Exception handaling 
                {
                    connect.Open();
                    string empname = Enametxt.Text, Mail = emailtxt.Text;
                    string Role = rolecmboc.Text;
                    decimal PhoneNumber = decimal.Parse(phonetxt.Text);
                    double Salary = double.Parse(salarytxt.Text);

                    // Calling the Stored Procedures to Insert the Data in the Table
                    cmd = new SqlCommand("EXEC InsertEmp '" + empname +
                        "','" + Mail + "','" + PhoneNumber + "','" + Role +
                        "','" + Salary + "'", connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Registered...");
                    DisplayEmployee();
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
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            DisplayEmployee();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // Update Button
            // All the fields validation
            if (string.IsNullOrEmpty(Enametxt.Text) &&
                Enametxt.Text.Length <= 20)
            {
                EnameError.SetError(Enametxt, "Employee Name " +
                    "can't be empty or more than 20 chars");
                return;
            }
            else if (!IsValidEmail(emailtxt.Text))
            {
                EmailError.SetError(emailtxt, "email not valid");
                return;
            }
            else if (!IsValidNum(phonetxt.Text)
                && phonetxt.Text.Length == 10)
            {
                NumError.SetError(phonetxt, "Invalid Phone Num.");
                return;
            }
            else if (!IsValidNum(salarytxt.Text)
                && Enametxt.Text.Length <= 7)
            {
                SalaryError.SetError(salarytxt, "Invalid Salary Amount.");
                return;
            }
            else // If all the feilds are valid connection will be open
            {
                try // For any Exception handaling 
                {
                    connect.Open();
                    string empname = Enametxt.Text, Mail = emailtxt.Text;
                    string Role = rolecmboc.Text;
                    decimal PhoneNumber = decimal.Parse(phonetxt.Text);
                    double Salary = double.Parse(salarytxt.Text);

                    // Calling the Stored Procedures to Update the Data in the Table
                    cmd = new SqlCommand("EXEC UpdateEmp '" + empname +
                        "','" + Mail + "','" + PhoneNumber + "','" + Role +
                        "','" + Salary + "'", connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated...");
                    DisplayEmployee();
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
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            // Remove Button
            // For the Conformation of Delete
            if (MessageBox.Show("Do you really want to remove this Emoplyee", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try // For any Exception handaling 
                {
                    connect.Open();
                    string Mail = emailtxt.Text;

                    // Calling the Stored Procedures to Remove the Data from the Table
                    cmd = new SqlCommand("EXEC RemoveEmp '" + Mail + "'", connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Removed...");
                    DisplayEmployee();
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
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try // For any Exception handaling 
            {
                connect.Open();
                string Role = rolecmboc.Text;

                // Calling the Stored Procedures to Remove the Data from the Table
                cmd = new SqlCommand("EXEC SearchEmp '" + Role + "'", connect);
                cmd.ExecuteNonQuery();

                // It will search the result the fatch the data
                sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                EmpListView.DataSource = dt;
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

        private void EmpListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmpListView.Rows[e.RowIndex];

                Enametxt.Text = row.Cells["EmployeeName"].Value.ToString();
                emailtxt.Text = row.Cells["Email"].Value.ToString();
                phonetxt.Text = row.Cells["PhoneNum"].Value.ToString();
                rolecmboc.Text = row.Cells["Role"].Value.ToString();
                salarytxt.Text = row.Cells["Salary"].Value.ToString();
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Menu menupage = new Menu();
            menupage.Show();
            this.Dispose();
        }

        private void tablebtn_Click(object sender, EventArgs e)
        {
            TableManagment table = new TableManagment();
            table.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}