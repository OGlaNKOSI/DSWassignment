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

namespace WindowsFormsApp1
{
    public partial class Registrationform : Form
    {
        public Registrationform()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void regName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("please fill the required form", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-UBNQHQ1\\SQLEXPRESS;Initial Catalog=CrudeApp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                string insertQuery = "INSERT INTO CrudeApp (FirstName, Surname, IdNo, Dateofbirth, Gender, Cellnumber, HomeAddress) VALUES (@FirstName, @Surname, @IdNo, @Dateofbirth, @Gender,  @Cellnumber,  @HomeAddress)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@IdNo", txtIdno.Text);
                cmd.Parameters.AddWithValue("@Dateofbirth", txtDateOfBirth.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@Cellnumber", txtCellNo.Text);
                cmd.Parameters.AddWithValue("@HomeAddress", txtHomeAddress.Text);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("create successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("error in creation", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               
            




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }

            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UBNQHQ1\\SQLEXPRESS;Initial Catalog=CrudeApp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string readQuery = "SELECT * FROM CrudeApp";
            SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void RegSubmit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
