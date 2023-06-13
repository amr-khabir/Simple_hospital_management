using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        string w = "amr", p = "1234";
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formshow = new Form2();
            formshow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 formshow = new Form3();
            formshow.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 formshow = new Form4();
            formshow.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ر formshow = new ر();
            formshow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("أهلا وسهلا بكم في مشفى ادلب #####تصميم: خالد الابراهيم & عمرو خبير & سعد الصالح");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد الخروج", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("yyyy/MM/dd");

            DialogResult result = MessageBox.Show("أهلا و سهلا بك ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                Close();
            textBox2.Focus();
            textBox2.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i <= 3)
                if (textBox2.Text == w && textBox3.Text == p)
                    groupBox1.Visible = false;
            else
                {
                    i++;
                        MessageBox.Show("حاول مرة أخرى ");
                }
            else
                Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox3.Focus();
                textBox3.Select();
            }

        }
    }
}
