using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyect1
{

    //StudentName:juan Dario Silva Rodriguez
    //user code number: 2111174
    //Subjet: Object oriented programming
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lotto649 objForm = new Lotto649();
            objForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LottoMax objForm = new LottoMax();
            objForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            TemperatureConvert objForm = new TemperatureConvert();
            objForm.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoneyExchange objForm = new MoneyExchange();
            objForm.Show();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            calculator objForm = new calculator();
            objForm.Show();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            IP objForm = new IP();
            objForm.Show();
        }

        

        }
        
    }

