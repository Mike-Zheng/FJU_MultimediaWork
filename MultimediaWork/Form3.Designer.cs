namespace MultimediaWork
{
    partial class Form3
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
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.loadlena = new System.Windows.Forms.Button();
            this.RGBtoYRB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox1
            // 
            this.pBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox1.Location = new System.Drawing.Point(124, 25);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(257, 257);
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox2.Location = new System.Drawing.Point(403, 25);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(257, 257);
            this.pBox2.TabIndex = 1;
            this.pBox2.TabStop = false;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(12, 285);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(0, 12);
            this.labelLog.TabIndex = 2;
            // 
            // loadlena
            // 
            this.loadlena.Location = new System.Drawing.Point(12, 25);
            this.loadlena.Name = "loadlena";
            this.loadlena.Size = new System.Drawing.Size(95, 36);
            this.loadlena.TabIndex = 3;
            this.loadlena.Text = "Load Lena";
            this.loadlena.UseVisualStyleBackColor = true;
            this.loadlena.Click += new System.EventHandler(this.loadlena_Click);
            // 
            // RGBtoYRB
            // 
            this.RGBtoYRB.Location = new System.Drawing.Point(12, 67);
            this.RGBtoYRB.Name = "RGBtoYRB";
            this.RGBtoYRB.Size = new System.Drawing.Size(93, 34);
            this.RGBtoYRB.TabIndex = 4;
            this.RGBtoYRB.Text = "To YCrCb  4:2:0";
            this.RGBtoYRB.UseVisualStyleBackColor = true;
            this.RGBtoYRB.Click += new System.EventHandler(this.RGBtoYRB_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 306);
            this.Controls.Add(this.RGBtoYRB);
            this.Controls.Add(this.loadlena);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Name = "Form3";
            this.Text = "LENA256";
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button loadlena;
        private System.Windows.Forms.Button RGBtoYRB;

    }
}

