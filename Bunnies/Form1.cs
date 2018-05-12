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
namespace Bunnies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = SomeDB; Integrated Security = true;";
            string cmdStr = "SELECT * FROM Users WHERE Login = '" + loginTxt.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdStr, conStr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            try
            {
                if (passwordTxt.Text == table.Rows[0]["Password"].ToString())
                {
                    AdminFrm adminFrm = new AdminFrm();
                    adminFrm.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Такой связки логин-пароль - не найдено!");
                
            }
            
            
            
            
            
            
            
            
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            RegFrm regFrm = new RegFrm();
            regFrm.Show();
            this.Hide();
        }
    }
}
