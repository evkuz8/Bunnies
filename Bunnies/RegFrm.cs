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
    public partial class RegFrm : Form
    {
        public RegFrm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string conStr = @"Data Source = .\SQLEXPRESS; Initial Catalog = SomeDB; Integrated Security = true;";
                if (loginTxt.Text.Length>0&& passwordTxt.Text.Length >0 && fNameTxt.Text.Length>0 && lNameTxt.Text.Length>0)
                {
                    string cmdStr = "INSERT INTO Users (Login,Password,Fname,Lname,IDRole)" +
                                " Values('" + loginTxt.Text + "', '" + passwordTxt.Text + "', '" + 
                                fNameTxt.Text + "', '" + lNameTxt.Text + "', 2); ";

                    SqlConnection connection = new SqlConnection(conStr);
                    SqlCommand command = new SqlCommand(cmdStr, connection);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("U'RE SIGNED UP!");
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("PLS FILL THE FIELDS!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, придумайте другой логин!");
                //throw;
            }
            
        }
    }
}
