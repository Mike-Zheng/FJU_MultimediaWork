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
        public int[,] Qtbarray = new int[65, 65];  //Qtable array
        public int[,] DCQtbarray = new int[65, 65];  //DCT/Qtable array
        public int[] Rle= new int[4225]; //其實是Zig zag scanner用
        int rawSize = 64;   //  限定 64x64
        Bitmap bm;  //畫布
        double pi = Math.PI;
      
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists(@"RawData\"))
            {
                labelLog.Text = "讀取RawData目錄成功";
            }
            else labelLog.Text = "RawData目錄不存在";
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
            bm = new Bitmap(rawSize , rawSize);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    bm.SetPixel(j, i, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    //放大成兩倍1格變4格
                    /*
                    bm.SetPixel(2 * j, 2 * i, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    bm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    bm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                    bm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb(bmarray[i, j], bmarray[i, j], bmarray[i, j]));
                     * */
                }
            }
            picBox.Image = bm;
        }


        private void pic2_Paint(double[,] arr)  //畫出DCT
        {
            Bitmap dctbm;
            dctbm = new Bitmap(rawSize, rawSize);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                   
                    int pix = (int)arr[i, j]+128;
                    if (pix > 255) pix = 255;
                    if (pix < 0) pix = 0;
                    dctbm.SetPixel(j, i, Color.FromArgb(pix, pix, pix));
                 
                }
            }
            dctbox.Image = dctbm;
        }

        private void pic3_Paint(double[,] arr)  //畫出IDCT
        {
            Bitmap idctbm;
            idctbm = new Bitmap(rawSize, rawSize);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                  
                    int pix = (int)arr[i, j];
                    if (pix > 255) pix = 255;
                    if (pix < 0) pix = 0;
                    idctbm.SetPixel(j, i, Color.FromArgb(pix, pix, pix));

                }
            }
            idctbox.Image = idctbm;
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








        //DEBUG
        private void button2_Click(object sender, EventArgs e) //開啟DEBUG
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
            log.Text = "";
            Dct();
            //dct_Paint();
            pic2_Paint(DCTarray);
            IDCT.Enabled = true;
            Qt.Enabled = true;

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
      

        double c_dct(int nu)
        {
            double c ;
            if (nu == 0) c = (1 / Math.Sqrt(2));
            else c = 1;
        
        return c;
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
            log.Text = "";
            IDct();
            //idct_Paint();
            pic3_Paint(IDCTarray);
        }

 

        private void Qt_Click(object sender, EventArgs e)
        {

            //讀取Qtable BEGIN
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
                            Qtbarray[i, j] = Convert.ToInt32(values[j]);
                           
                        }
                    i++;
                    }
                }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                labelLog.Text = ioEx.Message;

            }
            //讀取Qtable END

            Qtable_Paint();
            IQID.Enabled = true;
            ZiZag.Enabled = true;


        }

        private void Qtable_Paint()  //畫出Q table
        {
            Bitmap Qmap;
            int Qtemp;
            Qmap = new Bitmap(rawSize , rawSize );
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格
                    //IDCTarray[i, j] += 128;
                    //IDCTarray[i, j]=  (int)IDCTarray[i, j] / Convert.ToInt32(Qtbarray[i, j]);
                   // DCTarray[i, j] = (int)DCTarray[i, j] /Qtbarray[i, j];
                    DCQtbarray[i, j] = (int)DCTarray[i, j] / Convert.ToInt32(Qtbarray[i, j]);
                    if (DCQtbarray[i, j] < 5 && DCQtbarray[i, j] > -5) DCQtbarray[i, j] = 0;
                    Qtemp = DCQtbarray[i, j];
                    if (Qtemp > 255) Qtemp = 255;
                    if (Qtemp < 0) Qtemp = 0;
                    Qmap.SetPixel(j,  i, Color.FromArgb(Qtemp, Qtemp, Qtemp));
                    /*
                    Qmap.SetPixel(2 * j, 2 * i, Color.FromArgb(Qtemp,Qtemp,Qtemp));
                    Qmap.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb(Qtemp, Qtemp, Qtemp));
                    Qmap.SetPixel(2 * j, 2 * i + 1, Color.FromArgb(Qtemp,Qtemp,Qtemp));
                    Qmap.SetPixel(2 * j + 1, 2 * i, Color.FromArgb(Qtemp,Qtemp,Qtemp));
                     * */
                }
            }
            dctbox.Image = Qmap;
        }

        private void IQID_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {

                    DCTarray[i, j] = DCQtbarray[i, j] * Convert.ToInt32(Qtbarray[i, j]);
                }
            }
            IDct();
            pic3_Paint(IDCTarray);
            log.Text = "Quantization ：-5~+5 都變成0";
        }


        private void ZiZag_Click(object sender, EventArgs e)
        {
            // public int[] Rle= new int[4225]; 
            int select = 0;
            int i=0, j = 0;
            log.Text = "請開啟Debug 裡的 RLE button";
            Rle[0] = (int)DCQtbarray[i, j];


            for (int r = 1; r < 4096; r++)
            {


                if (select == 0) 
                {
                 j++;
                 Rle[r] = (int)DCQtbarray[i, j];
                 select=1;
                }
                else if(select == 1)
                {
                    if (i == 63)
                    {
                        r--;
                        select = 4;
                    }
                    else if (j > 0)
                    {
                        i++; j--;
                        Rle[r] = (int)DCQtbarray[i, j];
                    }
                    else
                    {
                        r--;
                        select = 2;
                    }
                }

                else if(select == 2)
                {
                    i++;
                    Rle[r] = (int)DCQtbarray[i, j];
                    select = 3;
                }
                else if (select == 3)
                {
                     if (i > 0)
                    {
                        i--; j++;
                        Rle[r] = (int)DCQtbarray[i, j];
                    }
                    else if(i==0)
                    {
                        select = 0;
                        r--;
                    }
                    
                }

                else if (select ==4 )
                {
                    j++;
                    Rle[r] = (int)DCQtbarray[i, j];
                    select = 5;
                }
                else if (select ==5 )
                {

                     if (j == 63)
                    {
                        select = 6;
                        r--;
                    }
                     else if (i > 0)
                    {
                        i--; j++;
                        Rle[r] = (int)DCQtbarray[i, j];
                    }
                }
                else if (select ==6 )
                {
                    i++;
                    Rle[r] = (int)DCQtbarray[i, j];
                    select = 7;
                }
                else if (select ==7 )
                { 
                    if (i ==63)
                    {
                        select = 4;
                        r--;
                    }
                    else
                    {
                        i++; j--;
                        Rle[r] = (int)DCQtbarray[i, j];
                        
                    }
                }
              
            }

            labelLog.Text = "";


        }
        //64x64 END




        /// 8 *8 secter 切斷

        public double[,] DCTarray8 = new double[65, 65];  //DCT8畫格array
        public double[,] IDCTarray8 = new double[65, 65];  //DCT8畫格array
        private void DCT8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
            for(int j= 0; j<8;  j++)
                Dct8(i, j);
            } 

           // dct_Paint8();
            pic2_Paint(DCTarray8);
            IDCT8.Enabled = true;
            IDCT1.Enabled = true;
            IDCT2.Enabled = true;
            IDCT3.Enabled = true;
            IDCT4.Enabled = true;
            IDCT5.Enabled = true;
        }



        private void Dct8(int si,int sj)
        {  
            //  [0,0] [0,1]..
            //  [1,0] [1,1]..
            //  [2,0] [2,1]..
            //  .............

            int itemp = 0;
            int jtemp = 0;

            if (si == 0) itemp = 0;
            else if (si == 1) itemp = 8;
            else if (si == 2) itemp = 16;
            else if (si == 3) itemp = 24;
            else if (si == 4) itemp = 32;
            else if (si == 5) itemp = 40;
            else if (si == 6) itemp = 48;
            else if (si == 7) itemp = 56;

            if (sj == 0) jtemp = 0;
            else if (sj == 1) jtemp = 8;
            else if (sj == 2) jtemp = 16;
            else if (sj == 3) jtemp = 24;
            else if (sj == 4) jtemp = 32;
            else if (sj == 5) jtemp = 40;
            else if (sj == 6) jtemp = 48;
            else if (sj == 7) jtemp = 56;




            for (int i = itemp; i < itemp+8; i++)
            {
                for (int j = jtemp; j < jtemp+8; j++)
                {
                    DCTarray8[i, j] = (c_dct(i - itemp) * c_dct(j - jtemp) * SIGMA_DCT8(i - itemp, j - jtemp, itemp, jtemp)) / 4;
                    //DCTarray[i, j] = SIGMA_DCT(i, j);

                }
            }


        }

        double SIGMA_DCT8(int u, int v, int itemp, int jtemp)
        {
            double s = 0;
            for (int i = itemp; i < itemp+8; i++)
            {
                for (int j = jtemp; j < jtemp+8; j++)
                {
                    s = s + bmarray[i, j] * Math.Cos((2 * (i-itemp) + 1) * u * pi / 16) *( Math.Cos((2 * (j-jtemp) + 1) * v * pi / 16));

                }
            }

            return s;
        }




        private void IDCT8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    IDct8(i, j);
            } 
           // idct_Paint8();
            pic3_Paint(IDCTarray8);
        }

        private void IDct8(int si, int sj)
        {
            //  [0,0] [0,1]..
            //  [1,0] [1,1]..
            //  [2,0] [2,1]..
            //  .............

            int itemp = 0;
            int jtemp = 0;

            if (si == 0) itemp = 0;
            else if (si == 1) itemp = 8;
            else if (si == 2) itemp = 16;
            else if (si == 3) itemp = 24;
            else if (si == 4) itemp = 32;
            else if (si == 5) itemp = 40;
            else if (si == 6) itemp = 48;
            else if (si == 7) itemp = 56;

            if (sj == 0) jtemp = 0;
            else if (sj == 1) jtemp = 8;
            else if (sj == 2) jtemp = 16;
            else if (sj == 3) jtemp = 24;
            else if (sj == 4) jtemp = 32;
            else if (sj == 5) jtemp = 40;
            else if (sj == 6) jtemp = 48;
            else if (sj == 7) jtemp = 56;

            for (int i = itemp; i < itemp+8; i++)
            {
                for (int j = jtemp; j < jtemp+8; j++)
                {
                    IDCTarray8[i, j] = SIGMA_IDCT8(i - itemp, j-jtemp, itemp, jtemp) / 4;
                    //DCTarray[i, j] = SIGMA_DCT(i, j);

                }
            }


        }

        double SIGMA_IDCT8(int i, int j, int itemp, int jtemp)
        {
            double s = 0;
            for (int u = itemp; u < itemp+8; u++)
            {
                for (int v = jtemp; v < jtemp+8; v++)
                {

                    s = s + c_dct(u - itemp) * c_dct(v - jtemp) * DCTarray8[u, v] * Math.Cos((2 * i + 1) * (u - itemp) * pi / 16) * Math.Cos((2 * j + 1) * (v - jtemp) * pi / 16);

                }
            }

            return s;
        }

       


        /// <summary>
        /// //////////////////////////////////
        /// </summary>
        /// <param name="arr"></param>


        public double[,] arrb = new double[65, 65];

        private void IDct88(double[,] arr,int si, int sj)
        {
            //  [0,0] [0,1]..
            //  [1,0] [1,1]..
            //  [2,0] [2,1]..
            //  .............
            //int[,] arr = new int[65, 65];
           

            int itemp = 0;
            int jtemp = 0;

            if (si == 0) itemp = 0;
            else if (si == 1) itemp = 8;
            else if (si == 2) itemp = 16;
            else if (si == 3) itemp = 24;
            else if (si == 4) itemp = 32;
            else if (si == 5) itemp = 40;
            else if (si == 6) itemp = 48;
            else if (si == 7) itemp = 56;

            if (sj == 0) jtemp = 0;
            else if (sj == 1) jtemp = 8;
            else if (sj == 2) jtemp = 16;
            else if (sj == 3) jtemp = 24;
            else if (sj == 4) jtemp = 32;
            else if (sj == 5) jtemp = 40;
            else if (sj == 6) jtemp = 48;
            else if (sj == 7) jtemp = 56;

            for (int i = itemp; i < itemp + 8; i++)
            {
                for (int j = jtemp; j < jtemp + 8; j++)
                {
                    arrb[i, j] = SIGMA_IDCT88(arr ,i - itemp, j - jtemp, itemp, jtemp) / 4;
                    //DCTarray[i, j] = SIGMA_DCT(i, j);

                }
            }

            
        }

        double SIGMA_IDCT88(double [,]arr,int i, int j, int itemp, int jtemp)
        {
            double s = 0;
            for (int u = itemp; u < itemp + 8; u++)
            {
                for (int v = jtemp; v < jtemp + 8; v++)
                {

                    s = s + c_dct(u - itemp) * c_dct(v - jtemp) * arr[u, v] * Math.Cos((2 * i + 1) * (u - itemp) * pi / 16) * Math.Cos((2 * j + 1) * (v - jtemp) * pi / 16);

                }
            }

            return s;
        }

       
        private void IDCT1_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[65, 65];

            for (int i=0;i<64;i++) 
              for(int j=0;j<64;j++)
                 arr[i,j]=DCTarray8[i, j];


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    arr=dec(arr, 1, i, j);

            Paintre8(arr);


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                     IDct88(arr, i, j);


            Paint8(arrb);


        }




        private double[,] dec(double[,] arr, int type, int si, int sj)
        {
           
            //  [0,0] [0,1]..
            //  [1,0] [1,1]..
            //  [2,0] [2,1]..
            //  .............

            int itemp = 0;
            int jtemp = 0;

            if (si == 0) itemp = 0;
            else if (si == 1) itemp = 8;
            else if (si == 2) itemp = 16;
            else if (si == 3) itemp = 24;
            else if (si == 4) itemp = 32;
            else if (si == 5) itemp = 40;
            else if (si == 6) itemp = 48;
            else if (si == 7) itemp = 56;

            if (sj == 0) jtemp = 0;
            else if (sj == 1) jtemp = 8;
            else if (sj == 2) jtemp = 16;
            else if (sj == 3) jtemp = 24;
            else if (sj == 4) jtemp = 32;
            else if (sj == 5) jtemp = 40;
            else if (sj == 6) jtemp = 48;
            else if (sj == 7) jtemp = 56;

            double co00 = arr[itemp, jtemp];
            double co01 = arr[itemp, jtemp + 1];
            double co10 = arr[itemp + 1, jtemp];
            double co02 = arr[itemp, jtemp + 2];
            double co11 = arr[itemp + 1, jtemp + 1];
            double co20 = arr[itemp + 2, jtemp];


            for (int i = itemp; i < itemp + 8; i++)
            {
                for (int j = jtemp; j < jtemp + 8; j++)
                {
                     arr[i, j] = 0;

                }
            }

            if (type == 1)
            {
                arr[itemp, jtemp] = co00;
            
            }
            else if (type == 2)
            {
                arr[itemp, jtemp] = co00;
                arr[itemp, jtemp+1] = co01;
                arr[itemp+1, jtemp] = co10;
            }
            else if (type == 3)
            {
                arr[itemp, jtemp] = co00;
                arr[itemp, jtemp + 1] = co01;
                arr[itemp + 1, jtemp] = co10;
                arr[itemp, jtemp+2] = co02;
                arr[itemp+1, jtemp + 1] = co11;
                arr[itemp + 2, jtemp] = co20;
            }
            else if (type == 4)
            {
                arr[itemp, jtemp] = co00;
                arr[itemp, jtemp+1] = co01;
                arr[itemp, jtemp+2] = co02;
            }
            else if (type == 5)
            {
                arr[itemp, jtemp] = co00;
                arr[itemp+1, jtemp] = co10;
                arr[itemp+2, jtemp] = co20;
            }




            return arr;
        }

        private void IDCT2_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[65, 65];

            for (int i = 0; i < 64; i++)
                for (int j = 0; j < 64; j++)
                    arr[i, j] = DCTarray8[i, j];


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    arr = dec(arr, 2, i, j);

            Paintre8(arr);


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    IDct88(arr, i, j);


            Paint8(arrb);

        }

        private void IDCT3_Click(object sender, EventArgs e)
        {
            double [,] arr = new double[65, 65];

            for (int i = 0; i < 64; i++)
                for (int j = 0; j < 64; j++)
                    arr[i, j] = DCTarray8[i, j];


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    arr = dec(arr, 3, i, j);

            Paintre8(arr);


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    IDct88(arr, i, j);


            Paint8(arrb);

        }

        private void IDCT4_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[65, 65];

            for (int i = 0; i < 64; i++)
                for (int j = 0; j < 64; j++)
                    arr[i, j] = DCTarray8[i, j];


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    arr = dec(arr, 4, i, j);

            Paintre8(arr);


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    IDct88(arr, i, j);


            Paint8(arrb);


        }

        private void IDCT5_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[65, 65];

            for (int i = 0; i < 64; i++)
                for (int j = 0; j < 64; j++)
                    arr[i, j] = DCTarray8[i, j];


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    arr = dec(arr, 5, i, j);

            Paintre8(arr);


            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    IDct88(arr, i, j);


            Paint8(arrb);

        }

        private void Paintre8(double[,] arr) 
        {
            Bitmap dctbm;
            dctbm = new Bitmap(rawSize, rawSize);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格
                    int pix = (int)arr[i, j];
                    if (pix > 255) pix = 255;
                    if (pix < 0) pix = 0;
                    dctbm.SetPixel(j, i, Color.FromArgb(pix, pix, pix));
                    /*
                    dctbm.SetPixel(2 * j, 2 * i, Color.FromArgb(pix, pix, pix));
                    dctbm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb(pix, pix, pix));
                    dctbm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb(pix, pix, pix));
                    dctbm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb(pix, pix, pix));
                     */
                }
            }
            dctbox.Image = dctbm;
        }

        private void Paint8(double[,] arr)  
        {
            Bitmap idctbm;
            idctbm = new Bitmap(rawSize, rawSize);
            for (int i = 0; i < rawSize; i++)
            {
                for (int j = 0; j < rawSize; j++)
                {
                    //放大成兩倍1格變4格
                    int pix = (int)arr[i, j];
                    if (pix > 255) pix = 255;
                    if (pix < 0) pix = 0;
                    idctbm.SetPixel(j, i, Color.FromArgb(pix, pix, pix));
                    /*
                    idctbm.SetPixel(2 * j, 2 * i, Color.FromArgb(pix, pix, pix));
                    idctbm.SetPixel(2 * j + 1, 2 * i + 1, Color.FromArgb(pix, pix, pix));
                    idctbm.SetPixel(2 * j, 2 * i + 1, Color.FromArgb(pix, pix, pix));
                    idctbm.SetPixel(2 * j + 1, 2 * i, Color.FromArgb(pix, pix, pix));
                     * */
                }
            }
            idctbox.Image = idctbm;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void oplena_Click(object sender, EventArgs e)
        {

            // button2.Enabled = false;
            //labelLog.Text = "HI! TEST";
            Form1 f1 = this;
            Form3 f3 = new Form3();
           
          
            f3.f1 = this;
            f3.Show();
        }
        





 
    }
}



