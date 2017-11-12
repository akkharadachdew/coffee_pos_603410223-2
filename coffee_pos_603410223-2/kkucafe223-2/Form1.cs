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

namespace kkucafe223_2
{
    public partial class Form1 : Form
    {
        int A = 0, B = 1;
        double Totle;
        string[] Menu = new string[50];
        string[] Bth = new string[50];
        string w, dd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "MilkTea Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Espresso Hot";
            Bth[A] = "35";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();

        }
        public void dew()
        {
            ListViewItem dew123 = new ListViewItem();
            dew123.Text = Menu[A];
            dew123.SubItems.Add(Bth[A]);
            d1.Items.Add(dew123);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Espresso Ice";
            Bth[A] = "45";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Espresso Frappe";
            Bth[A] = "50";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Americano Hot";
            Bth[A] = "35";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Americano Ice";
            Bth[A] = "45";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Latte Hot";
            Bth[A] = "35";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Latte Ice";
            Bth[A] = "45";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Latte Frappe";
            Bth[A] = "50";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Mocha Hot";
            Bth[A] = "35";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Mocha Ice";
            Bth[A] = "45";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Mocha Frappe";
            Bth[A] = "50";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Totle += 35;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cappuccino Hot";
            Bth[A] = "35";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Totle += 45;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cappuccino Ice";
            Bth[A] = "45";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Totle += 50;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Cappuccino Frappe";
            Bth[A] = "50";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Totle = 0;
            d1.Items.Clear();
            textBox1.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "GreenTea Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "GreenTea Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "GreenTea Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "CoCoa  Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "CoCoa  Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "ThaiTea Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milk Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milk Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milk Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "MilkTea Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "LemonTea Ice";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "LemonTea Frappe";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milo Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milo Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Milo Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesCafe Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesCafe Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesCafe Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesteaTea Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesteaTea Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "NesteaTea Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Totle += 20;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Italian Soda Hot";
            Bth[A] = "20";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button41_Click(object sender, EventArgs e)
        {

            Totle += 25;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Italian Soda Ice";
            Bth[A] = "25";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Totle += 30;
            textBox1.Text = Totle.ToString() + ".00 บาท";
            Menu[A] = "Italian Soda Frappe";
            Bth[A] = "30";
            dd += Menu[A] + "     " + Bth[A] + Environment.NewLine;
            dew();
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูที่ต้องการ", "Warningl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("ต้องการทำรายการใช่หรือไม่", "!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            A = 0;
            textBox1.Text = "0";
            d1.Items.Clear();
            Totle = 0;
            File.WriteAllText("dew" + (B) + ".txt", dd);
            B++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            
        

 
           
        }
    }
}
