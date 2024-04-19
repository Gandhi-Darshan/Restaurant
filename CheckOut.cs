using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class itemlist : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        private List<AddToCart> cartItems;
        private List<decimal> totalAmounts;
        public int dinein;
        public static double PayableAmount;
        public static int orderid;

        public itemlist(List<AddToCart> cartItems, List<decimal> totalAmounts)
        {
            InitializeComponent();
            this.cartItems = cartItems;
            this.totalAmounts = totalAmounts;
            dinein = CustomerHomePage.DineIN;
            DisplayOrderList();
            DisplayFinalAmount();
        }

        private void DisplayOrderList()
        {
            OrderList.Items.Clear();
            for (int i = 0; i < cartItems.Count; i++)
            {
                OrderList.Items.Add($"{cartItems[i]} - Total Amount: {totalAmounts[i]:C}");
            }
        }

        private void DisplayFinalAmount()
        {
            decimal subtotal = 0;
            foreach (decimal amount in totalAmounts)
            {
                subtotal += amount;
            }
            if (dinein == 1)
            {
                decimal tax = subtotal * 0.13m; // Calculate 13% tax
                decimal finalAmount = subtotal + tax; // Add tax to subtotal
                DIDlbl.Visible = true;
                DiDAmountlbl.Visible = true;
                finalAmount *= 0.9m;
                TlALbl.Text = subtotal.ToString();
                FinalAmount.Text = finalAmount.ToString();
                PayableAmount = Convert.ToDouble(finalAmount);
            }
            else
            {
                decimal tax = subtotal * 0.13m; // Calculate 13% tax
                decimal finalAmount = subtotal + tax; // Add tax to subtotal
                DIDlbl.Visible = false;
                DiDAmountlbl.Visible = false;
                TlALbl.Text = subtotal.ToString();
                FinalAmount.Text = finalAmount.ToString();
                PayableAmount = Convert.ToDouble(finalAmount);
            }
        }
        private void itemlist_Load(object sender, EventArgs e)
        {
            if (dinein == 1)
            {
                PaymentBtn.Text = "Book Table";
            }
            else
            {
                PaymentBtn.Text = "Payment";
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            if(dinein == 1)
            {
                BookTable table = new BookTable();
                table.Show();
                this.Close();
            }
            else
            {
                connect.Open();
                int UserId = Login.userid, DineIn = CustomerHomePage.DineIN;

                //Calling the Stored Procedures to Insert the Data in the Table
                cmd = new SqlCommand("EXEC PlaceTakeOutOrder '" + UserId +
                    "','" + DineIn + "'", connect);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order has been Placed...");

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
        }
    }
}
