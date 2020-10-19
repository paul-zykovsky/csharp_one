using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task_2
{
    public partial class Form1 : Form
    {
        int cur_number = 0, user_number = 0, attempts = 0;
        public Form1()
        {
            InitializeComponent();
            btnGenerate.Text = "Генерировать новое число!";
            lblAttemptsTitle.Text = "Кол-во попыток";
            lblAttempts.Text = "0";
            lblCondTitle.Text = "Состояние";
            lblCond.Text = "Нейтрально!";
            lblNumberTitle.Text = "Мое число";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("Испытать судьбу?");
                if (result == DialogResult.OK)
                {
                    user_number = int.Parse(txtNumber.Text);
                    if (user_number > cur_number)
                        lblCond.Text = "Горячо!";
                    else if (user_number == cur_number)
                        MessageBox.Show("Число угадано!");
                    else
                        lblCond.Text = "Холодно!";

                }
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            cur_number = random.Next(1, 100);
            MessageBox.Show("Новое число загадано!");
        }
    }
}
