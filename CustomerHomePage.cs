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
    public partial class CustomerHomePage : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        private List<AddToCart> cartItems = new List<AddToCart>();
        private List<decimal> totalAmounts = new List<decimal>();
        public static int DineIN = 1;

        public CustomerHomePage()
        {
            InitializeComponent();
        }

        private void DineInOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (DineInOrder.Checked)
            {
                //clear();
                cmd = new SqlCommand("exec DineInMenu", connect);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MenuItemLst.DataSource = dt;
                DineIN = 1;
            }
        }

        private void MenuItemLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.MenuItemLst.Rows[e.RowIndex];

                Dnametxt.Text = row.Cells["DishName"].Value.ToString();
                PriceTxt.Text = row.Cells["DishPrise"].Value.ToString();
                TypeCMB.Text = row.Cells["DishType"].Value.ToString();
                CatCMB.Text = row.Cells["DishCategory"].Value.ToString();
                DesTxt.Text = row.Cells["Description"].Value.ToString();

                byte[] imageData = (byte[])row.Cells["DishImage"].Value;
                if (imageData != null && imageData.Length > 0)
                {
                    Image image = ConvertArraytoImage(imageData);
                    if (image != null)
                    {
                        DishImageBox.Image = image;
                    }
                }
            }
        }
        public Image ConvertArraytoImage(byte[] image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    ms.Position = 0; // Reset the stream position to the beginning
                    return Image.FromStream(ms);
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("The image data is too large to be loaded into memory.");
                return null;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The byte array passed to ConvertArraytoImage does not represent a valid image format.");
                return null;
            }
        }

        private void TackOutRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (TackOutRadio.Checked)
            {
                //clear();
                cmd = new SqlCommand("exec DineInMenu", connect);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MenuItemLst.DataSource = dt;
                DineIN = 0;
            }
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("exec DineInMenu", connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MenuItemLst.DataSource = dt;
        }

        private void SearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchType.SelectedIndex >= 0)
            {
                try
                {
                    string type = SearchType.SelectedItem.ToString();

                    connect.Open();
                    cmd = new SqlCommand("EXEC SearchType " + type, connect);

                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    MenuItemLst.DataSource = dt;
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

        private void SearchCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchCat.SelectedIndex >= 0)
            {
                try
                {
                    string Cat = SearchCat.SelectedItem.ToString();

                    connect.Open();
                    cmd = new SqlCommand("EXEC SearchCat " + Cat, connect);

                    adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    MenuItemLst.DataSource = dt;
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

        private void QunTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(QunTxt.Text, out double qun) && double.TryParse(PriceTxt.Text, out double price))
                {
                    if (qun >= 0 && price >= 0)
                    {
                        double totalAmount = qun * price;
                        TlALbl.Text = totalAmount.ToString("C"); // Format the output string with a currency symbol

                    }
                    else
                    {
                        double totalAmount = 0;
                        TlALbl.Text = totalAmount.ToString();

                    }
                }
            }
            catch
            {
                double totalAmount = 0;
                TlALbl.Text = totalAmount.ToString();

            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(QunTxt.Text, out int qun) && decimal.TryParse(PriceTxt.Text, out decimal price))
            {
                if (qun > 0)
                {
                    cartItems.Add(new AddToCart(Dnametxt.Text, qun, price));
                    totalAmounts.Add(qun * price);
                    clear();
                }
            }
        }

        void clear()
        {
            Dnametxt.Clear();
            CatCMB.SelectedIndex = 0;
            TypeCMB.SelectedIndex = 0;
            DishImageBox.Image = default(Image);
            PriceTxt.Clear();
            DesTxt.Clear();
            TlALbl.Text = "0";
            QunTxt.Text = "1";
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            itemlist cart = new itemlist(cartItems, totalAmounts);
            cart.Show();
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