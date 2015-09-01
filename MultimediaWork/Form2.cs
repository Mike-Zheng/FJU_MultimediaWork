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
        public int[,] f2bmarray = new int[65, 65];
        public int[] RLE = new int[4096];   //RLE

        public Form2()
        {
            InitializeComponent();
        }

        private void printNumtext() //印出初始pix
        {
           
            textBox1.Text="";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    string t = Convert.ToString(f1.bmarray[i, j], 16);
                    
                    if (t.Length == 1)
                    { textBox1.Text = textBox1.Text +"0"+ t.ToUpper() + " "; }
                    else
                    { textBox1.Text = textBox1.Text + t.ToUpper() + " "; }
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        
        }

        private void button2_Click(object sender, EventArgs e)//印出初始pix
        {
            llog.Text = "讀取原始Raw 檔裡面的數值";
            printNumtext();
        }






        private void button1_Click(object sender, EventArgs e)//印出DCTpix
        {
            llog.Text = "DCT轉換得到的數值";
            printDCTNumtext();
        }

        private void printDCTNumtext()//印出DCTpix
        {

            textBox1.Text = "";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                   
                    string t = Convert.ToString((int)(f1.DCTarray[i, j]), 16);

                    if (t.Length == 1)
                    { textBox1.Text = textBox1.Text + "0" + t.ToUpper() + " "; }
                    else
                    { textBox1.Text = textBox1.Text + t.ToUpper() + " "; }
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }

        }




        private void button1_Click_1(object sender, EventArgs e)//印出IDCTpix
        {
            llog.Text = "IDCT 轉換得到的數值";
            printIDCTNumtext();
        }


        private void printIDCTNumtext()//印出IDCTpix
        {

            textBox1.Text = "";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                  
                    string t = Convert.ToString((int)(f1.IDCTarray[i, j]), 16);

                    if (t.Length == 1)
                    { textBox1.Text = textBox1.Text + "0" + t.ToUpper() + " "; }
                    else
                    { textBox1.Text = textBox1.Text + t.ToUpper() + " "; }
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }

        }



        private void button3_Click(object sender, EventArgs e)//印出量化表
        {
            llog.Text = "只是將..RawData.Qtable.csv 裡數值印出來";
            printQtable();
        }

        private void printQtable()//印出量化表
        {

            textBox1.Text = "";
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                   
                    string t = (f1.Qtbarray[i, j].ToString());

                   
                   textBox1.Text = textBox1.Text +t + " "; }
                  
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }


        private void button4_Click(object sender, EventArgs e) //印出DCT/Q
         {
             llog.Text = "將DCT值除量化表 後印出來"; 
            printDCQtable();
         }

        private void printDCQtable()//印出DCT/Q
         {

             textBox1.Text = "";
             for (int i = 0; i < rawSize; i++)
             {
                 for (int j = 0; j < rawSize; j++)
                 {
                     string t = (f1.DCQtbarray[i, j].ToString());

                     textBox1.Text = textBox1.Text + t + " ";
                 }
                 textBox1.Text = textBox1.Text + "\r\n";
             }
             
         }

        private void button5_Click(object sender, EventArgs e)//印出ZIGZAG
         {
             llog.Text = "印出ZigZag的array"; 
            printZI();
         }
        private void printZI()//印出ZIGZAG
         {

             textBox1.Text = "";
             for (int i = 0; i < 4096; i++)
             {
               
                     string t = (f1.Rle[i].ToString());
                     textBox1.Text = textBox1.Text + t + " ";
                 

             }
            
         }



         private void printRLE(int r)
         {

             textBox1.Text = "ZigZag 轉成RLE";
             for (int i = 0; i < r; i++)
             {

                 string t = (RLE[i].ToString());
                 if (i % 2 == 0) textBox1.Text = textBox1.Text + "("+t + ",";
                 if (i % 2 == 1) textBox1.Text = textBox1.Text +  t + ") ";

             }

         }

         private void RLE2_Click(object sender, EventArgs e)
         {
             llog.Text = "將";
             int r = 0,c=1;
             for (int i = 0; i < 4096; i++)
             {
                 
                 if (i != 0 && f1.Rle[i] == f1.Rle[i - 1])
                     c++;
                 else if(i!=0) { c = 1; r += 2; }
                 RLE[r] = c;
                 RLE[r + 1] = f1.Rle[i];


             }


             printRLE(r+2);
         }
         


    }
}