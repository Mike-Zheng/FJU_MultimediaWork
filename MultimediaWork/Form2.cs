using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultimediaWork
{
    public partial class Form2 : Form
    {
        //宣告form2的property，使其能控制form1，記得使用public
        public Form1 f1;
        int rawSize = 64;
       // public F1Data data;
        public int[,] f2bmarray = new int[65, 65];//NOT USE
        //public double[,] f2DCTarray = new double[65, 65];//NOT USE
        public Form2()
        {
            InitializeComponent();
           // printNum();
        }

        private void printNumtext()
        {
           
            textBox1.Text="";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //textBox1.Text = textBox1.Text + f2bmarray[i,j]+ " ";
                    //Console.WriteLine(lower.ToUpper());
                    //textBox1.Text = textBox1.Text +"0"+ Convert.ToString(f2bmarray[i, j], 16) + " "; }
                    string t = Convert.ToString(f1.bmarray[i, j], 16);
                    
                    if (t.Length == 1)
                    { textBox1.Text = textBox1.Text +"0"+ t.ToUpper() + " "; }
                    else
                    { textBox1.Text = textBox1.Text + t.ToUpper() + " "; }
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        
        }
        /*
        private void printNum()
        {
           
            int rawSize = 64;
            Label[,] labAryB = new Label[65,65];
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    labAryB[i, j] = new Label();
                    labAryB[i, j].Text = "FF";
                    labAryB[i, j].Location = new System.Drawing.Point(20*i, 20*j);
                    labAryB[i, j].Size = new Size(20, 20);

                    this.Controls.Add(labAryB[i, j]);
                }
            }
           
           
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            
            printNumtext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDCTNumtext();
        }

        private void printDCTNumtext()
        {

            textBox1.Text = "";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //textBox1.Text = textBox1.Text + f2bmarray[i,j]+ " ";
                    //Console.WriteLine(lower.ToUpper());
                    //textBox1.Text = textBox1.Text +"0"+ Convert.ToString(f2bmarray[i, j], 16) + " "; }
                    string t = Convert.ToString((int)(f1.DCTarray[i, j]), 16);

                    if (t.Length == 1)
                    { textBox1.Text = textBox1.Text + "0" + t.ToUpper() + " "; }
                    else
                    { textBox1.Text = textBox1.Text + t.ToUpper() + " "; }
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }

        }


        /*
        private void printDCTNum()
        {

            int rawSize = 64;
            Label[,] labAryB = new Label[65, 65];
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    labAryB[i, j] = new Label();
                    labAryB[i, j].Text = "FF";
                    labAryB[i, j].Location = new System.Drawing.Point(20 * i, 20 * j);
                    labAryB[i, j].Size = new Size(20, 20);

                    this.Controls.Add(labAryB[i, j]);
                }
            }


        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            printIDCTNumtext();
        }


        private void printIDCTNumtext()
        {

            textBox1.Text = "";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //textBox1.Text = textBox1.Text + f2bmarray[i,j]+ " ";
                    //Console.WriteLine(lower.ToUpper());
                    //textBox1.Text = textBox1.Text +"0"+ Convert.ToString(f2bmarray[i, j], 16) + " "; }
                    string t = Convert.ToString((int)(f1.IDCTarray[i, j]), 16);

                    if (t.Length == 1)
                    { textBox1.Text = textBox1.Text + "0" + t.ToUpper() + " "; }
                    else
                    { textBox1.Text = textBox1.Text + t.ToUpper() + " "; }
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }

        }

        /*

        private void printIDCTNum()
        {

            int rawSize = 64;
            Label[,] labAryB = new Label[65, 65];
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    labAryB[i, j] = new Label();
                    labAryB[i, j].Text = "FF";
                    labAryB[i, j].Location = new System.Drawing.Point(20 * i, 20 * j);
                    labAryB[i, j].Size = new Size(20, 20);

                    this.Controls.Add(labAryB[i, j]);
                }
            }


        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            printQtable();
        }

         private void printQtable()
        {

            textBox1.Text = "";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //textBox1.Text = textBox1.Text + f2bmarray[i,j]+ " ";
                    //Console.WriteLine(lower.ToUpper());
                    //textBox1.Text = textBox1.Text +"0"+ Convert.ToString(f2bmarray[i, j], 16) + " "; }
                    string t = (f1.Qtbarray[i, j]);

                   
                   textBox1.Text = textBox1.Text +t + " "; }
                  
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }

        



    }
}