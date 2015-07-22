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

//

namespace MultimediaWork
{
   
    public partial class Form1 : Form
    {

        public int[,] bmarray = new int[65, 65];  //主畫格array
        public double[,] DCTarray = new double[65, 65];  //DCT畫格array
        public double[,] IDCTarray = new double[65, 65];  //IDCT畫格array
        public string[,] Qtbarray = new string[65, 65];  //Qtable array
        int rawSize = 64;   //  限定 64x64
        Bitmap bm;  //畫布
        double pi = Math.PI;
      
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //檔案讀取 .raw .jpg .tif .bmp
            openFileDialog1.Filter = "RAW files (*.raw)|*.raw|JPEG files (*.jpg)|*.jpg|TIFF files (*.tif)|*.tif|BMP files (*.bmp)|*.bmp";
            openFileDialog1.FileName = @"請選擇raw檔";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3, 3) == "raw")
                {  
                    FileStream infile = File.Open(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    //this.Text = openFileDialog1.FileName;
                    //rawSize = (int)Math.Sqrt(infile.Length);

                    BinaryReader sr = new BinaryReader(infile);
                    byte input;
                    for (int i = 0; i < rawSize; i++)
                    {
                        for (int j = 0; j < rawSize; j++)
                        {
                            input = sr.ReadByte();
                            bmarray[i,j] = (int)input;
                        }
                    }

                    sr.Close();
                    //將 .raw 讀進 bmarray[i,j]
                    pic1_Paint(); // 畫出來  畫進 pic1(原始照片)
                }
                else
                {
                    bm = new Bitmap(openFileDialog1.FileName+"檔案錯誤");
                    //this.Text =openFileDialog1.FileName;
                }

            }

        }


        private void pic1_Paint()  //畫出PIC1(原始照片)
        {
            labelLog.Text = "";
            bm = new Bitmap(rawSize * 2, rawSize * 2);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格

                    bm.SetPixel(2 * j, 2 * i, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    bm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    bm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    bm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                }
            }
            picBox.Image = bm;
        }

   

        //讀取指定路徑檔案 .raw
        private void R1_CheckedChanged(object sender, System.EventArgs e)
        {
            //FileStream infile = new FileStream(@"..\RawData\baboon64.raw", FileMode.Open);
            
            try
            {
                FileStream infile = new FileStream(@"RawData\baboon64.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;
             
            }
        }

        private void R2_CheckedChanged(object sender, System.EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\circle1.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R3_CheckedChanged(object sender, System.EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\circle2.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///  
        }

        private void R4_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\circle3.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R5_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\gra1.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R6_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\gra2.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R7_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\lena64.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R8_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\pepper64.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R9_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\triangle.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }

        private void R10_CheckedChanged(object sender, EventArgs e)
        {
            ///
            try
            {
                FileStream infile = new FileStream(@"RawData\wildcard.raw", FileMode.Open);
                BinaryReader sr = new BinaryReader(infile);
                byte input;
                for (int i = 0; i < rawSize; i++)
                {
                    for (int j = 0; j < rawSize; j++)
                    {
                        input = sr.ReadByte();
                        bmarray[i, j] = (int)input;
                    }
                }
                sr.Close();
                pic1_Paint();
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            ///
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // button2.Enabled = false;
            //labelLog.Text = "HI! TEST";
            Form1 f1 = this;
            Form2 f2 = new Form2();
            f2.f2bmarray = this.bmarray;
            //f2.f2DCTarray = this.DCTarray;
            f2.f1 = this;
            f2.Show();
        }

        private void DCT_Click(object sender, EventArgs e)
        {
            //double pi = 3.1415926535;
           
            // public int[,] DCTarray = new int[65, 65];  //主畫格array
           // double cosAngle = Math.Cos(pi);
           
            Dct();
            dct_Paint();
            IDCT.Enabled = true;

        }

        private void Dct()
        {


            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    DCTarray[i, j] = ( c_dct(i) * c_dct(j)  * SIGMA_DCT(i,j))/32;
                    //DCTarray[i, j] = SIGMA_DCT(i, j);
                   
                }
            }


        }

        double SIGMA_DCT(int u, int v)
        {
            double s = 0;
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    s = s + bmarray[i, j] * Math.Cos((2 * i + 1) * u * pi / 128) * Math.Cos((2 * j + 1) * v * pi / 128);
                    
                }
            }

            return s;
        }

        private void IDct()
        {


            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    IDCTarray[i, j] = SIGMA_IDCT(i, j) / 32;
                    //DCTarray[i, j] = SIGMA_DCT(i, j);

                }
            }


        }
        double SIGMA_IDCT(int i, int j)
        {
            double s = 0;
            for (int u = 0; u < 64; u++)
            {
                for (int v = 0; v < 64; v++)
                {
                   
                    s = s + c_dct(u) * c_dct(v) * DCTarray[u, v] * Math.Cos((2 * i + 1) * u * pi / 128) * Math.Cos((2 * j + 1) * v * pi / 128);

                }
            }

            return s;
        }
        /*
        double f_dct(int i, int j)
        {
            double f = 0 ;
            for (int x = 0; x < 64; x++)
            {
                for (int y = 0; y < 64; y++)
                {
                    f = f + c_dct(x) * c_dct(y) * Math.Cos((2 * i + 1) * x * pi / 128) * Math.Cos((2 * j + 1) * y * pi / 128);
                    //f = 1;
                }
            }
            f = f * 2 / 64;
            return f;
        }
        */

        double c_dct(int nu)
        {
            double c ;
            if (nu == 0) c = (1 / Math.Sqrt(2));
            else c = 1;
        
        return c;
        }

        private void dct_Paint()  //畫出DCT
        {
            Bitmap dctbm;  
            dctbm = new Bitmap(rawSize * 2, rawSize * 2);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格
                    int pix = (int)DCTarray[i, j] + 128;
                    if (pix > 255) pix = 255;
                    if (pix < 0) pix = 0;
                    dctbm.SetPixel(2 * j, 2 * i, Color.FromArgb(pix,pix,pix));
                    dctbm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb(pix, pix, pix));
                    dctbm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb(pix, pix, pix));
                    dctbm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb(pix, pix, pix));
                }
            }
            dctbox.Image = dctbm;
        }


        /*備分
         *      private void dct_Paint()  //畫出DCT
        {
            Bitmap dctbm;  
            dctbm = new Bitmap(rawSize * 2, rawSize * 2);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格
                   pix
                    DCTarray[i, j] += 128;
                    if (DCTarray[i, j] > 255) DCTarray[i, j] = 255;
                    if (DCTarray[i, j] < 0) DCTarray[i, j] = 0;
                    dctbm.SetPixel(2 * j, 2 * i, Color.FromArgb((int)DCTarray[i, j], (int)DCTarray[i, j], (int)DCTarray[i, j]));
                    dctbm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb((int)DCTarray[i, j], (int)DCTarray[i, j], (int)DCTarray[i, j]));
                    dctbm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb((int)DCTarray[i, j], (int)DCTarray[i, j], (int)DCTarray[i, j]));
                    dctbm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb((int)DCTarray[i, j], (int)DCTarray[i, j], (int)DCTarray[i, j]));
                }
            }
            dctbox.Image = dctbm;
        }*/

        private void IDCT_Click(object sender, EventArgs e)
        {
            IDct();
            idct_Paint();
        }

        private void idct_Paint()  //畫出IDCT
        {
            Bitmap idctbm;
            idctbm = new Bitmap(rawSize * 2, rawSize * 2);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格
                    //IDCTarray[i, j] += 128;
                    if (IDCTarray[i, j] > 255) IDCTarray[i, j] = 255;
                    if (IDCTarray[i, j] < 0) IDCTarray[i, j] = 0;
                    idctbm.SetPixel(2 * j, 2 * i, Color.FromArgb((int)IDCTarray[i, j], (int)IDCTarray[i, j], (int)IDCTarray[i, j]));
                    idctbm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb((int)IDCTarray[i, j], (int)IDCTarray[i, j], (int)IDCTarray[i, j]));
                    idctbm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb((int)IDCTarray[i, j], (int)IDCTarray[i, j], (int)IDCTarray[i, j]));
                    idctbm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb((int)IDCTarray[i, j], (int)IDCTarray[i, j], (int)IDCTarray[i, j]));
                }
            }
            idctbox.Image = idctbm;
        }

        private void Qt_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                StreamReader reader = new StreamReader(File.OpenRead(@"RawData\Qtable.csv"));
                i = 0;
                while (!reader.EndOfStream)
                {
                   
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        for(int j=0;j<rawSize;j++)
                           Qtbarray[i, j]=values[j];
                           
                        }
                    i++;
                    }
                }
                
                
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
        }

 
    }
}



