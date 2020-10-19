using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private Stack<int> steps = new Stack<int>();
        private int cur_number = 0, cnt_operations = 0;
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            btnStepDown.Text = "Шаг назад";
            lblNumber.Text = "0";
            operations.Text = "0";
            btnPlay.Text = "ИГРАТЬ!";
            this.Text = "Удвоитель";
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            steps.Push(cur_number);
            cur_number++;
            cnt_operations++;
            lblNumber.Text = cur_number.ToString();
            operations.Text = cnt_operations.ToString();   
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            steps.Push(cur_number);
            cur_number *= 2;
            cnt_operations++;
            lblNumber.Text = cur_number.ToString();
            operations.Text = cnt_operations.ToString();          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            steps.Clear();
            cur_number = 0;
            cnt_operations = 0;
            lblNumber.Text = "0";
            operations.Text = "0";
        }

        private void btnStepDown_Click(object sender, EventArgs e)
        {
            if (steps.Count != 0) 
            {
                cur_number = steps.Pop();
                cnt_operations--;
                lblNumber.Text = cur_number.ToString();
                operations.Text = cnt_operations.ToString();  
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            MessageBox.Show("Дойди до числа: " + random.Next(0, 100) + " !");
        }
    }
}
