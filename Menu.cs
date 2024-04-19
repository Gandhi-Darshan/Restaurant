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

namespace Restaurant
{
    public partial class Menu : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lab\C#\project\Restaurant\bin\Debug\Restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter adapter;

        private string SelectedImage { get; set; }

        public Menu()
        {
            InitializeComponent();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set the file dialog properties
            openFileDialog1.Title = "Browse Image";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                SelectedImage = openFileDialog1.FileName;

                // Display the selected image in the PictureBox control
                DishImageBox.Image = new Bitmap(SelectedImage);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try // For any Exception handaling 
            {
                connect.Open();
                string name = Dnametxt.Text, Type = TypeCMB.Text;
                string Category = CatCMB.Text, Ingringredient = DesTxt.Text;
                double Price = double.Parse(PriceTxt.Text);
                byte[] image = ImageStore(SelectedImage);
                int takeout;
                if (TakeOutCheck.Checked == true)
                {
                    takeout = 1;
                }
                else
                {
                    takeout = 0;
                }

                //Calling the Stored Procedures to Insert the Data in the Table
                cmd = new SqlCommand("EXEC AddDish '" + name +
                    "','" + Ingringredient + "','" + Type + "','" + Category +
                    "','" + Price + "','" + image + "','" + takeout + "'", connect);

                cmd.Parameters.AddWithValue("@Image", image);

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Dish Registered...");
                displayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Image");
            }
            finally
            {
                connect.Close();
            }
        }

        private void MenuLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.MenuLst.Rows[e.RowIndex];

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

        private void Menu_Load(object sender, EventArgs e)
        {
            displayList();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string name = Dnametxt.Text, Type = TypeCMB.Text;
                string Category = CatCMB.Text, Ingringredient = DesTxt.Text;
                double Price = double.Parse(PriceTxt.Text);
                byte[] image = ImageStore(SelectedImage);
                int takeout;
                if (TakeOutCheck.Checked == true)
                {
                    takeout = 1;
                }
                else
                {
                    takeout = 0;
                }

                // Call the stored procedure to update the dish
                cmd = new SqlCommand("EXEC UpdateDish @DishName, @Description, @DishType, @DishCategory, @DishPrise, @DishImage, @TakeOut", connect);
                cmd.Parameters.AddWithValue("@DishName", name);
                cmd.Parameters.AddWithValue("@Description", Ingringredient);
                cmd.Parameters.AddWithValue("@DishType", Type);
                cmd.Parameters.AddWithValue("@DishCategory", Category);
                cmd.Parameters.AddWithValue("@DishPrise", Price);
                cmd.Parameters.AddWithValue("@DishImage", image);
                cmd.Parameters.AddWithValue("@TakeOut", takeout);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dish Updated...");
                displayList();
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

        private void EmpBtn_Click(object sender, EventArgs e)
        {
            AdminHomePage employee = new AdminHomePage();
            employee.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string name = Dnametxt.Text, Type = TypeCMB.Text;

                // Call the stored procedure to update the dish
                cmd = new SqlCommand("EXEC RemoveDish @DishName", connect);
                cmd.Parameters.AddWithValue("@DishName", name);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Dish Removed...");
                displayList();
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

        private void tablebtn_Click(object sender, EventArgs e)
        {
            TableManagment table = new TableManagment();
            table.Show();
            this.Hide();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            ReportsDetails details = new ReportsDetails();
            details.Show();
            this.Hide();
        }

        void displayList()
        {
            clear();
            cmd = new SqlCommand("exec ListMenu", connect);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MenuLst.DataSource = dt;
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

        private byte[] ImageStore(string image)
        {
            if (string.IsNullOrEmpty(image))
            {
                MessageBox.Show("Invalid image path");
                return null;
            }

            byte[] imageData = File.ReadAllBytes(image);
            return imageData;
        }

        void clear()
        {
            Dnametxt.Clear();
            CatCMB.SelectedIndex = 0;
            TypeCMB.SelectedIndex = 0;
            DishImageBox.Image = default(Image);
            PriceTxt.Clear();
            DesTxt.Clear();
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
                    MenuLst.DataSource = dt;
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

        private void SearchCat_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    MenuLst.DataSource = dt;
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