namespace NumericUpDown_Str
{
    partial class Form1
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
            this.ucNumericUpDown2 = new NumericUpDown_Str.UCNumericUpDown();
            this.ucNumericUpDown1 = new NumericUpDown_Str.UCNumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucNumericUpDown2
            // 
            this.ucNumericUpDown2.Location = new System.Drawing.Point(340, 215);
            this.ucNumericUpDown2.Name = "ucNumericUpDown2";
            this.ucNumericUpDown2.Size = new System.Drawing.Size(120, 21);
            this.ucNumericUpDown2.TabIndex = 1;
            this.ucNumericUpDown2.Unit = "Km";
            // 
            // ucNumericUpDown1
            // 
            this.ucNumericUpDown1.Location = new System.Drawing.Point(296, 182);
            this.ucNumericUpDown1.Name = "ucNumericUpDown1";
            this.ucNumericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.ucNumericUpDown1.TabIndex = 0;
            this.ucNumericUpDown1.Unit = "Km";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucNumericUpDown2);
            this.Controls.Add(this.ucNumericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ucNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCNumericUpDown ucNumericUpDown1;
        private UCNumericUpDown ucNumericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

