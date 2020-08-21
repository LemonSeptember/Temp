using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumericUpDown_Str
{
    class UCNumericUpDown : NumericUpDown
    {

        public string Unit { get; set; }
        protected override void UpdateEditText()
        {
            base.UpdateEditText();
            ChangingText = true;
            Text += (" " + Unit);
        }
    }
}
