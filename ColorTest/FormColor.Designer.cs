namespace ColorTest
{
    partial class FormColor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Color = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.richTextBox_Time = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_averageTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Color
            // 
            this.button_Color.Location = new System.Drawing.Point(324, 12);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(464, 426);
            this.button_Color.TabIndex = 0;
            this.button_Color.UseVisualStyleBackColor = false;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(339, 27);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(433, 397);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(57, 9);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(95, 12);
            this.label_Time.TabIndex = 2;
            this.label_Time.Text = "     毫秒（ms）";
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(243, 403);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 35);
            this.button_Stop.TabIndex = 3;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // richTextBox_Time
            // 
            this.richTextBox_Time.Location = new System.Drawing.Point(12, 42);
            this.richTextBox_Time.Name = "richTextBox_Time";
            this.richTextBox_Time.Size = new System.Drawing.Size(290, 355);
            this.richTextBox_Time.TabIndex = 4;
            this.richTextBox_Time.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "平均：";
            // 
            // label_averageTime
            // 
            this.label_averageTime.AutoSize = true;
            this.label_averageTime.Location = new System.Drawing.Point(57, 27);
            this.label_averageTime.Name = "label_averageTime";
            this.label_averageTime.Size = new System.Drawing.Size(95, 12);
            this.label_averageTime.TabIndex = 7;
            this.label_averageTime.Text = "     毫秒（ms）";
            // 
            // FormColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_averageTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Time);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Color);
            this.Name = "FormColor";
            this.Text = "FormColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormColor_FormClosing);
            this.Load += new System.EventHandler(this.FormColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.RichTextBox richTextBox_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_averageTime;
    }
}

