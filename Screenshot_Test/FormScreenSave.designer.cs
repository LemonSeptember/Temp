namespace Screenshot_Test
{
    partial class FormScreenSave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormScreenSave
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(50, 50);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScreenSave";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FmScreenCopy";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormScreenSave_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScreenSave_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormScreenSave_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormScreenSave_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScreenSave_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScreenSave_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScreenSave_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}