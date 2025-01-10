namespace MouseClicker
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkRememberInterval = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkRememberInterval);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numInterval);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStartStop2);
            this.panel1.Location = new System.Drawing.Point(19, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 210);
            this.panel1.TabIndex = 6;
            // 
            // chkRememberInterval
            // 
            this.chkRememberInterval.AutoSize = true;
            this.chkRememberInterval.Location = new System.Drawing.Point(816, 58);
            this.chkRememberInterval.Name = "chkRememberInterval";
            this.chkRememberInterval.Size = new System.Drawing.Size(70, 22);
            this.chkRememberInterval.TabIndex = 10;
            this.chkRememberInterval.Text = "記憶";
            this.chkRememberInterval.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(472, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "間隔10~100";
            // 
            // numInterval
            // 
            this.numInterval.Font = new System.Drawing.Font("新細明體", 15F);
            this.numInterval.Location = new System.Drawing.Point(690, 47);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 43);
            this.numInterval.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20F);
            this.label1.Location = new System.Drawing.Point(470, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "目前狀態";
            // 
            // btnStartStop2
            // 
            this.btnStartStop2.AutoSize = true;
            this.btnStartStop2.BackColor = System.Drawing.SystemColors.Info;
            this.btnStartStop2.Font = new System.Drawing.Font("新細明體", 30F);
            this.btnStartStop2.Location = new System.Drawing.Point(658, 118);
            this.btnStartStop2.Name = "btnStartStop2";
            this.btnStartStop2.Size = new System.Drawing.Size(205, 60);
            this.btnStartStop2.TabIndex = 4;
            this.btnStartStop2.Text = "停止中";
            this.btnStartStop2.Click += new System.EventHandler(this.btnStartStop2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(100, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 76);
            this.label2.TabIndex = 7;
            this.label2.Text = "按下Pause/Break控制開關";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "滑鼠連點程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnStartStop2;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRememberInterval;
    }
}

