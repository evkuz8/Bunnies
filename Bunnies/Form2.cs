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
using System.IO;

namespace Bunnies
{
    public partial class Form2 : Form
    {
        string conStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = SomeDB; Integrated Security = true;";
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conStr);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            command.Connection = connection;
            string [] files = Directory.GetFiles("C:/SQL_img/");
            string articul = "";
            foreach (string imgloc in files)
            {
                //MessageBox.Show(file);
                byte[] img = null;
                FileStream fileStream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);

                img = binaryReader.ReadBytes((int)fileStream.Length);
                MessageBox.Show(img.ToString());
                articul = imgloc.Remove(imgloc.Length - 4);
                articul = articul.Substring(11);
                //MessageBox.Show(articul);

                command.Parameters.Add(new SqlParameter("@img",img));
                command.CommandText = "INSERT INTO SomeImages (SomeArticle,Image)" +
                                       " VALUES('" + articul + "',@img)";
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

            MessageBox.Show("DON3!");
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conStr);
            command.CommandText = "SELECT Image FROM SomeImages WHERE SomeArticle = '" + someArticleComboBox.Text+"'";
            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                byte[] image = (byte[])(reader[0]);
                if (image == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'someDBDataSet2.SomeImages' table. You can move, or remove it, as needed.
            this.someImagesTableAdapter2.Fill(this.someDBDataSet2.SomeImages);
            // TODO: This line of code loads data into the 'someDBDataSet.SomeImages' table. You can move, or remove it, as needed.
            this.someImagesTableAdapter1.Fill(this.someDBDataSet.SomeImages);


        }
    }
}
