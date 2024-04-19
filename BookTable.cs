using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class BookTable : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public static int orderid;
        public static int tableid;
        public BookTable()
        {
            InitializeComponent();
        }

        private void BookTable_Load(object sender, EventArgs e)
        {
            displayList();
        }

        void displayList()
        {
            cmd = new SqlCommand("exec TableList", connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            TableList.DataSource = dt;
        }

        private void TableList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TableList.Rows[e.RowIndex];

                TIDTxt.Text = row.Cells["TableID"].Value.ToString();
                CapTxt.Text = row.Cells["Capecity"].Value.ToString();
            }
        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchBox.SelectedIndex >= 0)
            {
                try
                {
                    string capacity = SearchBox.SelectedItem.ToString();

                    connect.Open();
                    cmd = new SqlCommand("EXEC SearchTableList " + capacity, connect);

                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    TableList.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("No Available Tabel");
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            try // For any Exception handaling 
            {
                connect.Open();
                int UserId = Login.userid, DineIn = CustomerHomePage.DineIN, TableID = Convert.ToInt32(TIDTxt.Text);

                //Calling the Stored Procedures to Insert the Data in the Table
                cmd = new SqlCommand("EXEC PlaceDineInOrder '" + UserId +
                    "','" + DineIn + "','" + TableID + "'", connect);

                tableid = TableID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order has been Placed...");

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT MAX(OrderID) FROM Orders WHERE UserID = " + UserId, connect);

                adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                cmd.ExecuteNonQuery();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {

                    orderid = int.Parse(table.Rows[0][0].ToString());
                }

                Payment payment = new Payment();
                payment.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Available Tabel");
            }
            finally
            {
                connect.Close();
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
