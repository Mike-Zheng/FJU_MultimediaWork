namespace MultimediaWork
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.R1 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.R3 = new System.Windows.Forms.RadioButton();
            this.R4 = new System.Windows.Forms.RadioButton();
            this.R5 = new System.Windows.Forms.RadioButton();
            this.R6 = new System.Windows.Forms.RadioButton();
            this.R7 = new System.Windows.Forms.RadioButton();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.R8 = new System.Windows.Forms.RadioButton();
            this.R9 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.R10 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dctbox = new System.Windows.Forms.PictureBox();
            this.DCT = new System.Windows.Forms.Button();
            this.IDCT = new System.Windows.Forms.Button();
            this.idctbox = new System.Windows.Forms.PictureBox();
            this.Qt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZiZag = new System.Windows.Forms.Button();
            this.IQID = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDCT8 = new System.Windows.Forms.Button();
            this.DCT8 = new System.Windows.Forms.Button();
            this.IDCT3 = new System.Windows.Forms.Button();
            this.IDCT2 = new System.Windows.Forms.Button();
            this.IDCT5 = new System.Windows.Forms.Button();
            this.IDCT4 = new System.Windows.Forms.Button();
            this.IDCT1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.oplena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idctbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始照片";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "另外開啟檔案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(29, 30);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(70, 16);
            this.R1.TabIndex = 2;
            this.R1.TabStop = true;
            this.R1.Text = "baboon64";
            this.R1.UseVisualStyleBackColor = true;
            this.R1.CheckedChanged += new System.EventHandler(this.R1_CheckedChanged);
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(29, 52);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(54, 16);
            this.R2.TabIndex = 2;
            this.R2.TabStop = true;
            this.R2.Text = "circle1";
            this.R2.UseVisualStyleBackColor = true;
            this.R2.CheckedChanged += new System.EventHandler(this.R2_CheckedChanged);
            // 
            // R3
            // 
            this.R3.AutoSize = true;
            this.R3.Location = new System.Drawing.Point(29, 74);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(54, 16);
            this.R3.TabIndex = 2;
            this.R3.TabStop = true;
            this.R3.Text = "circle2";
            this.R3.UseVisualStyleBackColor = true;
            this.R3.CheckedChanged += new System.EventHandler(this.R3_CheckedChanged);
            // 
            // R4
            // 
            this.R4.AutoSize = true;
            this.R4.Location = new System.Drawing.Point(29, 96);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(54, 16);
            this.R4.TabIndex = 2;
            this.R4.TabStop = true;
            this.R4.Text = "circle3";
            this.R4.UseVisualStyleBackColor = true;
            this.R4.CheckedChanged += new System.EventHandler(this.R4_CheckedChanged);
            // 
            // R5
            // 
            this.R5.AutoSize = true;
            this.R5.Location = new System.Drawing.Point(29, 118);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(44, 16);
            this.R5.TabIndex = 2;
            this.R5.TabStop = true;
            this.R5.Text = "gra1";
            this.R5.UseVisualStyleBackColor = true;
            this.R5.CheckedChanged += new System.EventHandler(this.R5_CheckedChanged);
            // 
            // R6
            // 
            this.R6.AutoSize = true;
            this.R6.Location = new System.Drawing.Point(29, 140);
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(44, 16);
            this.R6.TabIndex = 2;
            this.R6.TabStop = true;
            this.R6.Text = "gra2";
            this.R6.UseVisualStyleBackColor = true;
            this.R6.CheckedChanged += new System.EventHandler(this.R6_CheckedChanged);
            // 
            // R7
            // 
            this.R7.AutoSize = true;
            this.R7.Location = new System.Drawing.Point(29, 159);
            this.R7.Name = "R7";
            this.R7.Size = new System.Drawing.Size(54, 16);
            this.R7.TabIndex = 2;
            this.R7.TabStop = true;
            this.R7.Text = "lena64";
            this.R7.UseVisualStyleBackColor = true;
            this.R7.CheckedChanged += new System.EventHandler(this.R7_CheckedChanged);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(129, 36);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(65, 65);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // R8
            // 
            this.R8.AutoSize = true;
            this.R8.Location = new System.Drawing.Point(29, 181);
            this.R8.Name = "R8";
            this.R8.Size = new System.Drawing.Size(67, 16);
            this.R8.TabIndex = 4;
            this.R8.TabStop = true;
            this.R8.Text = "pepper64";
            this.R8.UseVisualStyleBackColor = true;
            this.R8.CheckedChanged += new System.EventHandler(this.R8_CheckedChanged);
            // 
            // R9
            // 
            this.R9.AutoSize = true;
            this.R9.Location = new System.Drawing.Point(29, 203);
            this.R9.Name = "R9";
            this.R9.Size = new System.Drawing.Size(58, 16);
            this.R9.TabIndex = 5;
            this.R9.TabStop = true;
            this.R9.Text = "triangle";
            this.R9.UseVisualStyleBackColor = true;
            this.R9.CheckedChanged += new System.EventHandler(this.R9_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(10, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "限定選擇64x64的.raw";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLog.Location = new System.Drawing.Point(12, 363);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(0, 12);
            this.labelLog.TabIndex = 0;
            // 
            // R10
            // 
            this.R10.AutoSize = true;
            this.R10.Location = new System.Drawing.Point(29, 225);
            this.R10.Name = "R10";
            this.R10.Size = new System.Drawing.Size(63, 16);
            this.R10.TabIndex = 6;
            this.R10.TabStop = true;
            this.R10.Text = "wildcard";
            this.R10.UseVisualStyleBackColor = true;
            this.R10.CheckedChanged += new System.EventHandler(this.R10_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "DEBUG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dctbox
            // 
            this.dctbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dctbox.Location = new System.Drawing.Point(264, 36);
            this.dctbox.Name = "dctbox";
            this.dctbox.Size = new System.Drawing.Size(65, 65);
            this.dctbox.TabIndex = 10;
            this.dctbox.TabStop = false;
            // 
            // DCT
            // 
            this.DCT.Location = new System.Drawing.Point(39, 3);
            this.DCT.Name = "DCT";
            this.DCT.Size = new System.Drawing.Size(94, 29);
            this.DCT.TabIndex = 11;
            this.DCT.Text = "DCT";
            this.DCT.UseVisualStyleBackColor = true;
            this.DCT.Click += new System.EventHandler(this.DCT_Click);
            // 
            // IDCT
            // 
            this.IDCT.Enabled = false;
            this.IDCT.Location = new System.Drawing.Point(39, 37);
            this.IDCT.Name = "IDCT";
            this.IDCT.Size = new System.Drawing.Size(94, 29);
            this.IDCT.TabIndex = 12;
            this.IDCT.Text = "IDCT";
            this.IDCT.UseVisualStyleBackColor = true;
            this.IDCT.Click += new System.EventHandler(this.IDCT_Click);
            // 
            // idctbox
            // 
            this.idctbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idctbox.Location = new System.Drawing.Point(400, 36);
            this.idctbox.Name = "idctbox";
            this.idctbox.Size = new System.Drawing.Size(65, 65);
            this.idctbox.TabIndex = 10;
            this.idctbox.TabStop = false;
            // 
            // Qt
            // 
            this.Qt.Enabled = false;
            this.Qt.Location = new System.Drawing.Point(151, 3);
            this.Qt.Name = "Qt";
            this.Qt.Size = new System.Drawing.Size(94, 29);
            this.Qt.TabIndex = 13;
            this.Qt.Text = "Quantization";
            this.Qt.UseVisualStyleBackColor = true;
            this.Qt.Click += new System.EventHandler(this.Qt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "64x64";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ZiZag);
            this.panel1.Controls.Add(this.IQID);
            this.panel1.Controls.Add(this.DCT);
            this.panel1.Controls.Add(this.Qt);
            this.panel1.Controls.Add(this.IDCT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(123, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 73);
            this.panel1.TabIndex = 14;
            // 
            // ZiZag
            // 
            this.ZiZag.Enabled = false;
            this.ZiZag.Location = new System.Drawing.Point(260, 3);
            this.ZiZag.Name = "ZiZag";
            this.ZiZag.Size = new System.Drawing.Size(94, 29);
            this.ZiZag.TabIndex = 15;
            this.ZiZag.Text = "Zig-Zag +RLE";
            this.ZiZag.UseVisualStyleBackColor = true;
            this.ZiZag.Click += new System.EventHandler(this.ZiZag_Click);
            // 
            // IQID
            // 
            this.IQID.Enabled = false;
            this.IQID.Location = new System.Drawing.Point(151, 37);
            this.IQID.Name = "IQID";
            this.IQID.Size = new System.Drawing.Size(94, 29);
            this.IQID.TabIndex = 14;
            this.IQID.Text = "IQ+IDCT";
            this.IQID.UseVisualStyleBackColor = true;
            this.IQID.Click += new System.EventHandler(this.IQID_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.IDCT8);
            this.panel2.Controls.Add(this.DCT8);
            this.panel2.Controls.Add(this.IDCT3);
            this.panel2.Controls.Add(this.IDCT2);
            this.panel2.Controls.Add(this.IDCT5);
            this.panel2.Controls.Add(this.IDCT4);
            this.panel2.Controls.Add(this.IDCT1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(123, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 103);
            this.panel2.TabIndex = 14;
            // 
            // IDCT8
            // 
            this.IDCT8.Enabled = false;
            this.IDCT8.Location = new System.Drawing.Point(39, 38);
            this.IDCT8.Name = "IDCT8";
            this.IDCT8.Size = new System.Drawing.Size(94, 27);
            this.IDCT8.TabIndex = 17;
            this.IDCT8.Text = "IDCT";
            this.IDCT8.UseVisualStyleBackColor = true;
            this.IDCT8.Click += new System.EventHandler(this.IDCT8_Click);
            // 
            // DCT8
            // 
            this.DCT8.Location = new System.Drawing.Point(39, 5);
            this.DCT8.Name = "DCT8";
            this.DCT8.Size = new System.Drawing.Size(94, 27);
            this.DCT8.TabIndex = 16;
            this.DCT8.Text = "DCT";
            this.DCT8.UseVisualStyleBackColor = true;
            this.DCT8.Click += new System.EventHandler(this.DCT8_Click);
            // 
            // IDCT3
            // 
            this.IDCT3.Enabled = false;
            this.IDCT3.Location = new System.Drawing.Point(151, 71);
            this.IDCT3.Name = "IDCT3";
            this.IDCT3.Size = new System.Drawing.Size(94, 27);
            this.IDCT3.TabIndex = 15;
            this.IDCT3.Text = "Top-left 6";
            this.IDCT3.UseVisualStyleBackColor = true;
            this.IDCT3.Click += new System.EventHandler(this.IDCT3_Click);
            // 
            // IDCT2
            // 
            this.IDCT2.Enabled = false;
            this.IDCT2.Location = new System.Drawing.Point(151, 38);
            this.IDCT2.Name = "IDCT2";
            this.IDCT2.Size = new System.Drawing.Size(94, 27);
            this.IDCT2.TabIndex = 15;
            this.IDCT2.Text = "Top-left 3 ";
            this.IDCT2.UseVisualStyleBackColor = true;
            this.IDCT2.Click += new System.EventHandler(this.IDCT2_Click);
            // 
            // IDCT5
            // 
            this.IDCT5.Enabled = false;
            this.IDCT5.Location = new System.Drawing.Point(260, 38);
            this.IDCT5.Name = "IDCT5";
            this.IDCT5.Size = new System.Drawing.Size(94, 27);
            this.IDCT5.TabIndex = 15;
            this.IDCT5.Text = "3 columns";
            this.IDCT5.UseVisualStyleBackColor = true;
            this.IDCT5.Click += new System.EventHandler(this.IDCT5_Click);
            // 
            // IDCT4
            // 
            this.IDCT4.Enabled = false;
            this.IDCT4.Location = new System.Drawing.Point(260, 5);
            this.IDCT4.Name = "IDCT4";
            this.IDCT4.Size = new System.Drawing.Size(94, 27);
            this.IDCT4.TabIndex = 15;
            this.IDCT4.Text = "3 rows";
            this.IDCT4.UseVisualStyleBackColor = true;
            this.IDCT4.Click += new System.EventHandler(this.IDCT4_Click);
            // 
            // IDCT1
            // 
            this.IDCT1.Enabled = false;
            this.IDCT1.Location = new System.Drawing.Point(151, 5);
            this.IDCT1.Name = "IDCT1";
            this.IDCT1.Size = new System.Drawing.Size(94, 27);
            this.IDCT1.TabIndex = 15;
            this.IDCT1.Text = "Only DC";
            this.IDCT1.UseVisualStyleBackColor = true;
            this.IDCT1.Click += new System.EventHandler(this.IDCT1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "8x8";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.ForeColor = System.Drawing.Color.OrangeRed;
            this.log.Location = new System.Drawing.Point(262, 118);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 12);
            this.log.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "轉換過程";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "轉換結果";
            // 
            // oplena
            // 
            this.oplena.Location = new System.Drawing.Point(12, 327);
            this.oplena.Name = "oplena";
            this.oplena.Size = new System.Drawing.Size(95, 23);
            this.oplena.TabIndex = 15;
            this.oplena.Text = "Lena256x256";
            this.oplena.UseVisualStyleBackColor = true;
            this.oplena.Click += new System.EventHandler(this.oplena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 385);
            this.Controls.Add(this.oplena);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idctbox);
            this.Controls.Add(this.dctbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.R10);
            this.Controls.Add(this.R9);
            this.Controls.Add(this.R8);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.R7);
            this.Controls.Add(this.R6);
            this.Controls.Add(this.R5);
            this.Controls.Add(this.R4);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "多媒體編碼 400262501 鄭力文";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idctbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.RadioButton R3;
        private System.Windows.Forms.RadioButton R4;
        private System.Windows.Forms.RadioButton R5;
        private System.Windows.Forms.RadioButton R6;
        private System.Windows.Forms.RadioButton R7;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.RadioButton R8;
        private System.Windows.Forms.RadioButton R9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.RadioButton R10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox dctbox;
        private System.Windows.Forms.Button DCT;
        private System.Windows.Forms.Button IDCT;
        private System.Windows.Forms.PictureBox idctbox;
        private System.Windows.Forms.Button Qt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button IDCT3;
        private System.Windows.Forms.Button IDCT2;
        private System.Windows.Forms.Button IDCT5;
        private System.Windows.Forms.Button IDCT4;
        private System.Windows.Forms.Button IDCT1;
        private System.Windows.Forms.Button DCT8;
        private System.Windows.Forms.Button IQID;
        private System.Windows.Forms.Button ZiZag;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button IDCT8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button oplena;
    }
}

