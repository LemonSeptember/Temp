using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DictionaryTest
{
    public partial class FormDictionaryTest : Form
    {

        Dictionary<string, string> mDictionary = new Dictionary<string, string>();
        public FormDictionaryTest()
        {
            InitializeComponent();
        }

        private void FormDictionaryTest_Load(object sender, EventArgs e)
        {
            mDictionary.Add("1", "111");
            mDictionary.Add("2", "222");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = "1";
            string temp;
            if (mDictionary.ContainsKey(key))
            {
                temp = mDictionary[key];
            }
            else
            {
                temp = key;
            }
            Console.WriteLine(temp);
        }
    }
}
