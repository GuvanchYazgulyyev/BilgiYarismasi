using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarismasi_ders_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int dogry = 0;
        int yanys = 0;
        int süre = 10;
        private void Button5_Click(object sender, EventArgs e)
        {
            süre = 10;
            label10.Text = süre.ToString();

            timer1.Enabled = true;

            button5.Text = "İLERİ:";
            soruno++;
            label1.Text = soruno.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = " Türkmenistan Döwleti Naçinji yylda Garaşsyzlygyny aldy? ";
                button1.Text = "1990";
                button2.Text = "1995";
                button3.Text = "1991";
                button4.Text = "1992";
                label4.Text = "1991";
            }


            if (soruno == 2)
            {
                richTextBox1.Text = "Türkmenistan öz milli walýutasyny naçinji yylda girizdi?";
                button1.Text = "1993";
                button2.Text = "2000";
                button3.Text = "1991";
                button4.Text = "1995";
                label4.Text = "1993";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Orta Asya Seljukly döwletinin üçünjü hökümdary kimdir?";
                button1.Text = "Malik Şa";
                button2.Text = "Soltan Sanjar";
                button3.Text = "Togryl Beg";
                button4.Text = "Çagryl Beg";
                label4.Text = "Soltan Sanjar";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Gökdepe Söweşinde Naçe mün gahrymanlarymyz şehit boldy?";
                button1.Text = "7,000";
                button2.Text = "37,000";
                button3.Text = "25,000";
                button4.Text = "43,000";
                label4.Text = "43,000";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Naçinji Yylda Türkmenistan Döwleti daşary yurtlarda okayan talyplaryn Viza kartyna 147 $ limit goydy ?";
                button1.Text = "2010-2013";
                button2.Text = "2018-2019";
                button3.Text = "2016-2017";
                button4.Text = "2014-2015";
                label4.Text = "2018-2019";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Türkmenistan döwleti Garaşsyzlygyny alandan bari naçinji yylda ekenomikasy has ösdi? ";
                button1.Text = "2001-2005";
                button2.Text = "2008-2011";
                button3.Text = "2013-2016";
                button4.Text = "2017-2019";
                label4.Text = "2013-2016";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Türkmenistanda naçinji ylda kriziz başlady?";
                button1.Text = "2014";
                button2.Text = "2017";
                button3.Text = "2000";
                button4.Text = "2019";
                label4.Text = "2017";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Türkmenistan döwletinin naçe göterimi çölden ybarat?";
                button1.Text = "80%";
                button2.Text = "65%";
                button3.Text = "40%";
                button4.Text = "28%";
                label4.Text = "80%";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;


            timer1.Enabled = false;

            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                dogry++;
                label7.Text = dogry.ToString();
            }
            else
            {
                yanys++;
                label8.Text = yanys.ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;


            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                dogry++;
                label7.Text = dogry.ToString();
            }
            else
            {
                yanys++;
                label8.Text = yanys.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;


            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                dogry++;
                label7.Text = dogry.ToString();
            }
            else
            {
                yanys++;
                label8.Text = yanys.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;



            label3.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                dogry++;
                label7.Text = dogry.ToString();
            }
            else
            {
                label8.Text = yanys.ToString();
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label10.Text);
            süre = süre - 1;
            label10.Text = süre.ToString();

            if (süre == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                timer1.Enabled = false;
                yanys++;
                label8.Text = yanys.ToString();
            }
        }
    }
}
