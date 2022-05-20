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

namespace proyect1
{
    //StudentName:juan Dario Silva Rodriguez
    //user code number: 2111174
    //Subjet: Object oriented programming
    public partial class IP : Form
    {
        public IP()
        {
            InitializeComponent();
        }

       
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button4;
        private Button button3;


        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "ValidateIP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(234, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(551, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter IP Address";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(525, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(81, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Date today ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // IP
            // 
            this.ClientSize = new System.Drawing.Size(1071, 477);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "IP";
            this.Text = "IP4- Validator";
            this.Load += new System.EventHandler(this.IP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void IP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //DateTime currentDateTime = DateTime.Today;
            //Text = currentDateTime.ToLongDateString();
            //MessageBox.Show(currentDateTime.ToLongDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                 if (MessageBox.Show("Do you want quit application IP Validator ?", "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
                { Application.Exit(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string IP = textBox1.Text;
            //IPAddress IP;
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");

            if (expr.IsMatch(IP))
                MessageBox.Show(IP+ "\n\n"+"The IP this correct", "Valid IP");
            else
            {
               
                   MessageBox.Show(IP + "\n\n"+"The IP must have 4 bytes" + "\n\n"+
                    "integer number between 0 to 255" + "\n\n"+
                    "separated by a dot (255.255.255.255)", "ERROR");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Today;

            MessageBox.Show(currentDateTime.ToLongDateString());
        }

        
    }



}
    
    
            
        
    
