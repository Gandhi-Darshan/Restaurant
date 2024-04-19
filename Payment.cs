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
    public partial class Payment : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            AmountTxt.Text = itemlist.PayableAmount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                int userid = Login.userid, dinein = CustomerHomePage.DineIN, orderid;

                if (dinein == 0)
                {
                    orderid = itemlist.orderid;
                }
                else
                {
                    orderid = BookTable.orderid;
                }

                decimal payableamount = Convert.ToDecimal(itemlist.PayableAmount);

                DateTime PaymentTime = DateTime.Now;

                double CardNum;

                DialogResult Result = MessageBox.Show("Want to pay", "Payment Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    if (double.TryParse(CardNumTxt.Text, out CardNum))
                    {
                        //Calling the Stored Procedures to Insert the Data in the Table
                        cmd = new SqlCommand("EXEC NewPayment '" + userid +
                        "','" + orderid + "','" + payableamount + "','" + PaymentTime +
                        "','" + CardNum + "'", connect);

                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("UPDATE TableDetail SET IsOccupied = 1 WHERE IsOccupied = 0 and TableID = " + BookTable.tableid, connect);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Payment Done...");

                        CustomerHomePage homePage = new CustomerHomePage();
                        homePage.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Payment Cancel...");
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Want to Cancel Payment ?", "Payment Details ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(Result == DialogResult.OK)
            {
                CustomerHomePage homePage = new CustomerHomePage();
                homePage.Show();
                this.Close();
            }
        }
    }
}