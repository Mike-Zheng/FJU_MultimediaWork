namespace MultimediaWork
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelLog = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DCTdebug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.RLE2 = new System.Windows.Forms.Button();
            this.llog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLog.Location = new System.Drawing.Point(27, 330);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(0, 12);
            this.labelLog.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Load pixel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(999, 642);
            this.textBox1.TabIndex = 1;
            // 
            // DCTdebug
            // 
            this.DCTdebug.Location = new System.Drawing.Point(108, 12);
            this.DCTdebug.Name = "DCTdebug";
            this.DCTdebug.Size = new System.Drawing.Size(75, 23);
            this.DCTdebug.TabIndex = 2;
            this.DCTdebug.Text = "DCTdebug";
            this.DCTdebug.UseVisualStyleBackColor = true;
            this.DCTdebug.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "IDCT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "load Qtable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Dct/Qtable";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(510, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "ZigZagScan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // RLE2
            // 
            this.RLE2.Location = new System.Drawing.Point(602, 12);
            this.RLE2.Name = "RLE2";
            this.RLE2.Size = new System.Drawing.Size(75, 23);
            this.RLE2.TabIndex = 7;
            this.RLE2.Text = "RLE";
            this.RLE2.UseVisualStyleBackColor = true;
            this.RLE2.Click += new System.EventHandler(this.RLE2_Click);
            // 
            // llog
            // 
            this.llog.AutoSize = true;
            this.llog.Location = new System.Drawing.Point(16, 47);
            this.llog.Name = "llog";
            this.llog.Size = new System.Drawing.Size(196, 12);
            this.llog.TabIndex = 8;
            this.llog.Text = "DeBug因textbox 文字會需要跑很久。";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 765);
            this.Controls.Add(this.llog);
            this.Controls.Add(this.RLE2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DCTdebug);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "DEBUG 64x64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DCTdebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RLE2;
        private System.Windows.Forms.Label llog;
    }
}

