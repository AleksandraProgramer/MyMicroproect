using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtorizacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string username1 = "admin";
            string password1 = "admin";



            if (this.textBox1.Text != username1 && this.textBox2.Text != password1)
            {
                Form2 form2 = new Form2();
                form2.Close();
            }

            if (this.textBox1.Text == username1 && this.textBox2.Text == password1)
            {
                Form2 newForm = new Form2();
                 newForm.Show();

                MessageBox.Show("Добро пожаловать!");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

               
            }
          else
               MessageBox.Show("Вы ввели неверный логин или пароль!");
        }



    }
}
