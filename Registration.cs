using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Restaurant;

public partial class Registration : Form
{
    // Data Connection
    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
   
    public Registration()
    {
        InitializeComponent();
    }

    private void LoginLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Login login = new Login();
        login.Show();
        this.Dispose();
    }

    private void SignUpbtn_Click(object sender, EventArgs e)
    {
        if (connect.State != ConnectionState.Open)
        {
            //All the fields validation
            if (string.IsNullOrEmpty(UnameTxt.Text) && UnameTxt.Text.Length <= 10)
            {
                UnameError.SetError(UnameTxt, "UserName can't be empty or more than 10 chars");
                return;
            }else if (string.IsNullOrEmpty(FirstNametxt.Text) && FirstNametxt.Text.Length <= 10)
            {
                FnameError.SetError(FirstNametxt, "Firstname can't be empty or more than 10 chars");
                return;
            } else if(string.IsNullOrEmpty(LastNametxt.Text) && LastNametxt.Text.Length <= 10)
            {
                LnameError.SetError(LastNametxt, "Lastname can't be empty or more than 10 chars");
                return;
            } else if (!IsValidEmail(Gmailtxt.Text)){
                mailError.SetError(Gmailtxt, "email not valid");
                return;
            } else if (!IsValidPassword(Passwordtxt.Text))
            {
                PassErrror.SetError(Passwordtxt, "Invalid Password.");
                return;
            } else if (Passwordtxt.Text != ConfirmPasswordtxt.Text)
            {
                CpassError.SetError(ConfirmPasswordtxt, "Password is not Matching");
                return;
            }
            try // If all the data is valid then try will be used for any exception
            {
                connect.Open();

                // Queary for Checking if the entered user is already exist or not
                string checkUserName = "Select * from Admin WHERE UserName = '" + UnameTxt.Text.Trim() + "'";

                using (SqlCommand checkUser = new SqlCommand(checkUserName, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show(UnameTxt.Text + " is Already Exist", "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        // If the eneterd data is from new user then the Data will be stored as new user ising this queary
                        string insertData = "INSERT INTO Admin (UserName,Firstname, LastName, Gmail, Password,PhoneNumber)" +
                           "VALUES(@UserName,@FirstNametxt,@LastNametxt,@Gmailtxt,@Passwordtxt,2343234)";

                         using (SqlCommand cmd = new SqlCommand(insertData, connect))
                         {
                             cmd.Parameters.AddWithValue("@UserName", UnameTxt.Text.Trim());
                             cmd.Parameters.AddWithValue("@FirstNametxt", FirstNametxt.Text.Trim());
                             cmd.Parameters.AddWithValue("@LastNametxt", LastNametxt.Text.Trim());
                             cmd.Parameters.AddWithValue("@Gmailtxt", Gmailtxt.Text.Trim());
                             cmd.Parameters.AddWithValue("@Passwordtxt", Passwordtxt.Text.Trim());

                             cmd.ExecuteNonQuery();


                             MessageBox.Show("User Registered", "Infromation",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                             Login login = new Login();
                             login.Show();
                             this.Dispose();
                         }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error Occured" + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        
    }

    private void FirstNametxt_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(FirstNametxt.Text))
        {
           // e.Cancel = true;
            FnameError.SetError(FirstNametxt, "Field is Empty");
        }
        else
        {
           // e.Cancel= true;
            FnameError.SetError(FirstNametxt, null);
        }
    }

    private void LastNametxt_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrEmpty(LastNametxt.Text))
        {
           // e.Cancel = true;
            LnameError.SetError(LastNametxt, "Field is Empty");
        }
        else
        {
           // e.Cancel = true;
            LnameError.SetError(LastNametxt, null);
        }
    }

    //Method for Email Validation
    bool IsValidEmail(string email)
    {
        var trimmedEmail = email.Trim();

        if (trimmedEmail.EndsWith("."))
        {
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

    //Method for Phone Number and Salary Validations
    bool IsValidPassword(string password)
    {
        var hasNumber = new Regex(@"[0-9]+");
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasLowerChar = new Regex(@"[a-z]+");
        var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        var hasMinimum8Chars = new Regex(@".{8,}");

        return hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password) && hasSymbols.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
    }

    private void Registration_Load(object sender, EventArgs e)
    {

    }

    private void Cancelbtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}