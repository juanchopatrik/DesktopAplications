
**A.Start by adding a short description of your project, and the
languages (technologies) used:**

> The project is a Dash Board with 5 Applications, the applications are:

+---+-------------------------+
| • | > Lotto 6-49            |
+===+=========================+
| • | > Lotto Max             |
+---+-------------------------+
| • | > Calculator            |
+---+-------------------------+
| • | > Currency Converter    |
+---+-------------------------+
| • | > Temperature Converter |
+---+-------------------------+

To develop these applications, the .Net framework and the C \#
programming language were used.

**B.Present the print screens of yours forms, and have a detailed
description of the functionalities**

> **(step by step).**

**Dash Board:**

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image1.png){width="6.5in"
height="4.408333333333333in"}

  •   • You can select each of the applications by clicking on the tabs
  --- -------------------------------------------------------------------
  •   • to exit the application you can click the exit button

**Lotto Max**

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image2.png){width="4.608332239720035in"
height="4.1in"}

Form application allows user to generate 7 + 1 or 6 + 1 random numbers
from 49 for Lotto Max or Lotto 649 game.

The unique 8 or 7 numbers are presented to the user in the multi-line
read-only TextBox and are also saved to a LottoNbrs.txt text file (one
series of numbers per line, using a comma to separate the numbers).

the content of the text file can be read and displayed using a message
box. Add the relevant information in the message box and the appropriate
title and your name as the title.

**Simple Calculator**

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image3.png){width="6.5in"
height="4.733333333333333in"}

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image4.png){width="3.0in"
height="3.8916666666666666in"}

It is a calculator that allows the user to perform the operations
provided by a basic calculator. It also creates a class that performs
the required basic operation and will render the result in the read-only
TextBox. It also saves all arithmetic operations and their results in a
Calculator.txt text file (one operation per line).

Ex: You can convert the input data back and forth between decimal or
double (data type for calculations) to string data type (for
presentation).

So, when you click on a button from 0 to 9, you want to present the
first or second number in the text box, and also, when you click on one
of those 4 operation buttons, that value is taken as a number to be used
in subsequent calculations, and when the equal button is pressed, the
result of the operation is displayed. The Delete button will delete all
members of the Calculator class fields and the text box.

**The Money Exchange application**

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image5.png){width="6.491666666666666in"
height="2.825in"}

In this application you can add the currency of your choice, and use the
exchange factor.

The choice of exchange currencies is presented through the use of radio
buttons and allows the user to enter a valid amount in a text box and
the converted amount is found in the read-only text box on the right.

Egypt was added as an additional country. The conversion is saved in a
text file MoneyConversions.txt

**The Temperature application**

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image6.png){width="6.5in"
height="3.1in"}

You can choose two temperature conversions presented to the user by
using radio buttons and allows you to enter the valid value in a text
box and present the corresponding temperature in the read-only TextBox.
In the Message text box Read only. The temperature conversion is also
saved in a text file TempConversions.txt

You can choose two temperature conversions presented to the user by
using radio buttons and allows you to enter the valid value in a text
box and present the corresponding temperature in the read-only TextBox.
In the Message text box Read only. The temperature conversion is also
saved in a text file TempConversions.txt

**The IP4 Validator application**

![](vertopal_815e4a080eb7402bacfceffc670a3555/media/image7.png){width="6.5in"
height="2.716666666666667in"}

The form allows the user to perform the following operations using the
appropriate String and DateTime object methods (ToLongDateString (),
Trim (), Split ()). The current date will be presented in long format
once the Form application is opened. A document with print screens is
created in the application,

**C.Present the code of your application (forms).**

**Lotto Max**

