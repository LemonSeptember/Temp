namespace WriteByte
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxByte = new System.Windows.Forms.TextBox();
            this.textBoxBit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonbuttonByteToBit = new System.Windows.Forms.Button();
            this.buttonBitToByte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(418, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(206, 232);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(12, 232);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(481, 201);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxByte
            // 
            this.textBoxByte.Location = new System.Drawing.Point(12, 321);
            this.textBoxByte.Name = "textBoxByte";
            this.textBoxByte.Size = new System.Drawing.Size(100, 21);
            this.textBoxByte.TabIndex = 4;
            this.textBoxByte.Text = "1";
            // 
            // textBoxBit
            // 
            this.textBoxBit.Location = new System.Drawing.Point(12, 364);
            this.textBoxBit.Name = "textBoxBit";
            this.textBoxBit.Size = new System.Drawing.Size(100, 21);
            this.textBoxBit.TabIndex = 5;
            this.textBoxBit.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Byte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bit";
            // 
            // buttonbuttonByteToBit
            // 
            this.buttonbuttonByteToBit.Location = new System.Drawing.Point(143, 319);
            this.buttonbuttonByteToBit.Name = "buttonbuttonByteToBit";
            this.buttonbuttonByteToBit.Size = new System.Drawing.Size(75, 23);
            this.buttonbuttonByteToBit.TabIndex = 8;
            this.buttonbuttonByteToBit.Text = "ByteToBit";
            this.buttonbuttonByteToBit.UseVisualStyleBackColor = true;
            this.buttonbuttonByteToBit.Click += new System.EventHandler(this.buttonbuttonByteToBit_Click);
            // 
            // buttonBitToByte
            // 
            this.buttonBitToByte.Location = new System.Drawing.Point(143, 362);
            this.buttonBitToByte.Name = "buttonBitToByte";
            this.buttonBitToByte.Size = new System.Drawing.Size(75, 23);
            this.buttonBitToByte.TabIndex = 9;
            this.buttonBitToByte.Text = "BitToByte";
            this.buttonBitToByte.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBitToByte);
            this.Controls.Add(this.buttonbuttonByteToBit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBit);
            this.Controls.Add(this.textBoxByte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxByte;
        private System.Windows.Forms.TextBox textBoxBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonbuttonByteToBit;
        private System.Windows.Forms.Button buttonBitToByte;
    }
}

