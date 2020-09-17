using System;
using System.Windows.Forms;

namespace DataUnitCopy
{
    public partial class FormDataUnit : Form
    {
        public FormDataUnit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataUnit dataUnit = new DataUnit();
            dataUnit.AddDataItem(DataItemFactory.GetDoubleB1ChanItem(111, 111));
            dataUnit.AddDataItem(DataItemFactory.GetDoubleB1ChanItem(222, 222));
            dataUnit.AddDataItem(DataItemFactory.GetDoubleB1ChanItem(333, 333));
            dataUnit.AddDataItem(DataItemFactory.GetDoubleB1ChanItem(444, 444));

            for (int i = 0; i < 3; i++)
            {
                DataUnit dataUnit_Mile = CopyDataUnit(dataUnit);
                AddDataParamItem(dataUnit_Mile, i);
                ChangeData(dataUnit_Mile, i);

                Console.WriteLine(dataUnit_Mile);
            }
        }

        private DataUnit CopyDataUnit(DataUnit dataUnit)
        {
            DataUnit dataUnit_Mile = new DataUnit();
            dataUnit_Mile.DataItemsList.Clear();
            dataUnit_Mile.DataParamItemsList.Clear();
            foreach (var item in dataUnit.DataItemsList)
            {
                dataUnit_Mile.AddDataItem(item);
            }
            foreach (var item in dataUnit.DataParamItemsList)
            {
                dataUnit_Mile.AddDataParamItem(item);
            }
            return dataUnit_Mile;
        }

        private void ChangeData(DataUnit dataUnit_Mile, int i)
        {
            dataUnit_Mile.ChangeValue(i, i.ToString());
        }

        private void AddDataParamItem(DataUnit dataUnit_Mile, int i)
        {
            dataUnit_Mile.AddDataParamItem(DataItemFactory.GetDateItem(DateTime.Now));
        }
    }
}
