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
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idctbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始照片";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
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
            this.picBox.Location = new System.Drawing.Point(138, 47);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(128, 128);
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
            this.label2.Location = new System.Drawing.Point(10, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "限定選擇64x64的.raw";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLog.Location = new System.Drawing.Point(104, 378);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(70, 12);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "labelLog.Text";
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
            this.button2.Location = new System.Drawing.Point(12, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "DEBUG";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dctbox
            // 
            this.dctbox.Location = new System.Drawing.Point(288, 47);
            this.dctbox.Name = "dctbox";
            this.dctbox.Size = new System.Drawing.Size(128, 128);
            this.dctbox.TabIndex = 10;
            this.dctbox.TabStop = false;
            // 
            // DCT
            // 
            this.DCT.Location = new System.Drawing.Point(138, 212);
            this.DCT.Name = "DCT";
            this.DCT.Size = new System.Drawing.Size(128, 29);
            this.DCT.TabIndex = 11;
            this.DCT.Text = "DCT";
            this.DCT.UseVisualStyleBackColor = true;
            this.DCT.Click += new System.EventHandler(this.DCT_Click);
            // 
            // IDCT
            // 
            this.IDCT.Enabled = false;
            this.IDCT.Location = new System.Drawing.Point(288, 212);
            this.IDCT.Name = "IDCT";
            this.IDCT.Size = new System.Drawing.Size(128, 29);
            this.IDCT.TabIndex = 12;
            this.IDCT.Text = "IDCT";
            this.IDCT.UseVisualStyleBackColor = true;
            this.IDCT.Click += new System.EventHandler(this.IDCT_Click);
            // 
            // idctbox
            // 
            this.idctbox.Location = new System.Drawing.Point(439, 47);
            this.idctbox.Name = "idctbox";
            this.idctbox.Size = new System.Drawing.Size(128, 128);
            this.idctbox.TabIndex = 10;
            this.idctbox.TabStop = false;
            // 
            // Qt
            // 
            this.Qt.Location = new System.Drawing.Point(288, 247);
            this.Qt.Name = "Qt";
            this.Qt.Size = new System.Drawing.Size(128, 29);
            this.Qt.TabIndex = 13;
            this.Qt.Text = "Quantization";
            this.Qt.UseVisualStyleBackColor = true;
            this.Qt.Click += new System.EventHandler(this.Qt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 422);
            this.Controls.Add(this.Qt);
            this.Controls.Add(this.IDCT);
            this.Controls.Add(this.DCT);
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
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "多媒體編碼 400262501 鄭力文";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dctbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idctbox)).EndInit();
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
    }
}