using System;\
using System.Collections.Generic;\
using System.ComponentModel;\
using System.Data;\
using System.Drawing;\
using System.Linq;\
using System.Text;\
using System.Threading.Tasks;\
using System.Windows.Forms;\
using System.IO;\
namespace proyect1\
{\
//StudentName:juan Dario Silva Rodriguez\
//user code number: 2111174\
//Subjet: Object oriented programming\
publicpartialclassLottoMax : Form\
{\
publicLottoMax()\
{\
InitializeComponent();\
}\
string dir = @\".\\Lotto649\\\";\
string fileLotto = \"LottoNbrs.txt\";\
privatevoid button3_Click(object sender, EventArgs e)\
{\
if (MessageBox.Show(\"Do you want quit application Lotto Max ?\",
\"Exit?\", MessageBoxButtons.YesNo).ToString() == \"Yes\")\
{ Application.Exit(); }\
}\
privatevoid label1_Click(object sender, EventArgs e)\
{\
}

> privatevoid textBox1_TextChanged(object sender, EventArgs e) {\
> }\
> privatevoid button1_Click(object sender, EventArgs e)\
> {\
> FileStream fs = null;\
> string path = dir + fileLotto;\
> string dateAndTime;
>
> dateAndTime = DateTime.Now.ToShortDateString() + \" \" +
> DateTime.Now.ToShortTimeString();
>
> string textToShow = \"\", textToPrint = \"Max; \" + dateAndTime + \";
> \"; Random random = new Random();\
> int randomNumber = 0;\
> for (int i = 0; i \< 7; i++)\
> {\
> randomNumber = random.Next(1, 49);\
> textToShow += randomNumber.ToString() + \"\\t\";\
> if (i \< 6) { textToPrint += randomNumber.ToString() + \", \"; } }\
> textToPrint += \"Bonus: \" + randomNumber.ToString();\
> textBox1.Text = textToShow;\
> try\
> {\
> fs = new FileStream(path, FileMode.Append, FileAccess.Write);
> StreamWriter textOut = new StreamWriter(fs);\
> textOut.WriteLine(textToPrint);\
> MessageBox.Show(\"Write to the file = ok\");\
> textOut.Close();\
> }\
> catch (FileNotFoundException)\
> {\
> MessageBox.Show(path + \" not found.\", \"File Not Found\"); }\
> catch (DirectoryNotFoundException)\
> {\
> MessageBox.Show(path + \" not found.\", \"Directory Not Found\"); }\
> catch (IOException ex)\
> { MessageBox.Show(ex.Message, \"IOException\"); }\
> finally { if (fs != null) fs.Close(); }\
> }\
> privatevoid button2_Click(object sender, EventArgs e)\
> {\
> string path = dir + fileLotto;\
> FileStream fs = null;\
> try
>
> {\
> fs = new FileStream(path, FileMode.Open, FileAccess.Read); // create
> the object for the input stream for a text file StreamReader textIn =
> new StreamReader(fs);\
> string textToPrint = \"Lotto Version\\t Winners Numbers\\n\"; // read
> the data from the file and store it into the list while (textIn.Peek()
> != -1)\
> {\
> string row = textIn.ReadLine();\
> string\[\] columns = row.Split(\';\');\
> textToPrint += columns\[0\] + \",\\t\" + columns\[2\] + \"\\n\"; }\
> MessageBox.Show(textToPrint, \"Winners numbers (Irina y Juan)\"); //
> close the input stream for the text file\
> textIn.Close();\
> }\
> catch (FileNotFoundException)\
> {\
> MessageBox.Show(path + \" not found.\", \"File Not Found\"); }\
> catch (DirectoryNotFoundException)\
> {\
> MessageBox.Show(path + \" not found.\", \"Directory Not Found\"); }\
> catch (IOException ex)\
> { MessageBox.Show(ex.Message, \"IOException\"); }\
> finally { if (fs != null) fs.Close(); }\
> }\
> }\
> }

**Lotto 649**

using System;\
using System.Collections.Generic;\
using System.ComponentModel;\
using System.Data;\
using System.Drawing;\
using System.Linq;\
using System.Text;\
using System.Threading.Tasks;\
using System.Windows.Forms;\
using System.IO;\
namespace proyect1\
{\
//StudentName:juan Dario Silva Rodriguez\
//user code number: 2111174\
//Subjet: Object oriented programming\
publicpartialclassLotto649 : Form\
{\
publicLotto649()\
{\
InitializeComponent();\
}

> string dir = @\".\\Lotto649\\\";\
> string fileLotto = \"LottoNbrs.txt\";\
> privatevoid button1_Click(object sender, EventArgs e) {\
> FileStream fs = null;\
> string path = dir + fileLotto;\
> string dateAndTime;
>
> dateAndTime = DateTime.Now.ToShortDateString() + \" \" +
> DateTime.Now.ToShortTimeString();
>
> string textToShow = \"\", textToPrint = \"649; \" + dateAndTime + \";
> \"; Random random = new Random();\
> int randomNumber = 0;\
> for (int i = 0; i \< 7; i++)\
> {\
> randomNumber = random.Next(1, 49);\
> textToShow += randomNumber.ToString() + \"\\t\";\
> if (i \< 6) { textToPrint += randomNumber.ToString() + \", \"; } }\
> textToPrint += \"Bonus: \" + randomNumber.ToString();\
> textBox1.Text = textToShow;\
> try\
> {\
> fs = new FileStream(path, FileMode.Append, FileAccess.Write);
> StreamWriter textOut = new StreamWriter(fs);\
> textOut.WriteLine(textToPrint);\
> MessageBox.Show(\"Write to the file = ok\");\
> textOut.Close();\
> }\
> catch (FileNotFoundException)\
> {\
> MessageBox.Show(path + \" not found.\", \"File Not Found\"); }\
> catch (DirectoryNotFoundException)\
> {\
> MessageBox.Show(path + \" not found.\", \"Directory Not Found\"); }\
> catch (IOException ex)\
> { MessageBox.Show(ex.Message, \"IOException\"); }\
> finally { if (fs != null) fs.Close(); }\
> }\
> privatevoid button3_Click(object sender, EventArgs e)\
> {
>
> if (MessageBox.Show(\"Do you want quit this application ?\",
> \"Exit?\", MessageBoxButtons.YesNo).ToString() == \"Yes\")\
> { Application.Exit(); }\
> }\
> privatevoid button2_Click(object sender, EventArgs e)

{\
string path = dir + fileLotto;\
FileStream fs = null;\
try\
{\
fs = new FileStream(path, FileMode.Open, FileAccess.Read); // create the
object for the input stream for a text file StreamReader textIn = new
StreamReader(fs);\
string textToPrint = \"Lotto Version\\t Winners Numbers\\n\"; // read
the data from the file and store it into the list while (textIn.Peek()
!= -1)\
{\
string row = textIn.ReadLine();\
string\[\] columns = row.Split(\';\');\
textToPrint += columns\[0\] + \",\\t\" + columns\[2\] + \"\\n\"; }\
MessageBox.Show(textToPrint, \"Winners numbers (Irina y Juan)\"); //
close the input stream for the text file\
textIn.Close();\
}\
catch (FileNotFoundException)\
{\
MessageBox.Show(path + \" not found.\", \"File Not Found\"); }\
catch (DirectoryNotFoundException)\
{\
MessageBox.Show(path + \" not found.\", \"Directory Not Found\"); }\
catch (IOException ex)\
{ MessageBox.Show(ex.Message, \"IOException\"); }\
finally { if (fs != null) fs.Close(); }\
}\
privatevoid textBox1_TextChanged(object sender, EventArgs e)\
{\
}\
privatevoid Lotto649_Load(object sender, EventArgs e)\
{\
if (!Directory.Exists(dir))\
{\
Directory.CreateDirectory(dir);\
}\
}\
}\
}

**Simple Calculator**

using System;\
using System.Collections.Generic;

using System.ComponentModel;\
using System.Data;\
using System.Drawing;\
using System.Linq;\
using System.Text;\
using System.Threading.Tasks;\
using System.Windows.Forms;\
using System.IO;\
namespace proyect1\
{\
//StudentName:juan Dario Silva Rodriguez\
//user code number: 2111174\
//Subjet: Object oriented programming\
publicpartialclasscalculator : Form\
{\
publiccalculator()\
{\
InitializeComponent();\
}\
decimal FirstNumber;\
string Operation;\
string dir = @\".\\Calculator\\\";\
string filecalc = \"memory.txt\";\
privatevoid textBox1_TextChanged(object sender, EventArgs e)\
{\
}\
privatevoid clear_all()\
{\
textBox1.Clear();\
FirstNumber = 0;\
Operation = \"\";\
}\
privatevoid button18_Click(object sender, EventArgs e)\
{\
if (MessageBox.Show(\"Do you want quit this application ?\", \"Exit?\",
MessageBoxButtons.YesNo).ToString() == \"Yes\")\
{ Application.Exit(); }\
}\
privatevoid calculator_Load(object sender, EventArgs e)\
{\
if (!Directory.Exists(dir))\
{\
Directory.CreateDirectory(dir);\
}\
}\
privatevoid button1_Click(object sender, EventArgs e)\
{

> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"1\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"1\";\
> }\
> }\
> privatevoid button2_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"2\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"2\";\
> }\
> }\
> privatevoid button3_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"3\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"3\";\
> }\
> }\
> privatevoid button4_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"4\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"4\";\
> }\
> }\
> privatevoid button5_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"5\";\
> }\
> else\
> {
>
> textBox1.Text = textBox1.Text + \"5\";\
> }\
> }\
> privatevoid button6_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"6\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"6\";\
> }\
> }\
> privatevoid button7_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"7\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"7\";\
> }\
> }\
> privatevoid button8_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"8\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"8\";\
> }\
> }\
> privatevoid button9_Click(object sender, EventArgs e) {\
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"9\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"9\";\
> }\
> }\
> privatevoid button10_Click(object sender, EventArgs e) {
>
> if (textBox1.Text == \"0\" && textBox1.Text != null) {\
> textBox1.Text = \"0\";\
> }\
> else\
> {\
> textBox1.Text = textBox1.Text + \"0\";\
> }\
> }\
> privatevoid button12_Click(object sender, EventArgs e) {\
> FirstNumber = Convert.ToDecimal(textBox1.Text); textBox1.Text =
> \"0\";\
> Operation = \"+\";\
> }\
> privatevoid button13_Click(object sender, EventArgs e) {\
> FirstNumber = Convert.ToDecimal(textBox1.Text); textBox1.Text =
> \"0\";\
> Operation = \"-\";\
> }\
> privatevoid button14_Click(object sender, EventArgs e) {\
> FirstNumber = Convert.ToDecimal(textBox1.Text); textBox1.Text =
> \"0\";\
> Operation = \"\*\";\
> }\
> privatevoid button15_Click(object sender, EventArgs e) {\
> FirstNumber = Convert.ToDecimal(textBox1.Text); textBox1.Text =
> \"0\";\
> Operation = \"/\";\
> }\
> privatevoid button11_Click(object sender, EventArgs e) {\
> textBox1.Text = textBox1.Text + \".\";\
> }\
> privatevoid button17_Click(object sender, EventArgs e) {\
> decimal SecondNumber;\
> decimal Result;\
> SecondNumber = Convert.ToDecimal(textBox1.Text); if (Operation ==
> \"+\")\
> {\
> Result = (FirstNumber + SecondNumber);\
> textBox1.Text = Convert.ToString(Result);\
> FirstNumber = Result;\
> }

if (Operation == \"-\")\
{\
Result = (FirstNumber - SecondNumber);\
textBox1.Text = Convert.ToString(Result);\
FirstNumber = Result;\
}\
if (Operation == \"\*\")\
{\
Result = (FirstNumber \* SecondNumber);\
textBox1.Text = Convert.ToString(Result);\
FirstNumber = Result;\
}\
if (Operation == \"/\")\
{\
if (SecondNumber == 0)\
{\
textBox1.Text = \"Cannot divide by zero\";\
}\
else\
{\
Result = (FirstNumber / SecondNumber);\
textBox1.Text = Convert.ToString(Result);\
FirstNumber = Result;\
}\
}\
FileStream fs = null;\
string path = dir + filecalc;\
string dateAndTime;\
dateAndTime = DateTime.Now.ToShortDateString() + \" \" +\
DateTime.Now.ToShortTimeString();\
string textToPrint = dateAndTime + \" \"+ FirstNumber.ToString() + \" \"
+ Operation + \" \" + SecondNumber.ToString();\
try\
{\
fs = new FileStream(path, FileMode.Append, FileAccess.Write);
MessageBox.Show(\"se creo el fs\");\
StreamWriter textOut = new StreamWriter(fs);\
textOut.WriteLine(textToPrint);\
textOut.Close();\
}\
catch (FileNotFoundException)\
{\
MessageBox.Show(path + \" not found.\", \"File Not Found\");\
}\
catch (DirectoryNotFoundException)

{\
MessageBox.Show(path + \" not found.\", \"Directory Not Found\"); }\
catch (IOException ex)\
{ MessageBox.Show(ex.Message, \"IOException\"); }\
finally { if (fs != null) fs.Close(); }\
}\
privatevoid button16_Click(object sender, EventArgs e)\
{\
clear_all();\
}\
}\
}

**The Money Exchange application**

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

{ //StudentName:juan Dario Silva Rodriguez

> //user code number: 2111174
>
> //Subjet: Object oriented programming
>
> public partial class MoneyExchange : Form
>
> {
>
> private Label label2;
>
> private RadioButton radioButton2;
>
> private RadioButton radioButton3;
>
> private RadioButton radioButton4;
>
> private RadioButton radioButton5;
>
> private RadioButton radioButton6;
>
> private RadioButton radioButton7;
>
> private RadioButton radioButton8;
>
> private RadioButton radioButton9;
>
> private RadioButton radioButton10;
>
> private Label label1;
>
> private TextBox textBox1;
>
> private TextBox textBox2;
>
> private Button button1;
>
> private Button button2;
>
> private Button button4;
>
> private Button button3;
>
> private GroupBox groupBox1;
>
> private GroupBox groupBox2;
>
> private RadioButton radioButton1;
>
> public MoneyExchange()
>
> {
>
> InitializeComponent();
>
> }
>
> private void InitializeComponent()
>
> {
>
> this.radioButton1 = new System.Windows.Forms.RadioButton();
>
> this.label2 = new System.Windows.Forms.Label();
>
> this.radioButton2 = new System.Windows.Forms.RadioButton();
>
> this.radioButton3 = new System.Windows.Forms.RadioButton();
>
> this.radioButton4 = new System.Windows.Forms.RadioButton();
>
> this.radioButton5 = new System.Windows.Forms.RadioButton();
>
> this.radioButton6 = new System.Windows.Forms.RadioButton();
>
> this.radioButton7 = new System.Windows.Forms.RadioButton();
>
> this.radioButton8 = new System.Windows.Forms.RadioButton();
>
> this.radioButton9 = new System.Windows.Forms.RadioButton();
>
> this.radioButton10 = new System.Windows.Forms.RadioButton();
>
> this.label1 = new System.Windows.Forms.Label();
>
> this.textBox1 = new System.Windows.Forms.TextBox();
>
> this.textBox2 = new System.Windows.Forms.TextBox();
>
> this.button1 = new System.Windows.Forms.Button();
>
> this.button2 = new System.Windows.Forms.Button();
>
> this.button4 = new System.Windows.Forms.Button();
>
> this.button3 = new System.Windows.Forms.Button();
>
> this.groupBox1 = new System.Windows.Forms.GroupBox();
>
> this.groupBox2 = new System.Windows.Forms.GroupBox();
>
> this.groupBox1.SuspendLayout();
>
> this.groupBox2.SuspendLayout();
>
> this.SuspendLayout();
>
> //
>
> // radioButton1
>
> //
>
> this.radioButton1.AutoSize = true;

this.radioButton1.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton1.Location = new System.Drawing.Point(6, 44);
>
> this.radioButton1.Name = \"radioButton1\";
>
> this.radioButton1.Size = new System.Drawing.Size(76, 29);
>
> this.radioButton1.TabIndex = 1;
>
> this.radioButton1.TabStop = true;
>
> this.radioButton1.Text = \"CAD\";
>
> this.radioButton1.UseVisualStyleBackColor = true;

this.radioButton1.CheckedChanged += new\
System.EventHandler(this.radioButton1_CheckedChanged);

> //
>
> // label2
>
> //
>
> this.label2.AutoSize = true;

this.label2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10.8F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.label2.Location = new System.Drawing.Point(17, 17);
>
> this.label2.Name = \"label2\";
>
> this.label2.Size = new System.Drawing.Size(55, 24);
>
> this.label2.TabIndex = 17;
>
> this.label2.Text = \"From\";
>
> //
>
> // radioButton2
>
> //
>
> this.radioButton2.AutoSize = true;

this.radioButton2.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton2.Location = new System.Drawing.Point(7, 79);
>
> this.radioButton2.Name = \"radioButton2\";
>
> this.radioButton2.Size = new System.Drawing.Size(75, 29);
>
> this.radioButton2.TabIndex = 18;
>
> this.radioButton2.TabStop = true;
>
> this.radioButton2.Text = \"USD\";
>
> this.radioButton2.UseVisualStyleBackColor = true;

this.radioButton2.CheckedChanged += new\
System.EventHandler(this.radioButton2_CheckedChanged);

> //
>
> // radioButton3
>
> //
>
> this.radioButton3.AutoSize = true;

this.radioButton3.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton3.Location = new System.Drawing.Point(9, 114);
>
> this.radioButton3.Name = \"radioButton3\";
>
> this.radioButton3.Size = new System.Drawing.Size(73, 29);
>
> this.radioButton3.TabIndex = 19;
>
> this.radioButton3.TabStop = true;
>
> this.radioButton3.Text = \"EUR\";
>
> this.radioButton3.UseVisualStyleBackColor = true;
>
> //
>
> // radioButton4
>
> //
>
> this.radioButton4.AutoSize = true;

this.radioButton4.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton4.Location = new System.Drawing.Point(6, 158);
>
> this.radioButton4.Name = \"radioButton4\";
>
> this.radioButton4.Size = new System.Drawing.Size(74, 29);
>
> this.radioButton4.TabIndex = 20;
>
> this.radioButton4.TabStop = true;
>
> this.radioButton4.Text = \"GBP\";
>
> this.radioButton4.UseVisualStyleBackColor = true;

this.radioButton4.CheckedChanged += new\
System.EventHandler(this.radioButton4_CheckedChanged);

> //
>
> // radioButton5
>
> //
>
> this.radioButton5.AutoSize = true;

this.radioButton5.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton5.Location = new System.Drawing.Point(6, 193);
>
> this.radioButton5.Name = \"radioButton5\";
>
> this.radioButton5.Size = new System.Drawing.Size(74, 29);
>
> this.radioButton5.TabIndex = 21;
>
> this.radioButton5.TabStop = true;
>
> this.radioButton5.Text = \"EGP\";
>
> this.radioButton5.UseVisualStyleBackColor = true;

this.radioButton5.CheckedChanged += new\
System.EventHandler(this.radioButton5_CheckedChanged);

> //
>
> // radioButton6
>
> //
>
> this.radioButton6.AutoSize = true;

this.radioButton6.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton6.Location = new System.Drawing.Point(23, 58);
>
> this.radioButton6.Name = \"radioButton6\";
>
> this.radioButton6.Size = new System.Drawing.Size(76, 29);
>
> this.radioButton6.TabIndex = 22;
>
> this.radioButton6.TabStop = true;
>
> this.radioButton6.Text = \"CAD\";
>
> this.radioButton6.UseVisualStyleBackColor = true;

this.radioButton6.CheckedChanged += new\
System.EventHandler(this.radioButton6_CheckedChanged);

> //
>
> // radioButton7
>
> //
>
> this.radioButton7.AutoSize = true;

this.radioButton7.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton7.Location = new System.Drawing.Point(23, 93);
>
> this.radioButton7.Name = \"radioButton7\";
>
> this.radioButton7.Size = new System.Drawing.Size(75, 29);
>
> this.radioButton7.TabIndex = 23;
>
> this.radioButton7.TabStop = true;
>
> this.radioButton7.Text = \"USD\";
>
> this.radioButton7.UseVisualStyleBackColor = true;

this.radioButton7.CheckedChanged += new\
System.EventHandler(this.radioButton7_CheckedChanged);

> //
>
> // radioButton8
>
> //
>
> this.radioButton8.AutoSize = true;

this.radioButton8.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton8.Location = new System.Drawing.Point(27, 137);
>
> this.radioButton8.Name = \"radioButton8\";
>
> this.radioButton8.Size = new System.Drawing.Size(73, 29);
>
> this.radioButton8.TabIndex = 24;
>
> this.radioButton8.TabStop = true;
>
> this.radioButton8.Text = \"EUR\";
>
> this.radioButton8.UseVisualStyleBackColor = true;

this.radioButton8.CheckedChanged += new\
System.EventHandler(this.radioButton8_CheckedChanged);

> //
>
> // radioButton9
>
> //
>
> this.radioButton9.AutoSize = true;

this.radioButton9.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton9.Location = new System.Drawing.Point(27, 172);
>
> this.radioButton9.Name = \"radioButton9\";
>
> this.radioButton9.Size = new System.Drawing.Size(74, 29);
>
> this.radioButton9.TabIndex = 25;
>
> this.radioButton9.TabStop = true;
>
> this.radioButton9.Text = \"GBP\";
>
> this.radioButton9.UseVisualStyleBackColor = true;

this.radioButton9.CheckedChanged += new\
System.EventHandler(this.radioButton9_CheckedChanged);

> //
>
> // radioButton10
>
> //
>
> this.radioButton10.AutoSize = true;

this.radioButton10.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton10.Location = new System.Drawing.Point(23, 207);
>
> this.radioButton10.Name = \"radioButton10\";
>
> this.radioButton10.Size = new System.Drawing.Size(74, 29);
>
> this.radioButton10.TabIndex = 26;
>
> this.radioButton10.TabStop = true;
>
> this.radioButton10.Text = \"EGP\";
>
> this.radioButton10.UseVisualStyleBackColor = true;

this.radioButton10.CheckedChanged += new\
System.EventHandler(this.radioButton10_CheckedChanged);

> //
>
> // label1
>
> //
>
> this.label1.AutoSize = true;

this.label1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10.8F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.label1.Location = new System.Drawing.Point(23, 28);
>
> this.label1.Name = \"label1\";
>
> this.label1.Size = new System.Drawing.Size(33, 24);
>
> this.label1.TabIndex = 27;
>
> this.label1.Text = \"To\";
>
> //
>
> // textBox1
>
> //

this.textBox1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.textBox1.Location = new System.Drawing.Point(12, 332);
>
> this.textBox1.Name = \"textBox1\";
>
> this.textBox1.Size = new System.Drawing.Size(140, 30);
>
> this.textBox1.TabIndex = 28;
>
> this.textBox1.TextChanged += new
> System.EventHandler(this.textBox1_TextChanged);
>
> //
>
> // textBox2
>
> //

this.textBox2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.textBox2.Location = new System.Drawing.Point(571, 332);
>
> this.textBox2.Name = \"textBox2\";
>
> this.textBox2.Size = new System.Drawing.Size(140, 30);
>
> this.textBox2.TabIndex = 29;
>
> this.textBox2.TextChanged += new
> System.EventHandler(this.textBox2_TextChanged);
>
> //
>
> // button1
>
> //

this.button1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button1.Location = new System.Drawing.Point(18, 408);
>
> this.button1.Name = \"button1\";
>
> this.button1.Size = new System.Drawing.Size(143, 42);
>
> this.button1.TabIndex = 30;
>
> this.button1.Text = \"Convert\";
>
> this.button1.UseVisualStyleBackColor = true;
>
> this.button1.Click += new System.EventHandler(this.button1_Click);
>
> //
>
> // button2
>
> //

this.button2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button2.Location = new System.Drawing.Point(245, 408);
>
> this.button2.Name = \"button2\";
>
> this.button2.Size = new System.Drawing.Size(143, 42);
>
> this.button2.TabIndex = 31;
>
> this.button2.Text = \"Read File\";
>
> this.button2.UseVisualStyleBackColor = true;
>
> this.button2.Click += new System.EventHandler(this.button2_Click);
>
> //
>
> // button4
>
> //

this.button4.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button4.Location = new System.Drawing.Point(484, 408);
>
> this.button4.Name = \"button4\";
>
> this.button4.Size = new System.Drawing.Size(143, 42);
>
> this.button4.TabIndex = 32;
>
> this.button4.Text = \"Reset\";
>
> this.button4.UseVisualStyleBackColor = true;
>
> this.button4.Click += new System.EventHandler(this.button4_Click);
>
> //
>
> // button3
>
> //

this.button3.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button3.Location = new System.Drawing.Point(736, 408);
>
> this.button3.Name = \"button3\";
>
> this.button3.Size = new System.Drawing.Size(143, 42);
>
> this.button3.TabIndex = 33;
>
> this.button3.Text = \"Exit\";
>
> this.button3.UseVisualStyleBackColor = true;
>
> this.button3.Click += new System.EventHandler(this.button3_Click);
>
> //
>
> // groupBox1
>
> //
>
> this.groupBox1.Controls.Add(this.radioButton1);
>
> this.groupBox1.Controls.Add(this.label2);
>
> this.groupBox1.Controls.Add(this.radioButton2);
>
> this.groupBox1.Controls.Add(this.radioButton3);
>
> this.groupBox1.Controls.Add(this.radioButton4);
>
> this.groupBox1.Controls.Add(this.radioButton5);
>
> this.groupBox1.Location = new System.Drawing.Point(18, 33);
>
> this.groupBox1.Name = \"groupBox1\";
>
> this.groupBox1.Size = new System.Drawing.Size(397, 249);
>
> this.groupBox1.TabIndex = 34;
>
> this.groupBox1.TabStop = false;
>
> this.groupBox1.Text = \"groupBox1\";
>
> this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
>
> //
>
> // groupBox2
>
> //
>
> this.groupBox2.Controls.Add(this.label1);
>
> this.groupBox2.Controls.Add(this.radioButton6);
>
> this.groupBox2.Controls.Add(this.radioButton7);
>
> this.groupBox2.Controls.Add(this.radioButton8);
>
> this.groupBox2.Controls.Add(this.radioButton9);
>
> this.groupBox2.Controls.Add(this.radioButton10);
>
> this.groupBox2.Location = new System.Drawing.Point(571, 33);
>
> this.groupBox2.Name = \"groupBox2\";
>
> this.groupBox2.Size = new System.Drawing.Size(314, 262);
>
> this.groupBox2.TabIndex = 35;
>
> this.groupBox2.TabStop = false;
>
> this.groupBox2.Text = \"groupBox2\";
>
> //
>
> // MoneyExchange
>
> //
>
> this.ClientSize = new System.Drawing.Size(1193, 510);
>
> this.Controls.Add(this.groupBox2);
>
> this.Controls.Add(this.groupBox1);
>
> this.Controls.Add(this.button3);
>
> this.Controls.Add(this.button4);
>
> this.Controls.Add(this.button2);
>
> this.Controls.Add(this.button1);
>
> this.Controls.Add(this.textBox2);
>
> this.Controls.Add(this.textBox1);
>
> this.Name = \"MoneyExchange\";
>
> this.Text = \"MoneyExchange\";
>
> this.groupBox1.ResumeLayout(false);
>
> this.groupBox1.PerformLayout();
>
> this.groupBox2.ResumeLayout(false);
>
> this.groupBox2.PerformLayout();
>
> this.ResumeLayout(false);
>
> this.PerformLayout();
>
> }
>
> private void button4_Click(object sender, EventArgs e)
>
> {
>
> textBox1.Text = String.Empty;
>
> textBox2.Text = String.Empty;
>
> }
>
> private void textBox1_TextChanged(object sender, EventArgs e)
>
> {
>
> }
>
> private void textBox2_TextChanged(object sender, EventArgs e)
>
> {
>
> textBox2.Enabled = false;
>
> }
>
> private void button3_Click(object sender, EventArgs e)
>
> {

if (MessageBox.Show(\"Do you want quit application Money Exchange ?\",
\"Exit?\", MessageBoxButtons.YesNo).ToString() == \"Yes\")

> { Application.Exit(); }
>
> }
>
> private void button2_Click(object sender, EventArgs e)
>
> {
>
> {
>
> string dirPath = @\".\\MoneyConversions\\\"; // C:\\Test
>
> string filePath = @\".\\MoneyConversions.txt\"; // C:\\Test\\Names.txt
>
> FileStream fs = null;
>
> try
>
> {
>
> // fs = new FileStream(filePath, FileMode.Open);
>
> // code that uses the file stream to read and write data file
>
> fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
>
> // create the output stream for a text file that exists
>
> StreamReader textIn = new StreamReader(fs);
>
> // write the fields into text file
>
> // MessageBox.Show(textIn.ReadToEnd());
>
> string textToPrint = \"Money Conversion\\t\";
>
> // read the data from the file and store it in the list
>
> while (textIn.Peek() != -1)
>
> {
>
> string row = textIn.ReadLine();
>
> string\[\] columns = row.Split(\'\|\');
>
> textToPrint += columns\[0\] + \",\\t\" + columns\[1\] + \",\\t\" +
> columns\[2\] + \"\\n\";
>
> }
>
> MessageBox.Show(textToPrint);
>
> // close the output stream for the text file
>
> textIn.Close();
>
> }
>
> catch (FileNotFoundException)
>
> {
>
> MessageBox.Show(filePath + \" not found.\", \"File Not Found\");
>
> }
>
> catch (DirectoryNotFoundException)
>
> {
>
> MessageBox.Show(dirPath + \" not found.\", \"Directory Not Found\");
>
> }
>
> catch (IOException ex)
>
> { MessageBox.Show(ex.Message, \"IOException\"); }
>
> finally
>
> {
>
> if (fs != null)
>
> {
>
> fs.Close();
>
> ///MessageBox.Show(\"fs object is close.\");
>
> }
>
> }
>
> }
>
> }
>
> private void button1_Click(object sender, EventArgs e)
>
> {
>
> try
>
> {
>
> if (radioButton1.Checked && radioButton7.Checked == true)
>
> {
>
> double cad = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(cad \* 0.78);
>
> }
>
> if (radioButton1.Checked && radioButton8.Checked == true)
>
> {
>
> double cad = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(cad \* 0.69);
>
> }
>
> if (radioButton1.Checked && radioButton9.Checked == true)
>
> {
>
> double cad = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(cad \* 0.59);
>
> }
>
> if (radioButton1.Checked && radioButton10.Checked == true)
>
> {
>
> double cad = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(cad \* 12.21);
>
> }
>
> if (radioButton2.Checked && radioButton6.Checked == true)
>
> {
>
> double usd = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(usd \* 1.28);
>
> }
>
> if (radioButton2.Checked && radioButton8.Checked == true)
>
> {
>
> double usd = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(usd \* 0.88);
>
> }
>
> if (radioButton2.Checked && radioButton9.Checked == true)
>
> {
>
> double usd = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(usd \* 0.75);
>
> }
>
> if (radioButton2.Checked && radioButton10.Checked == true)
>
> {
>
> double usd = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(usd \* 15.66);
>
> }
>
> if (radioButton3.Checked && radioButton6.Checked == true)
>
> {
>
> double euro = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(euro \* 1.45);
>
> }
>
> if (radioButton3.Checked && radioButton7.Checked == true)
>
> {
>
> double euro = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(euro \* 1.13);
>
> }
>
> if (radioButton3.Checked && radioButton9.Checked == true)
>
> {
>
> double euro = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(euro \* 0.85);
>
> }
>
> if (radioButton3.Checked && radioButton10.Checked == true)
>
> {
>
> double euro = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(euro \* 17.73);
>
> }
>
> if (radioButton4.Checked && radioButton6.Checked == true)
>
> {
>
> double gbp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(gbp \* 1.71);
>
> }
>
> if (radioButton4.Checked && radioButton7.Checked == true)
>
> {
>
> double gbp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(gbp \* 1.33);
>
> }
>
> if (radioButton4.Checked && radioButton8.Checked == true)
>
> {
>
> double gbp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(gbp \* 1.18);
>
> }
>
> if (radioButton4.Checked && radioButton10.Checked == true)
>
> {
>
> double gbp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(gbp \* 20.85);
>
> }
>
> if (radioButton5.Checked && radioButton6.Checked == true)
>
> {
>
> double egp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(egp \* 0.081);
>
> }
>
> if (radioButton5.Checked && radioButton7.Checked == true)
>
> {
>
> double egp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(egp \* 0.063);
>
> }
>
> if (radioButton5.Checked && radioButton8.Checked == true)
>
> {
>
> double egp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(egp \* 0.056);
>
> }
>
> if (radioButton5.Checked && radioButton9.Checked == true)
>
> {
>
> double egp = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString(egp \* 0.048);
>
> }
>
> }
>
> catch (Exception)
>
> {
>
> }
>
> string dirPath = @\".\\MoneyConversions\\\"; // C:\\Test
>
> string filePath = @\".\\MoneyConversions.txt\"; // C:\\Test\\Names.txt
>
> FileStream fs = null;
>
> try
>
> {
>
> // fs = new FileStream(filePath, FileMode.Open);
>
> // code that uses the file stream to read and write data file
>
> fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
>
> // create the output stream for a text file that exists
>
> StreamWriter textOut = new StreamWriter(fs);
>
> // write the fields into text file
>
> textOut.Write(textBox1.Text + \'\|\');
>
> textOut.Write(textBox2.Text + \'\|\');

textOut.WriteLine(DateTime.Now.ToLongDateString() + \" \" +
DateTime.Now.ToLongTimeString());

> // close the output stream for the text file
>
> textOut.Close();
>
> }
>
> catch (FileNotFoundException)
>
> {
>
> MessageBox.Show(filePath + \" not found.\", \"File Not Found\");
>
> }
>
> catch (DirectoryNotFoundException)
>
> {
>
> MessageBox.Show(dirPath + \" not found.\", \"Directory Not Found\");
>
> }
>
> catch (IOException ex)
>
> { MessageBox.Show(ex.Message, \"IOException\"); }
>
> finally
>
> {
>
> if (fs != null)
>
> {
>
> fs.Close();
>
> ///MessageBox.Show(\"fs object is close.\");
>
> }
>
> }
>
> }
>
> }

}

**The Temperature application**

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

> //StudentName:juan Dario Silva Rodriguez
>
> //user code number: 2111174
>
> //Subjet: Object oriented programming
>
> public partial class TemperatureConvert : Form
>
> {
>
> private RadioButton radioButton2;
>
> private TextBox textBox1;
>
> private TextBox textBox2;
>
> private Label label1;
>
> private Label label2;
>
> private TextBox textBox3;
>
> private Label label3;
>
> private Button button1;
>
> private Button button2;
>
> private Button button3;
>
> private Button button4;
>
> private RadioButton radioButton1;
>
> public TemperatureConvert()
>
> {
>
> InitializeComponent();
>
> }
>
> private void InitializeComponent()
>
> {
>
> this.radioButton1 = new System.Windows.Forms.RadioButton();
>
> this.radioButton2 = new System.Windows.Forms.RadioButton();
>
> this.textBox1 = new System.Windows.Forms.TextBox();
>
> this.textBox2 = new System.Windows.Forms.TextBox();
>
> this.label1 = new System.Windows.Forms.Label();
>
> this.label2 = new System.Windows.Forms.Label();
>
> this.textBox3 = new System.Windows.Forms.TextBox();
>
> this.label3 = new System.Windows.Forms.Label();
>
> this.button1 = new System.Windows.Forms.Button();
>
> this.button2 = new System.Windows.Forms.Button();
>
> this.button3 = new System.Windows.Forms.Button();
>
> this.button4 = new System.Windows.Forms.Button();
>
> this.SuspendLayout();
>
> //
>
> // radioButton1
>
> //
>
> this.radioButton1.AutoSize = true;

this.radioButton1.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton1.Location = new System.Drawing.Point(422, 33);
>
> this.radioButton1.Name = \"radioButton1\";
>
> this.radioButton1.Size = new System.Drawing.Size(136, 29);
>
> this.radioButton1.TabIndex = 0;
>
> this.radioButton1.TabStop = true;
>
> this.radioButton1.Text = \"From C to F\";
>
> this.radioButton1.UseVisualStyleBackColor = true;

this.radioButton1.CheckedChanged += new\
System.EventHandler(this.radioButton1_CheckedChanged);

> //
>
> // radioButton2
>
> //
>
> this.radioButton2.AutoSize = true;

this.radioButton2.Font = new System.Drawing.Font(\"Microsoft Sans
Serif\", 12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.radioButton2.Location = new System.Drawing.Point(422, 68);
>
> this.radioButton2.Name = \"radioButton2\";
>
> this.radioButton2.Size = new System.Drawing.Size(136, 29);
>
> this.radioButton2.TabIndex = 1;
>
> this.radioButton2.TabStop = true;
>
> this.radioButton2.Text = \"From F to C\";
>
> this.radioButton2.UseVisualStyleBackColor = true;
>
> //
>
> // textBox1
>
> //

this.textBox1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.textBox1.Location = new System.Drawing.Point(85, 137);
>
> this.textBox1.Name = \"textBox1\";
>
> this.textBox1.Size = new System.Drawing.Size(140, 30);
>
> this.textBox1.TabIndex = 13;
>
> this.textBox1.TextChanged += new
> System.EventHandler(this.textBox1_TextChanged);
>
> //
>
> // textBox2
>
> //

this.textBox2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.textBox2.Location = new System.Drawing.Point(286, 137);
>
> this.textBox2.Name = \"textBox2\";
>
> this.textBox2.Size = new System.Drawing.Size(140, 30);
>
> this.textBox2.TabIndex = 14;
>
> //
>
> // label1
>
> //
>
> this.label1.AutoSize = true;

this.label1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10.8F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.label1.Location = new System.Drawing.Point(127, 179);
>
> this.label1.Name = \"label1\";
>
> this.label1.Size = new System.Drawing.Size(23, 24);
>
> this.label1.TabIndex = 15;
>
> this.label1.Text = \"C\";
>
> this.label1.Click += new System.EventHandler(this.label1_Click);
>
> //
>
> // label2
>
> //
>
> this.label2.AutoSize = true;

this.label2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10.8F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.label2.Location = new System.Drawing.Point(325, 179);
>
> this.label2.Name = \"label2\";
>
> this.label2.Size = new System.Drawing.Size(22, 24);
>
> this.label2.TabIndex = 16;
>
> this.label2.Text = \"F\";
>
> //
>
> // textBox3
>
> //

this.textBox3.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.textBox3.Location = new System.Drawing.Point(27, 249);
>
> this.textBox3.Name = \"textBox3\";
>
> this.textBox3.Size = new System.Drawing.Size(723, 30);
>
> this.textBox3.TabIndex = 17;
>
> this.textBox3.TextChanged += new
> System.EventHandler(this.textBox3_TextChanged);
>
> //
>
> // label3
>
> //
>
> this.label3.AutoSize = true;

this.label3.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10.8F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.label3.Location = new System.Drawing.Point(81, 222);
>
> this.label3.Name = \"label3\";
>
> this.label3.Size = new System.Drawing.Size(92, 24);
>
> this.label3.TabIndex = 18;
>
> this.label3.Text = \"Message:\";
>
> //
>
> // button1
>
> //

this.button1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button1.Location = new System.Drawing.Point(40, 330);
>
> this.button1.Name = \"button1\";
>
> this.button1.Size = new System.Drawing.Size(143, 42);
>
> this.button1.TabIndex = 19;
>
> this.button1.Text = \"Convert\";
>
> this.button1.UseVisualStyleBackColor = true;
>
> this.button1.Click += new System.EventHandler(this.button1_Click);
>
> //
>
> // button2
>
> //

this.button2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button2.Location = new System.Drawing.Point(249, 330);
>
> this.button2.Name = \"button2\";
>
> this.button2.Size = new System.Drawing.Size(143, 42);
>
> this.button2.TabIndex = 20;
>
> this.button2.Text = \"Read File\";
>
> this.button2.UseVisualStyleBackColor = true;
>
> this.button2.Click += new System.EventHandler(this.button2_Click);
>
> //
>
> // button3
>
> //

this.button3.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button3.Location = new System.Drawing.Point(607, 330);
>
> this.button3.Name = \"button3\";
>
> this.button3.Size = new System.Drawing.Size(143, 42);
>
> this.button3.TabIndex = 21;
>
> this.button3.Text = \"Exit\";
>
> this.button3.UseVisualStyleBackColor = true;
>
> this.button3.Click += new System.EventHandler(this.button3_Click);
>
> //
>
> // button4
>
> //

this.button4.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0)));

> this.button4.Location = new System.Drawing.Point(422, 330);
>
> this.button4.Name = \"button4\";
>
> this.button4.Size = new System.Drawing.Size(143, 42);
>
> this.button4.TabIndex = 22;
>
> this.button4.Text = \"Reset\";
>
> this.button4.UseVisualStyleBackColor = true;
>
> this.button4.Click += new System.EventHandler(this.button4_Click);
>
> //
>
> // TemperatureConvert
>
> //
>
> this.ClientSize = new System.Drawing.Size(1086, 515);
>
> this.Controls.Add(this.button4);
>
> this.Controls.Add(this.button3);
>
> this.Controls.Add(this.button2);
>
> this.Controls.Add(this.button1);
>
> this.Controls.Add(this.label3);
>
> this.Controls.Add(this.textBox3);
>
> this.Controls.Add(this.label2);
>
> this.Controls.Add(this.label1);
>
> this.Controls.Add(this.textBox2);
>
> this.Controls.Add(this.textBox1);
>
> this.Controls.Add(this.radioButton2);
>
> this.Controls.Add(this.radioButton1);
>
> this.Name = \"TemperatureConvert\";
>
> this.Text = \"Temperature Convert\";
>
> this.Load += new System.EventHandler(this.TemperatureConvert_Load);
>
> this.ResumeLayout(false);
>
> this.PerformLayout();
>
> }
>
> private void radioButton1_CheckedChanged(object sender, EventArgs e)
>
> {
>
> }
>
> private void TemperatureConvert_Load(object sender, EventArgs e)
>
> {
>
> }
>
> private void label1_Click(object sender, EventArgs e)
>
> {
>
> }
>
> private void button1_Click(object sender, EventArgs e)
>
> {
>
> try
>
> {
>
> if (radioButton1.Checked == true)
>
> {
>
> double c = Convert.ToDouble(textBox1.Text);
>
> textBox2.Text = Convert.ToString((c \* 1.8) + 32);
>
> }
>
> if (radioButton2.Checked == true)
>
> {
>
> double f = Convert.ToDouble(textBox2.Text);
>
> textBox1.Text = Convert.ToString((f - 32) / 1.8);
>
> }
>
> }
>
> catch (Exception)
>
> {
>
> }
>
> if (textBox1.Text == \"100\" && textBox2.Text == \"212\")
>
> {
>
> textBox3.Text = \"Water boils\";
>
> textBox3.BackColor = Color.Red;
>
> }
>
> else if (textBox1.Text == \"40\" && textBox2.Text == \"104\")
>
> {
>
> textBox3.Text = \"Hot Bath\";
>
> textBox3.BackColor = Color.Red;
>
> }
>
> else if (textBox1.Text == \"37\" && textBox2.Text == \"98.6\")
>
> {
>
> textBox3.Text = \"Body temperature\";
>
> textBox3.BackColor = Color.Red;
>
> }
>
> else if (textBox1.Text == \"30\" && textBox2.Text == \"86\")
>
> {
>
> textBox3.Text = \"Beach weather\";
>
> textBox3.BackColor = Color.Red;
>
> }
>
> else if (textBox1.Text == \"21\" && textBox2.Text == \"69.8\")
>
> {
>
> textBox3.Text = \"Room temperature\";
>
> textBox3.BackColor = Color.Green;
>
> }
>
> else if (textBox1.Text == \"10\" && textBox2.Text == \"50\")
>
> {
>
> textBox3.Text = \"Cool Day\";
>
> textBox3.BackColor = Color.Green;
>
> }
>
> else if (textBox1.Text == \"0\" && textBox2.Text == \"32\")
>
> {
>
> textBox3.Text = \"Freezing point of water\";
>
> textBox3.BackColor = Color.Blue;
>
> }
>
> else if (textBox1.Text == \"-18\")
>
> {
>
> textBox3.Text = \"Very Cold Day\";
>
> textBox3.BackColor = Color.Blue;
>
> }
>
> else if (textBox1.Text == \"-40\" && textBox2.Text == \"-40\")
>
> {
>
> textBox3.Text = \"Extremely Cold Day(and the same number!) \";
>
> textBox3.BackColor = Color.Blue;
>
> }
>
> string dirPath = @\".\\TempConversions\\\"; // C:\\Test
>
> string filePath = @\".\\TempConversions.txt\"; // C:\\Test\\Names.txt
>
> FileStream fs = null;
>
> try
>
> {
>
> // fs = new FileStream(filePath, FileMode.Open);
>
> // code that uses the file stream to read and write data file
>
> fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
>
> // create the output stream for a text file that exists
>
> StreamWriter textOut = new StreamWriter(fs);
>
> // write the fields into text file
>
> textOut.Write(textBox3.Text + \'\|\');

textOut.WriteLine(DateTime.Now.ToLongDateString() + \" \" +
DateTime.Now.ToLongTimeString());

> // close the output stream for the text file
>
> textOut.Close();
>
> }
>
> catch (FileNotFoundException)
>
> {
>
> MessageBox.Show(filePath + \" not found.\", \"File Not Found\");
>
> }
>
> catch (DirectoryNotFoundException)
>
> {
>
> MessageBox.Show(dirPath + \" not found.\", \"Directory Not Found\");
>
> }
>
> catch (IOException ex)
>
> { MessageBox.Show(ex.Message, \"IOException\"); }
>
> finally
>
> {
>
> if (fs != null)
>
> {
>
> fs.Close();
>
> ///MessageBox.Show(\"fs object is close.\");
>
> }
>
> }
>
> }
>
> private void button3_Click(object sender, EventArgs e)
>
> {
>
> {

if (MessageBox.Show(\"Do you want quit application Temperature Convert
?\", \"Exit?\", MessageBoxButtons.YesNo).ToString() == \"Yes\")

> { Application.Exit(); }
>
> }
>
> }
>
> private void button2_Click(object sender, EventArgs e)
>
> {
>
> string dirPath = @\".\\TempConversions\\\"; // C:\\Test
>
> string filePath = @\".\\TempConversions.txt\"; // C:\\Test\\Names.txt
>
> FileStream fs = null;
>
> try
>
> {
>
> // fs = new FileStream(filePath, FileMode.Open);
>
> // code that uses the file stream to read and write data file
>
> fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
>
> // create the output stream for a text file that exists
>
> StreamReader textIn = new StreamReader(fs);
>
> // write the fields into text file
>
> // MessageBox.Show(textIn.ReadToEnd());
>
> string textToPrint = \"Important Message\\t\";
>
> // read the data from the file and store it in the list
>
> while (textIn.Peek() != -1)
>
> {
>
> string row = textIn.ReadLine();
>
> string\[\] columns = row.Split(\'\|\');
>
> textToPrint += columns\[0\] + \",\\t\" + columns\[1\] + \",\\t\";
>
> }
>
> MessageBox.Show(textToPrint);
>
> // close the output stream for the text file
>
> textIn.Close();
>
> }
>
> catch (FileNotFoundException)
>
> {
>
> MessageBox.Show(filePath + \" not found.\", \"File Not Found\");
>
> }
>
> catch (DirectoryNotFoundException)
>
> {
>
> MessageBox.Show(dirPath + \" not found.\", \"Directory Not Found\");
>
> }
>
> catch (IOException ex)
>
> { MessageBox.Show(ex.Message, \"IOException\"); }
>
> finally
>
> {
>
> if (fs != null)
>
> {
>
> fs.Close();
>
> ///MessageBox.Show(\"fs object is close.\");
>
> }
>
> }
>
> }
>
> private void textBox3_TextChanged(object sender, EventArgs e)
>
> {
>
> }
>
> private void textBox1_TextChanged(object sender, EventArgs e)
>
> {
>
> }
>
> private void button4_Click(object sender, EventArgs e)
>
> {
>
> textBox1.Text = String.Empty;
>
> textBox2.Text = String.Empty;
>
> textBox3.Text = String.Empty;
>
> }
>
> }
>
> }

**The IP4 Validator application**

using System;\
using System.Collections.Generic;\
using System.ComponentModel;\
using System.Data;\
using System.Drawing;\
using System.Linq;\
using System.Text;

using System.Threading.Tasks;\
using System.Windows.Forms;\
using System.IO;\
namespace proyect1\
{\
//StudentName:juan Dario Silva Rodriguez\
//user code number: 2111174\
//Subjet: Object oriented programming\
publicpartialclassIP : Form\
{\
publicIP()\
{\
InitializeComponent();\
}\
private Button button1;\
private TextBox textBox1;\
private Label label2;\
private Button button2;\
private Button button4;\
private Button button3;\
privatevoid InitializeComponent()\
{\
this.button1 = new System.Windows.Forms.Button();\
this.textBox1 = new System.Windows.Forms.TextBox();\
this.label2 = new System.Windows.Forms.Label();\
this.button2 = new System.Windows.Forms.Button();\
this.button3 = new System.Windows.Forms.Button();\
this.button4 = new System.Windows.Forms.Button();\
this.SuspendLayout();\
//\
// button1\
//\
this.button1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.button1.Location =
new System.Drawing.Point(81, 204);\
this.button1.Name = \"button1\";\
this.button1.Size = new System.Drawing.Size(143, 42);\
this.button1.TabIndex = 11;\
this.button1.Text = \"ValidateIP\";\
this.button1.UseVisualStyleBackColor = true;\
this.button1.Click += new System.EventHandler(this.button1_Click); //\
// textBox1\
//\
this.textBox1.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
12F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.textBox1.Location
= new System.Drawing.Point(234, 111);\
this.textBox1.Name = \"textBox1\";\
this.textBox1.Size = new System.Drawing.Size(551, 30);\
this.textBox1.TabIndex = 12;\
this.textBox1.TextChanged += new\
System.EventHandler(this.textBox1_TextChanged);\
//

// label2\
//\
this.label2.AutoSize = true;\
this.label2.Font = new System.Drawing.Font(\"Times New Roman\", 12F,
System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
((byte)(0))); this.label2.Location = new System.Drawing.Point(75, 111);\
this.label2.Name = \"label2\";\
this.label2.Size = new System.Drawing.Size(153, 23);\
this.label2.TabIndex = 14;\
this.label2.Text = \"Enter IP Address\";\
//\
// button2\
//\
this.button2.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.button2.Location =
new System.Drawing.Point(284, 204);\
this.button2.Name = \"button2\";\
this.button2.Size = new System.Drawing.Size(143, 42);\
this.button2.TabIndex = 15;\
this.button2.Text = \"Reset\";\
this.button2.UseVisualStyleBackColor = true;\
this.button2.Click += new System.EventHandler(this.button2_Click); //\
// button3\
//\
this.button3.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.button3.Location =
new System.Drawing.Point(525, 204);\
this.button3.Name = \"button3\";\
this.button3.Size = new System.Drawing.Size(143, 42);\
this.button3.TabIndex = 16;\
this.button3.Text = \"Exit\";\
this.button3.UseVisualStyleBackColor = true;\
this.button3.Click += new System.EventHandler(this.button3_Click); //\
// button4\
//\
this.button4.Font = new System.Drawing.Font(\"Microsoft Sans Serif\",
10F, System.Drawing.FontStyle.Regular,
System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.button4.Location =
new System.Drawing.Point(81, 39);\
this.button4.Name = \"button4\";\
this.button4.Size = new System.Drawing.Size(143, 42);\
this.button4.TabIndex = 17;\
this.button4.Text = \"Date today \";\
this.button4.UseVisualStyleBackColor = true;\
this.button4.Click += new System.EventHandler(this.button4_Click); //\
// IP\
//\
this.ClientSize = new System.Drawing.Size(1071, 477);\
this.Controls.Add(this.button4);\
this.Controls.Add(this.button3);\
this.Controls.Add(this.button2);\
this.Controls.Add(this.label2);\
this.Controls.Add(this.textBox1);\
this.Controls.Add(this.button1);\
this.Name = \"IP\";\
this.Text = \"IP4- Validator\";

this.Load += new System.EventHandler(this.IP_Load);\
this.ResumeLayout(false);\
this.PerformLayout();\
}\
privatevoid IP_Load(object sender, EventArgs e)\
{\
}\
privatevoid label1_Click(object sender, EventArgs e)\
{\
}\
privatevoid textBox1_TextChanged(object sender, EventArgs e)\
{\
}\
privatevoid textBox2_TextChanged(object sender, EventArgs e)\
{\
//DateTime currentDateTime = DateTime.Today;\
//Text = currentDateTime.ToLongDateString();\
//MessageBox.Show(currentDateTime.ToLongDateString());\
}\
privatevoid button3_Click(object sender, EventArgs e)\
{\
{\
if (MessageBox.Show(\"Do you want quit application IP Validator ?\",
\"Exit?\", MessageBoxButtons.YesNo).ToString() == \"Yes\")\
{ Application.Exit(); }\
}\
}\
privatevoid button2_Click(object sender, EventArgs e)\
{\
textBox1.Text = String.Empty;\
}\
privatevoid button1_Click(object sender, EventArgs e)\
{\
string IP = textBox1.Text;\
//IPAddress IP;\
System.Text.RegularExpressions.Regex expr = new\
System.Text.RegularExpressions.Regex(@\"\\b(?:(?:25\[0-5\]\|2\[0-4\]\[0-9\]\|\[01\]?\[0-9\]\[0-9\]?)\\.){3}(?:25\[0-5\]\|2\[0-4\]\[0-9\]\|\[01\]?\[0-9\]\[0-9\]?)\\b\");\
if (expr.IsMatch(IP))\
MessageBox.Show(IP+ \"\\n\\n\"+\"The IP this correct\", \"Valid IP\");
else\
{\
MessageBox.Show(IP + \"\\n\\n\"+\"The IP must have 4 bytes\" +
\"\\n\\n\"+ \"integer number between 0 to 255\" + \"\\n\\n\"+

\"separated by a dot (255.255.255.255)\", \"ERROR\"); }\
}\
privatevoid button4_Click(object sender, EventArgs e)\
{\
DateTime currentDateTime = DateTime.Today;\
MessageBox.Show(currentDateTime.ToLongDateString()); }\
}\
}

**D.Present the classes and/or methods that you create or you did use in
the project.**

+----------------------------------+----------------------------------+
| Class/method/name                | Description                      |
+==================================+==================================+
| Random()                         | Represents a pseudo-random       |
|                                  | number generator, which is an    |
|                                  | algorithm that                   |
|                                  |                                  |
|                                  | produces a sequence of numbers   |
|                                  | that meet certain statistical    |
|                                  | requirements for                 |
|                                  |                                  |
|                                  | randomness.                      |
+----------------------------------+----------------------------------+
| FileStream                       | Provides a Stream for a file,    |
|                                  | supporting both synchronous and  |
|                                  | asynchronous                     |
|                                  |                                  |
|                                  | read and write operations.       |
+----------------------------------+----------------------------------+
| DateTime.Now.ToShortDateString() | Converts the value of the        |
|                                  | current DateTime object to its   |
|                                  | equivalent short date            |
|                                  |                                  |
|                                  | string representation.           |
+----------------------------------+----------------------------------+
| FileNotFoundException            | The exception that is thrown     |
|                                  | when an attempt to access a file |
|                                  | that does not                    |
|                                  |                                  |
|                                  | exist on disk fails.             |
+----------------------------------+----------------------------------+
| FileMode.Open                    | Opens a FileStream on the        |
|                                  | specified path.                  |
+----------------------------------+----------------------------------+
| FileAccess.Read                  | Read access to the file. Data    |
|                                  | can be read from the file.       |
|                                  | Combine with Write for           |
|                                  |                                  |
|                                  | read/write access.               |
+----------------------------------+----------------------------------+
| Peek()                           | Returns the object at the top of |
|                                  | the Stack without removing it.   |
+----------------------------------+----------------------------------+
| MessageBox.Show                  | Displays a message box.          |
+----------------------------------+----------------------------------+
| !Directory.Exists                | Determines whether the given     |
|                                  | path refers to an existing       |
|                                  | directory on disk.               |
+----------------------------------+----------------------------------+
| .Show()                          | > Displays the control to the    |
|                                  | > user. Showing the control is   |
|                                  | > equivalent to setting the      |
|                                  | > Visible property to true.      |
|                                  | > After the Show method is       |
|                                  | > called, the Visible property   |
|                                  | > returns a value of true until  |
|                                  | > the Hide method is called.     |
+----------------------------------+----------------------------------+

+---------------------+-----------------------------------------------+
| Application.Exit(); | Informs all message pumps that they must      |
|                     | terminate, and then closes all                |
|                     |                                               |
|                     | application windows after the messages have   |
|                     | been processed.                               |
+---------------------+-----------------------------------------------+

**E.Present the difficulties that you have, what was the hardest and the
easiest part of your project.**

> One of the biggest difficulties was to return the functionalities to
> methods and to find the

specific C \# functionalities for each need.
