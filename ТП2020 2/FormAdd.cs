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
    public partial class FormAdd : Form
    {
		SqlCon con = new SqlCon();
        public string ID;
        public FormAdd(string id ="0")
        {            
            InitializeComponent();
            ID = id;
            comboBox_class.Items.AddRange(new string[] { "Млекопитающее", "Рыба", "Птица", "Пресмыкающееся", "Рептилия" });
            if (ID != "0")
            {                            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.connection();
                cmd.CommandText = "select * from Animal where animalID=" + id;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();                
                switch (reader["animalClass"].ToString())
                {
                    case "1":
                        comboBox_class.SelectedItem = "Млекопитающее";
                        break;
                    case "2":
                        comboBox_class.SelectedItem = "Рыба";
                        break;
                    case "3":
                        comboBox_class.SelectedItem = "Птица";
                        break;
                    case "4":
                        comboBox_class.SelectedItem = "Пресмыкающееся";
                        break;
                    case "5":
                        comboBox_class.SelectedItem = "Рептилия";
                        break;
                }
                textBox_nickname.Text = reader["animalNickname"].ToString();
                textBox_type.Text = reader["animalType"].ToString();
                textBox_age.Text = reader["animalAge"].ToString();
                textBox_weight.Text = reader["animalWeight"].ToString();                
                reader.Close();
                con.connection().Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.connection();
            if (ID == "0") //Добавить
            {
                cmd.CommandText="insert into Animal (animalClass,animalNickname,animalType,animalAge,animalWeight) values (@t1,@t2,@t3,@t4,@t5)";
                switch (comboBox_class.Text)
                {
                    case "Млекопитающее":
                        cmd.Parameters.AddWithValue("@t1", 1);
                        break;
                    case "Рыба":
                        cmd.Parameters.AddWithValue("@t1", 2);
                        break;
                    case "Птица":
                        cmd.Parameters.AddWithValue("@t1", 3);
                        break;
                    case "Пресмыкающееся":
                        cmd.Parameters.AddWithValue("@t1", 4);
                        break;
                    case "Рептилия":
                        cmd.Parameters.AddWithValue("@t1", 5);
                        break;
                }
                cmd.Parameters.AddWithValue("@t2", textBox_nickname.Text);
                cmd.Parameters.AddWithValue("@t3", textBox_type.Text);
                cmd.Parameters.AddWithValue("@t4", textBox_age.Text);
                cmd.Parameters.AddWithValue("@t5", textBox_weight.Text);
            }
            else //Изменить
            {
                cmd.CommandText = "update Animal set animalClass=@t1,animalNickname=@t2,animalType=@t3,animalAge=@t4,animalWeight=@t5 where animalID=@id";
                switch (comboBox_class.Text)
                {
                    case "Млекопитающее":
                        cmd.Parameters.AddWithValue("@t1", 1);
                        break;
                    case "Рыба":
                        cmd.Parameters.AddWithValue("@t1", 2);
                        break;
                    case "Птица":
                        cmd.Parameters.AddWithValue("@t1", 3);
                        break;
                    case "Пресмыкающееся":
                        cmd.Parameters.AddWithValue("@t1", 4);
                        break;
                    case "Рептилия":
                        cmd.Parameters.AddWithValue("@t1", 5);
                        break;
                }
                cmd.Parameters.AddWithValue("@t2", textBox_nickname.Text);
                cmd.Parameters.AddWithValue("@t3", textBox_type.Text);
                cmd.Parameters.AddWithValue("@t4", textBox_age.Text);
                cmd.Parameters.AddWithValue("@t5", textBox_weight.Text);
                cmd.Parameters.AddWithValue("@id", ID);
            }
			cmd.ExecuteNonQuery();
			con.connection().Close();			
			this.Close();
		}

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
