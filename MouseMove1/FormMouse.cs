using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseMove1
{
    public partial class FormMouse : Form
    {
        public FormMouse()
        {
            InitializeComponent();
        }

        Point p = new Point();

        ToolTip toolTip = new ToolTip();


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // pictureBox1.Image = (Bitmap)bitmap.Clone();
            // Graphics g = Graphics.FromImage(pictureBox1.Image);
            // g.DrawLine(new Pen(Color.Red, 1), start, new Point(e.X, e.Y));
            // g.DrawImage(bitmap, pictureBox1.Location.X, pictureBox1.Location.Y,
            //pictureBox1.Width, pictureBox1.Height);
            // g.Dispose();

            //Bitmap mp = new Bitmap(200, 300);
            //pictureBox1.Image = mp;
            //Graphics g = this.pictureBox1.CreateGraphics();
            //g.DrawString("aaaa", new Font("宋体", 12, FontStyle.Bold), Brushes.Red, e.Location);
            //g.Dispose();

            //p = e.Location;
            //pictureBox1.Invalidate();

            toolTip.SetToolTip(pictureBox1, e.Location.ToString());
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString("   "+p.X.ToString() +","+ p.Y.ToString(), new Font("宋体", 12, FontStyle.Bold), Brushes.Red, p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolTip.OwnerDraw = true;
            toolTip.Draw += new DrawToolTipEventHandler(this.toolTip1_Draw);

            //toolTip.BackColor = backColor;
            //toolTip.ForeColor = foreColor;
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Draw the ToolTip differently depending on which 
            // control this ToolTip is for.
            // Draw a custom 3D border if the ToolTip is for button1.
            if (e.AssociatedControl == button1)
            {
                // Draw the standard background.
                e.DrawBackground();

                // Draw the custom border to appear 3-dimensional.
                e.Graphics.DrawLines(SystemPens.ControlLightLight, new Point[] {
                    new Point (0, e.Bounds.Height - 1),
                    new Point (0, 0),
                    new Point (e.Bounds.Width - 1, 0)
                });
                e.Graphics.DrawLines(SystemPens.ControlDarkDark, new Point[] {
                    new Point (0, e.Bounds.Height - 1),
                    new Point (e.Bounds.Width - 1, e.Bounds.Height - 1),
                    new Point (e.Bounds.Width - 1, 0)
                });

                // Specify custom text formatting flags.
                TextFormatFlags sf = TextFormatFlags.VerticalCenter |
                                     TextFormatFlags.HorizontalCenter |
                                     TextFormatFlags.NoFullWidthCharacterBreak;

                // Draw the standard text with customized formatting options.
                e.DrawText(sf);
            }
            // Draw a custom background and text if the ToolTip is for button2.
            else if (e.AssociatedControl == button2)
            {
                // Draw the custom background.
                e.Graphics.FillRectangle(SystemBrushes.ActiveCaption, e.Bounds);

                // Draw the standard border.
                e.DrawBorder();

                // Draw the custom text.
                // The using block will dispose the StringFormat automatically.
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
                    sf.FormatFlags = StringFormatFlags.NoWrap;
                    using (Font f = new Font("Tahoma", 9))
                    {
                        e.Graphics.DrawString(e.ToolTipText, f,
                            SystemBrushes.ActiveCaptionText, e.Bounds, sf);
                    }
                }
            }
            // Draw the ToolTip using default values if the ToolTip is for button3.
            else if (e.AssociatedControl == button3)
            {
                e.DrawBackground();
                e.DrawBorder();
                e.DrawText();
            }
        }

        Color backColor = Color.White;
        Color foreColor = Color.Black;


        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            //colorDialog.ShowHelp = true;
            colorDialog.Color = textBox1.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog.Color;
                backColor = colorDialog.Color;
            }
             

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            //colorDialog.ShowHelp = true;
            colorDialog.Color = textBox1.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
                foreColor = colorDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool tip = toolTip.Active;
            tip = !tip;
            toolTip.Active = tip;
            label1.Text = tip.ToString();
        }

        private void FormMouse_Load(object sender, EventArgs e)
        {
            label1.Text = toolTip.Active.ToString();
            label2.Text = toolTip.OwnerDraw.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool tip = toolTip.OwnerDraw;
            tip = !tip;
            toolTip.OwnerDraw = tip;
            label2.Text = tip.ToString();
        }
        private void toolTip1_Draw(System.Object sender,
            System.Windows.Forms.DrawToolTipEventArgs e)
        {
            // Draw the ToolTip differently depending on which 
            // control this ToolTip is for.
            // Draw a custom 3D border if the ToolTip is for button1.
            if (e.AssociatedControl == button1)
            {
                // Draw the standard background.
                e.DrawBackground();

                // Draw the custom border to appear 3-dimensional.
                e.Graphics.DrawLines(SystemPens.ControlLightLight, new Point[] {
                    new Point (0, e.Bounds.Height - 1),
                    new Point (0, 0),
                    new Point (e.Bounds.Width - 1, 0)
                });
                e.Graphics.DrawLines(SystemPens.ControlDarkDark, new Point[] {
                    new Point (0, e.Bounds.Height - 1),
                    new Point (e.Bounds.Width - 1, e.Bounds.Height - 1),
                    new Point (e.Bounds.Width - 1, 0)
                });

                // Specify custom text formatting flags.
                TextFormatFlags sf = TextFormatFlags.VerticalCenter |
                                     TextFormatFlags.HorizontalCenter |
                                     TextFormatFlags.NoFullWidthCharacterBreak;

                // Draw the standard text with customized formatting options.
                e.DrawText(sf);
            }
            // Draw a custom background and text if the ToolTip is for button2.
            else if (e.AssociatedControl == button2)
            {
                // Draw the custom background.
                e.Graphics.FillRectangle(SystemBrushes.ActiveCaption, e.Bounds);

                // Draw the standard border.
                e.DrawBorder();

                // Draw the custom text.
                // The using block will dispose the StringFormat automatically.
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
                    sf.FormatFlags = StringFormatFlags.NoWrap;
                    using (Font f = new Font("Tahoma", 9))
                    {
                        e.Graphics.DrawString(e.ToolTipText, f,
                            SystemBrushes.ActiveCaptionText, e.Bounds, sf);
                    }
                }
            }
            // Draw the ToolTip using default values if the ToolTip is for button3.
            else if (e.AssociatedControl == button3)
            {
                e.DrawBackground();
                e.DrawBorder();
                e.DrawText();
            }
        }

    }
}
