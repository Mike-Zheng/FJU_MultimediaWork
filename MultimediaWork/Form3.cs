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

namespace MultimediaWork
{
    public partial class Form3 : Form
    {
        //宣告form3的property，使其能讀取form1
        public Form1 f1;

        public int[,] Rarray = new int[256, 256];  //Lena256 Rarray
        public int[,] Garray = new int[256, 256];  //Lena256 Garray
        public int[,] Barray = new int[256, 256];  //Lena256 Barray
        public double[,] CBarray = new double[256, 256];  //Lena256 Cbarray
        public double[,] CRarray = new double[256, 256];  //Lena256 Crarray
        public double[,] Yarray = new double[256, 256];  //Lena256 Yarray

        public Form3()
        {
            InitializeComponent();
           
        }


        private void Print1()   //畫出Lena256第一個畫布
        {
            Bitmap pic1;
            pic1 = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    int R = (int)Rarray[i, j];
                    if (R > 255) R = 255;else if (R < 0) R = 0;
                    int G = (int)Garray[i, j];
                    if (G > 255) G = 255; else if (G < 0) G = 0;
                    int B = (int)Barray[i, j];
                    if (B > 255) B = 255; else if (B < 0) B = 0;

                    pic1.SetPixel(j, i, Color.FromArgb(R, G, B));
                   
                }
            }
            pBox1.Image = pic1;
        }

        private void Print2()  //畫出Lena256 第二個畫布
        {
            Bitmap pic2;
            pic2 = new Bitmap(256, 256);
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    //做轉換
                    //R = Y + 1.402Cr
                    //G = Y − 0.344Cb − 0.714Cr
                    //B = Y + 1.772Cb

                    int R = (int)(Yarray[i, j]+1.402*CRarray[i, j]);
                    if (R > 255) R = 255; else if (R < 0) R = 0;
                    int G = (int)(Yarray[i, j] - 0.344*CBarray[i, j] - 0.714*CRarray[i, j]);
                    if (G > 255) G = 255; else if (G < 0) G = 0;
                    int B = (int)(Yarray[i, j] + 1.772* CBarray[i, j]);
                    if (B > 255) B = 255; else if (B < 0) B = 0;

                    pic2.SetPixel(j, i, Color.FromArgb(R, G, B));
                }
            }
            pBox2.Image = pic2;
        }

        private void loadlena_Click(object sender, EventArgs e) //讀取Lena256
        {
            try
            {
                FileStream infile = new FileStream(@"RawData\lena_color256.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256 * 3; j++)
                    {
                        input = sr.ReadByte();
                        if (j % 3 == 0) Rarray[i, j / 3] = (int)input;
                        else if (j % 3 == 1) Garray[i, j / 3] = (int)input;
                        else if (j % 3 == 2) Barray[i, j / 3] = (int)input;

                    }
                }
                sr.Close();
                Print1();
            }
            catch (FileNotFoundException ioEx)
            {
                //如果檔案不在 
                Console.WriteLine(ioEx.Message); 
                labelLog.Text = ioEx.Message;

            }
        }

        private void RGBtoYRB_Click(object sender, EventArgs e)
        {

             for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256 ; j++)
                    {
                       Yarray[i,j] = 0.299*Rarray[i,j] + 0.587*Garray[i,j] + 0.114*Barray[i,j];
                       CBarray[i,j] = 0.564*(Barray[i,j]-Yarray[i,j] );
                       CRarray[i,j] = 0.713*(Rarray[i,j]-Yarray[i,j] );
                    }
                }
             To4_2_0();//作4:2:0 4個Y只留1個Cr和1個Cb
             Print2();
        }


        private void To4_2_0() //To 4:2:0
        {

            //將256*256 分成 16*16個Marco Block
            //再予以保留一等份Cb Cr  //To4_2_0convert(i, j);


            //[i,j]
            //  [0,0] [0,1]..
            //  [1,0] [1,1]..
            //  [2,0] [2,1]..
            //  .............

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    To4_2_0convert(i, j); //傳遞 初始位子

                }
            }

        }

        private void To4_2_0convert(int x,int y)
        {
            //[x,y]

           

            x= x * 16;
            y = y * 16;
            //1個 Marco Block
            //    0-7    8-15
            //  [0保留] [1不要]..
            //  [2不要] [3不要]..

            //去除右邊(1)
            for (int i = x; i < 16+x; i++)
            {
                for (int j = y+8; j < 16+y; j++)
                {
                    CBarray[i, j] = CBarray[i, j-8];
                    CRarray[i, j] = CRarray[i, j-8];

                }
            }
            //去除下面邊(2)
            for (int i = x+8; i < 16 + x; i++)
            {
                for (int j = y ; j < 16 + y; j++)
                {
                    CBarray[i, j] = CBarray[i-8, j ];
                    CRarray[i, j] = CRarray[i-8, j ];

                }
            }

            //去除右下角(3)
            for (int i = x + 8; i < 16 + x; i++)
            {
                for (int j = y+8; j < 16 + y; j++)
                {
                    CBarray[i, j] = CBarray[i - 8, j-8];
                    CRarray[i, j] = CRarray[i - 8, j-8];

                }
            }

        }
     

    }
}