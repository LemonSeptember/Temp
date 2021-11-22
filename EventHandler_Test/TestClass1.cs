using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_Test
{
    public class TestClass
    {
        public event EventHandler ButtonChangeHandler;

        public void Show()
        {
            ButtonChangeHandler?.Invoke(this, new EventArgs());
        }
    }
}
