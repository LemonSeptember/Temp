using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_KeyDown
{
    public partial class Form_KeyPress : Form
    {
        public Form_KeyPress()
        {
            InitializeComponent();
        }

        private void Form_KeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //messageBoxCS.AppendFormat("{0} = {1}", "Alt", e.Alt);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Control", e.Control);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Handled", e.Handled);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "KeyCode", e.KeyCode);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "KeyValue", e.KeyValue);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "KeyData", e.KeyData);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Modifiers", e.Modifiers);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Shift", e.Shift);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "SuppressKeyPress", e.SuppressKeyPress);
            //messageBoxCS.AppendLine();

            messageBoxCS.AppendFormat("{0} = {1}", "Handled", e.Handled);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "KeyChar", e.KeyChar);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "KeyDown Event");
            richTextBox1.Clear();
            richTextBox1.AppendText(messageBoxCS.ToString());
        }
    }
}
