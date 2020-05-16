using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailFlawDetectorLog.Tools.textBox
{
    public class UCNumericUpDown : NumericUpDown
    {

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    //this.UpDownAlign = LeftRightAlignment.Left;

        //    this.Controls[0].Visible = false;

        //    //{ControlAccessibleObject: Owner = System.Windows.Forms.UpDownBase+UpDownEdit, Text: 0}
        //    //Controls.RemoveByKey("");
        //    //this.Controls[0].Size = new Size(70, 20);

        //    //Controls[1].Dock = DockStyle.Fill;
        //    //Controls[1].BringToFront();
        //    //e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(1, 1, Width - 2, Height - 2));

        //    e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));
        //    //e.Graphics.DrawRectangle(new Pen(Color.Gray), new Rectangle(0, 0, Width - 1, Height - 1));
        //    base.OnPaint(e);
        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            Controls[0].Visible = false;
            e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));
            base.OnPaint(e);
        }
    }
}

