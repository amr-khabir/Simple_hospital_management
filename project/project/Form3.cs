using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text=="")
            {
                MessageBox.Show("يرجى ملئ المربعت الفارفة");
            }
            else
            {
                    StreamWriter ski = new StreamWriter("data.txt قسم الجراحة", true);
                    string skill = textBox1.Text + ";" + textBox2.Text + ";" + comboBox1.Text + ";" + comboBox2.Text;
                    ski.WriteLine(skill);
                    ski.Close();
                    MessageBox.Show("تم اضافة المعلومات");
                    foreach (Control s in Controls)
                        if (s is TextBox)
                            s.Text = "";
                    textBox1.Focus();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    StreamReader sk = new StreamReader("data.txt قسم الجراحة");
                    string skill = "";
                    bool found = false;
                    do
                    {
                        skill = sk.ReadLine();
                        if (skill != null)
                        {
                            string[] arr = skill.Split(';');
                            if (arr[0] == textBox1.Text)
                            {
                                textBox1.Text = arr[0];
                                textBox2.Text = arr[1];
                                comboBox1.Text = arr[2];
                                comboBox2.Text = arr[3];
                                found = true;
                                MessageBox.Show("ان الأسم المطلوب موجود");
                                break;
                            }
                        }
                    }
                    while (skill != null);
                    sk.Close();
                    if (!found)
                    {
                        MessageBox.Show("ان الاسم غير موجود");
                        textBox1.Focus();
                        textBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("من فضلك املئ المربعات الفرغة");
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formshow = new Form();
            TextBox txtshow = new TextBox();
            formshow.StartPosition = FormStartPosition.CenterScreen;
            formshow.Font = this.Font;
            formshow.Icon = this.Icon;
            formshow.Size = this.Size;
            formshow.Text = "كل المعلومات";
            txtshow.Multiline = true;
            txtshow.Dock = DockStyle.Fill;
            formshow.Controls.Add(txtshow);
            try
            {
                StreamReader ski = new StreamReader("data.txt قسم الجراحة");
                string skill = ski.ReadToEnd();
                ski.Close();
                txtshow.Text = skill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            formshow.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                textBox2.Focus();
                textBox2.Select();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("yyyy/MM/dd");

            textBox1.Focus();
            textBox1.Select();
            textBox1.SelectAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                MessageBox.Show("يرجى ملئ المربع الثالث");

            if (comboBox1.Text == "قلب")
                textBox3.Text = "500$";
            if (comboBox1.Text == "دماغ")
                textBox3.Text = "700$";
            if (comboBox1.Text == "عام")
                textBox3.Text = "200$";
            if (comboBox1.Text == "عظمي")
                textBox3.Text = "450$";
            if (comboBox1.Text == "عصبي")
                textBox3.Text = "400$";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text,comboBox2.Text, textBox3.Text);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (comboBox1.Text == "قلب")
                    textBox3.Text = "500$";
                if (comboBox1.Text == "دماغ")
                    textBox3.Text = "700$";
                if (comboBox1.Text == "عام")
                    textBox3.Text = "200$";
                if (comboBox1.Text == "عظمي")
                    textBox3.Text = "450$";
                if (comboBox1.Text == "عصبي")
                    textBox3.Text = "400$";
            }
        }
    }
}
