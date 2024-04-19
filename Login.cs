using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Drawing;

namespace Restaurant
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");

        public static int userid;
        public Login()
        {
            InitializeComponent();
            
        }

        private void RegisterLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select IsAdmin,UserName,password,USERID from Admin where UserName=@UserName and password =@password", connect);
            
            cmd.Parameters.AddWithValue("@UserName", Unametxt.Text);
            cmd.Parameters.AddWithValue("@password", Passtxt.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.ExecuteNonQuery();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                userid = int.Parse(dt.Rows[0][3].ToString());

                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr[0].ToString() == "True")
                {
                    AdminHomePage admin = new AdminHomePage();
                    admin.Show();
                    this.Hide();
                }
                else if (sdr[0].ToString() == "False")
                {
                    CustomerHomePage customer = new CustomerHomePage();
                    customer.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please Check your user name and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }
        }
    }
}