namespace Bluetooth_LE_Test
{
    partial class FormBluetoothLE
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Query = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.maskedTextBox_BT1_Address = new System.Windows.Forms.MaskedTextBox();
            this.radioButton_BT1_Open = new System.Windows.Forms.RadioButton();
            this.radioButton_BT1_Close = new System.Windows.Forms.RadioButton();
            this.radioButton_BT2_Open = new System.Windows.Forms.RadioButton();
            this.radioButton_BT2_Close = new System.Windows.Forms.RadioButton();
            this.groupBox_BT1 = new System.Windows.Forms.GroupBox();
            this.button_BT1_Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_BT1_3 = new System.Windows.Forms.Button();
            this.button_BT1_2 = new System.Windows.Forms.Button();
            this.groupBox_BT2 = new System.Windows.Forms.GroupBox();
            this.button_BT2_Change = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_BT2_Address = new System.Windows.Forms.MaskedTextBox();
            this.button_BT2_3 = new System.Windows.Forms.Button();
            this.button_BT2_2 = new System.Windows.Forms.Button();
            this.button_Break = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_BT1.SuspendLayout();
            this.groupBox_BT2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 441);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button_Query
            // 
            this.button_Query.AutoSize = true;
            this.button_Query.Location = new System.Drawing.Point(507, 15);
            this.button_Query.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Query.Name = "button_Query";
            this.button_Query.Size = new System.Drawing.Size(80, 80);
            this.button_Query.TabIndex = 2;
            this.button_Query.Text = "Query";
            this.button_Query.UseVisualStyleBackColor = true;
            this.button_Query.Click += new System.EventHandler(this.button_Query_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.AutoSize = true;
            this.button_Connect.Location = new System.Drawing.Point(507, 102);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(80, 80);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // maskedTextBox_BT1_Address
            // 
            this.maskedTextBox_BT1_Address.Enabled = false;
            this.maskedTextBox_BT1_Address.Location = new System.Drawing.Point(100, 25);
            this.maskedTextBox_BT1_Address.Mask = "AAAA";
            this.maskedTextBox_BT1_Address.Name = "maskedTextBox_BT1_Address";
            this.maskedTextBox_BT1_Address.RejectInputOnFirstFailure = true;
            this.maskedTextBox_BT1_Address.Size = new System.Drawing.Size(55, 26);
            this.maskedTextBox_BT1_Address.TabIndex = 11;
            this.maskedTextBox_BT1_Address.Text = "44A2";
            this.maskedTextBox_BT1_Address.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_BT1_Address.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_Bluetooth_MaskInputRejected);
            // 
            // radioButton_BT1_Open
            // 
            this.radioButton_BT1_Open.AutoSize = true;
            this.radioButton_BT1_Open.Location = new System.Drawing.Point(9, 68);
            this.radioButton_BT1_Open.Name = "radioButton_BT1_Open";
            this.radioButton_BT1_Open.Size = new System.Drawing.Size(64, 22);
            this.radioButton_BT1_Open.TabIndex = 16;
            this.radioButton_BT1_Open.Text = "Open";
            this.radioButton_BT1_Open.UseVisualStyleBackColor = true;
            this.radioButton_BT1_Open.CheckedChanged += new System.EventHandler(this.radioButton_BT1_Open_CheckedChanged);
            // 
            // radioButton_BT1_Close
            // 
            this.radioButton_BT1_Close.AutoSize = true;
            this.radioButton_BT1_Close.Checked = true;
            this.radioButton_BT1_Close.Location = new System.Drawing.Point(9, 96);
            this.radioButton_BT1_Close.Name = "radioButton_BT1_Close";
            this.radioButton_BT1_Close.Size = new System.Drawing.Size(67, 22);
            this.radioButton_BT1_Close.TabIndex = 17;
            this.radioButton_BT1_Close.TabStop = true;
            this.radioButton_BT1_Close.Text = "Close";
            this.radioButton_BT1_Close.UseVisualStyleBackColor = true;
            this.radioButton_BT1_Close.CheckedChanged += new System.EventHandler(this.radioButton_BT1_Close_CheckedChanged);
            // 
            // radioButton_BT2_Open
            // 
            this.radioButton_BT2_Open.AutoSize = true;
            this.radioButton_BT2_Open.Location = new System.Drawing.Point(9, 68);
            this.radioButton_BT2_Open.Name = "radioButton_BT2_Open";
            this.radioButton_BT2_Open.Size = new System.Drawing.Size(64, 22);
            this.radioButton_BT2_Open.TabIndex = 16;
            this.radioButton_BT2_Open.Text = "Open";
            this.radioButton_BT2_Open.UseVisualStyleBackColor = true;
            this.radioButton_BT2_Open.CheckedChanged += new System.EventHandler(this.radioButton_BT2_Open_CheckedChanged);
            // 
            // radioButton_BT2_Close
            // 
            this.radioButton_BT2_Close.AutoSize = true;
            this.radioButton_BT2_Close.Checked = true;
            this.radioButton_BT2_Close.Location = new System.Drawing.Point(9, 96);
            this.radioButton_BT2_Close.Name = "radioButton_BT2_Close";
            this.radioButton_BT2_Close.Size = new System.Drawing.Size(67, 22);
            this.radioButton_BT2_Close.TabIndex = 17;
            this.radioButton_BT2_Close.TabStop = true;
            this.radioButton_BT2_Close.Text = "Close";
            this.radioButton_BT2_Close.UseVisualStyleBackColor = true;
            this.radioButton_BT2_Close.CheckedChanged += new System.EventHandler(this.radioButton_BT2_Close_CheckedChanged);
            // 
            // groupBox_BT1
            // 
            this.groupBox_BT1.Controls.Add(this.button_BT1_Change);
            this.groupBox_BT1.Controls.Add(this.label1);
            this.groupBox_BT1.Controls.Add(this.button_BT1_3);
            this.groupBox_BT1.Controls.Add(this.radioButton_BT1_Open);
            this.groupBox_BT1.Controls.Add(this.button_BT1_2);
            this.groupBox_BT1.Controls.Add(this.radioButton_BT1_Close);
            this.groupBox_BT1.Controls.Add(this.maskedTextBox_BT1_Address);
            this.groupBox_BT1.Location = new System.Drawing.Point(593, 15);
            this.groupBox_BT1.Name = "groupBox_BT1";
            this.groupBox_BT1.Size = new System.Drawing.Size(255, 131);
            this.groupBox_BT1.TabIndex = 20;
            this.groupBox_BT1.TabStop = false;
            this.groupBox_BT1.Text = "Bluetooth 1";
            // 
            // button_BT1_Change
            // 
            this.button_BT1_Change.AutoSize = true;
            this.button_BT1_Change.Location = new System.Drawing.Point(161, 12);
            this.button_BT1_Change.Name = "button_BT1_Change";
            this.button_BT1_Change.Size = new System.Drawing.Size(70, 50);
            this.button_BT1_Change.TabIndex = 25;
            this.button_BT1_Change.Text = "更改";
            this.button_BT1_Change.UseVisualStyleBackColor = true;
            this.button_BT1_Change.Click += new System.EventHandler(this.button_BT1_Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "蓝牙地址：";
            // 
            // button_BT1_3
            // 
            this.button_BT1_3.AutoSize = true;
            this.button_BT1_3.Location = new System.Drawing.Point(161, 68);
            this.button_BT1_3.Name = "button_BT1_3";
            this.button_BT1_3.Size = new System.Drawing.Size(70, 50);
            this.button_BT1_3.TabIndex = 23;
            this.button_BT1_3.Text = "3";
            this.button_BT1_3.UseVisualStyleBackColor = true;
            this.button_BT1_3.Click += new System.EventHandler(this.button_BT1_3_Click);
            // 
            // button_BT1_2
            // 
            this.button_BT1_2.AutoSize = true;
            this.button_BT1_2.Location = new System.Drawing.Point(85, 68);
            this.button_BT1_2.Name = "button_BT1_2";
            this.button_BT1_2.Size = new System.Drawing.Size(70, 50);
            this.button_BT1_2.TabIndex = 22;
            this.button_BT1_2.Text = "2";
            this.button_BT1_2.UseVisualStyleBackColor = true;
            this.button_BT1_2.Click += new System.EventHandler(this.button_BT1_2_Click);
            // 
            // groupBox_BT2
            // 
            this.groupBox_BT2.Controls.Add(this.button_BT2_Change);
            this.groupBox_BT2.Controls.Add(this.label2);
            this.groupBox_BT2.Controls.Add(this.maskedTextBox_BT2_Address);
            this.groupBox_BT2.Controls.Add(this.button_BT2_3);
            this.groupBox_BT2.Controls.Add(this.button_BT2_2);
            this.groupBox_BT2.Controls.Add(this.radioButton_BT2_Open);
            this.groupBox_BT2.Controls.Add(this.radioButton_BT2_Close);
            this.groupBox_BT2.Location = new System.Drawing.Point(593, 152);
            this.groupBox_BT2.Name = "groupBox_BT2";
            this.groupBox_BT2.Size = new System.Drawing.Size(255, 131);
            this.groupBox_BT2.TabIndex = 21;
            this.groupBox_BT2.TabStop = false;
            this.groupBox_BT2.Text = "Bluetooth 2";
            // 
            // button_BT2_Change
            // 
            this.button_BT2_Change.AutoSize = true;
            this.button_BT2_Change.Location = new System.Drawing.Point(161, 12);
            this.button_BT2_Change.Name = "button_BT2_Change";
            this.button_BT2_Change.Size = new System.Drawing.Size(70, 50);
            this.button_BT2_Change.TabIndex = 26;
            this.button_BT2_Change.Text = "更改";
            this.button_BT2_Change.UseVisualStyleBackColor = true;
            this.button_BT2_Change.Click += new System.EventHandler(this.button_BT2_Change_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "蓝牙地址：";
            // 
            // maskedTextBox_BT2_Address
            // 
            this.maskedTextBox_BT2_Address.Enabled = false;
            this.maskedTextBox_BT2_Address.Location = new System.Drawing.Point(100, 25);
            this.maskedTextBox_BT2_Address.Mask = "AAAA";
            this.maskedTextBox_BT2_Address.Name = "maskedTextBox_BT2_Address";
            this.maskedTextBox_BT2_Address.RejectInputOnFirstFailure = true;
            this.maskedTextBox_BT2_Address.Size = new System.Drawing.Size(55, 26);
            this.maskedTextBox_BT2_Address.TabIndex = 26;
            this.maskedTextBox_BT2_Address.Text = "65C2";
            this.maskedTextBox_BT2_Address.ValidatingType = typeof(System.DateTime);
            // 
            // button_BT2_3
            // 
            this.button_BT2_3.AutoSize = true;
            this.button_BT2_3.Location = new System.Drawing.Point(161, 68);
            this.button_BT2_3.Name = "button_BT2_3";
            this.button_BT2_3.Size = new System.Drawing.Size(70, 50);
            this.button_BT2_3.TabIndex = 25;
            this.button_BT2_3.Text = "3";
            this.button_BT2_3.UseVisualStyleBackColor = true;
            this.button_BT2_3.Click += new System.EventHandler(this.button_BT2_3_Click);
            // 
            // button_BT2_2
            // 
            this.button_BT2_2.AutoSize = true;
            this.button_BT2_2.Location = new System.Drawing.Point(85, 68);
            this.button_BT2_2.Name = "button_BT2_2";
            this.button_BT2_2.Size = new System.Drawing.Size(70, 50);
            this.button_BT2_2.TabIndex = 24;
            this.button_BT2_2.Text = "2";
            this.button_BT2_2.UseVisualStyleBackColor = true;
            this.button_BT2_2.Click += new System.EventHandler(this.button_BT2_2_Click);
            // 
            // button_Break
            // 
            this.button_Break.AutoSize = true;
            this.button_Break.Location = new System.Drawing.Point(507, 188);
            this.button_Break.Name = "button_Break";
            this.button_Break.Size = new System.Drawing.Size(80, 80);
            this.button_Break.TabIndex = 22;
            this.button_Break.Text = "Break";
            this.button_Break.UseVisualStyleBackColor = true;
            this.button_Break.Click += new System.EventHandler(this.button_Break_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 23;
            this.button1.Text = "显示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBluetoothLE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(864, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Break);
            this.Controls.Add(this.groupBox_BT2);
            this.Controls.Add(this.groupBox_BT1);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Query);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBluetoothLE";
            this.Text = "BluetoothLE";
            this.Load += new System.EventHandler(this.FormBluetoothLE_Load);
            this.groupBox_BT1.ResumeLayout(false);
            this.groupBox_BT1.PerformLayout();
            this.groupBox_BT2.ResumeLayout(false);
            this.groupBox_BT2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BT1_Address;
        private System.Windows.Forms.RadioButton radioButton_BT1_Open;
        private System.Windows.Forms.RadioButton radioButton_BT1_Close;
        private System.Windows.Forms.RadioButton radioButton_BT2_Open;
        private System.Windows.Forms.RadioButton radioButton_BT2_Close;
        private System.Windows.Forms.GroupBox groupBox_BT1;
        private System.Windows.Forms.GroupBox groupBox_BT2;
        private System.Windows.Forms.Button button_BT1_3;
        private System.Windows.Forms.Button button_BT1_2;
        private System.Windows.Forms.Button button_BT2_3;
        private System.Windows.Forms.Button button_BT2_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BT2_Address;
        private System.Windows.Forms.Button button_BT1_Change;
        private System.Windows.Forms.Button button_BT2_Change;
        private System.Windows.Forms.Button button_Break;
        private System.Windows.Forms.Button button1;
    }
}

