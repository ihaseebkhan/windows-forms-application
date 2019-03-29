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

namespace CRUD_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int id;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H003RR6;Initial Catalog=CRUD;Integrated Security=True");

        public void loadform()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from CRUD_table", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "CRUD_table");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CRUD_table";
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from CRUD_table where Student_id=" + id + "", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show("Record deleted!");
                loadform();
            }
            else
            { MessageBox.Show("Error!"); }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBox_sname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_fname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_regno.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox_phoneno.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox_address.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Picture from CRUD_table where Student_id='" + id + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                byte[] byteData = (byte[])reader["Picture"];
                pictureBox1.Image = ByteArrayToImage(byteData);
                reader.Close();
                con.Close();
            }
        }

        public Image ByteArrayToImage(byte[] arrayIn)
        {
            using (MemoryStream ms = new MemoryStream(arrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                con.Open();
                byte[] file_byte = ImageToByteArray(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                SqlCommand cmd = new SqlCommand("insert into CRUD_table(Student_name,Father_name,Reg_no,Phone_no,Address,Picture) values('" + textBox_sname.Text + "','" + textBox_fname.Text + "','" + textBox_regno.Text + "','" + textBox_phoneno.Text + "','" + textBox_address.Text + "',@file_byte)", con);
                cmd.Parameters.Add(new SqlParameter("@file_byte", file_byte));
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    MessageBox.Show("Record inserted!");
                    loadform();
                }
                else
                { MessageBox.Show("Error!"); }
            }
        }

        private bool isvalid()
        {
            if (textBox_sname.Text == string.Empty || textBox_fname.Text == string.Empty || textBox_regno.Text == string.Empty || textBox_phoneno.Text == string.Empty || textBox_address.Text == string.Empty || pictureBox1.Image == null)
            {
                MessageBox.Show("All Fields are required!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!textBox_regno.Text.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Registration Number must be a numeric value!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_regno.Focus();
                return false;
            }
            if (!textBox_phoneno.Text.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Phone Number must be a numeric value!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_phoneno.Focus();
                return false;
            }
            return true;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imgIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imgIn.Save(ms, imgIn.RawFormat);
                return ms.ToArray();
            }
        }



        private void button_update_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                con.Open();
                byte[] file_byte = ImageToByteArray(pictureBox1.Image);
                System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(file_byte);
                SqlCommand cmd = new SqlCommand("update CRUD_table set Student_name='" + textBox_sname.Text + "',Father_name='" + textBox_fname.Text + "',Reg_no='" + textBox_regno.Text + "',Phone_no='" + textBox_phoneno.Text + "',Address='" + textBox_address.Text + "',Picture=@file_byte where Student_id='" + id + "' ", con);
                cmd.Parameters.Add(new SqlParameter("@file_byte", file_byte));
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    MessageBox.Show("Record updated!");
                    loadform();
                }
                else
                { MessageBox.Show("Error!"); }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_sname.Clear();
            textBox_fname.Clear();
            textBox_regno.Clear();
            textBox_phoneno.Clear();
            textBox_address.Clear();
            textBox_find.Clear();
            pictureBox1.Image = null;
            loadform();
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from CRUD_table where Student_id='" + textBox_find.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "CRUD_table");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CRUD_table";
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            dial.Filter = "(*.png) | *.png";
            if (dial.ShowDialog() == DialogResult.OK)
            {
                p.Image = Image.FromFile(dial.FileName);
            }
        }
    }
}
