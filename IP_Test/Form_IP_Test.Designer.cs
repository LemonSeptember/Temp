﻿namespace IP_Test
{
    partial class Form_IP_Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_SetIP = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_SetIP
            // 
            this.button_SetIP.AutoSize = true;
            this.button_SetIP.Location = new System.Drawing.Point(596, 269);
            this.button_SetIP.Name = "button_SetIP";
            this.button_SetIP.Size = new System.Drawing.Size(73, 35);
            this.button_SetIP.TabIndex = 1;
            this.button_SetIP.Text = "Set IP";
            this.button_SetIP.UseVisualStyleBackColor = true;
            this.button_SetIP.Click += new System.EventHandler(this.button_SetIP_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(91, 44);
            this.maskedTextBox1.Mask = "009.009.009.009";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(213, 21);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // Form_IP_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button_SetIP);
            this.Controls.Add(this.button1);
            this.Name = "Form_IP_Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_SetIP;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

