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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        string dir = @".\Lotto649\";
        string fileLotto = "LottoNbrs.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            string path = dir + fileLotto;



            string dateAndTime;

            dateAndTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            string textToShow = "", textToPrint = "649; " + dateAndTime + "; ";

            Random random = new Random();
            int randomNumber = 0;
            for (int i = 0; i < 7; i++)
            {
                randomNumber = random.Next(1, 49);
                textToShow += randomNumber.ToString() + "\t";
                if (i < 6) { textToPrint += randomNumber.ToString() + ", "; }
            }
            textToPrint += "Bonus: " + randomNumber.ToString();
            textBox1.Text = textToShow;
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                StreamWriter textOut = new StreamWriter(fs);
                textOut.WriteLine(textToPrint);
                MessageBox.Show("Write to the file = ok");
                textOut.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want quit this application ?", "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            { Application.Exit(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = dir + fileLotto;
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Lotto Version\t Winners Numbers\n";
                // read the data from the file and store it into the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split(';');
                    textToPrint += columns[0] + ",\t" + columns[2] + "\n";
                }
                MessageBox.Show(textToPrint, "Winners numbers (Irina y Juan)");
                // close the input stream for the text file
                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lotto649_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

    }
}
