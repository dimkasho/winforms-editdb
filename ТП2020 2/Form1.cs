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

namespace ТП2020_2
{
    public partial class Form1 : Form
    {
        SqlCon con = new SqlCon();
        public Form1()
        {
            InitializeComponent();           
        }
                
        public void ReloadForm()
        {
            SqlCommand cmd = new SqlCommand("Select * from Animal left outer join Class on Class.ClassID=animalClass", con.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            con.connection().Close();
            dataGridView1.Columns["animalID"].Visible = false;
            dataGridView1.Columns["animalClass"].Visible = false;
            dataGridView1.Columns["ClassID"].Visible = false;      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadForm();
            radioButton_nickname.Checked=true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReloadForm();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            int colIndex = dataGridView1.Columns["animalID"].Index;
            string id = dataGridView1[colIndex, rowIndex].Value.ToString();                 
            SqlCommand command = new SqlCommand();
            command.Connection = con.connection();
            command.CommandText = "delete from Animal where animalID=" + id;
            command.ExecuteNonQuery();
            con.connection().Close();
            ReloadForm();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormAdd frm = new FormAdd();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ReloadForm();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            int colIndex = dataGridView1.Columns["animalID"].Index;
            string id = dataGridView1[colIndex, rowIndex].Value.ToString();
            FormAdd frm = new FormAdd(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ReloadForm();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Animal left outer join Class on Class.ClassID=animalClass", con.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            try
            {
                if (radioButton_nickname.Checked == true)
                    table.DefaultView.RowFilter = string.Format("{0} = '{1}'", "animalNickname", textBox_search.Text);
                else if (radioButton_type.Checked == true)
                    table.DefaultView.RowFilter = string.Format("{0} = '{1}'", "animalType", textBox_search.Text);
                else if (radioButton_age.Checked == true)
                    table.DefaultView.RowFilter = string.Format("Convert({0}, 'System.String') = '{1}'", "animalAge", textBox_search.Text);
                else if (radioButton_weight.Checked == true)
                    table.DefaultView.RowFilter = string.Format("Convert({0}, 'System.String') = '{1}'", "animalWeight", textBox_search.Text);
                else if (radioButton_class.Checked == true)
                    table.DefaultView.RowFilter = string.Format("{0} = '{1}'", "className", textBox_search.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            dataGridView1.DataSource = table;
        }
    }
}
