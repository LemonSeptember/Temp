using BLECode;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth_LE_Test
{
    public partial class FormBluetoothLE : Form
    {
        private BluetoothLECode bluetooth;

        private List<BluetoothInfo> mBluetoothInfoList;

        /// <summary>
        /// 服务UUID
        /// </summary>
        private const string characterUUID0 = "0000ffe0-0000-1000-8000-00805f9b34fb";

        private const string characterUUID1 = "0000ffe1-0000-1000-8000-00805f9b34fb";
        private const string characterUUID2 = "0000ffe2-0000-1000-8000-00805f9b34fb";
        private const string characterUUID3 = "0000ffe3-0000-1000-8000-00805f9b34fb";

        private byte[] mBluetoothCode1;
        private byte[] mBluetoothCode2;

        public FormBluetoothLE()
        {
            InitializeComponent();
        }

        private void FormBluetoothLE_Load(object sender, EventArgs e)
        {
            mBluetoothInfoList = new List<BluetoothInfo>();
            //var bluetooth = new BluetoothLECode(_serviceGuid, _writeCharacteristicGuid, _notifyCharacteristicGuid);
            //bluetooth = new BluetoothLECode("", "", "");
            bluetooth = new BluetoothLECode(characterUUID0, characterUUID3, "");
            bluetooth.ValueChanged += Bluetooth_ValueChanged;
            bluetooth.BLEInfoEvent += Bluetooth_BLEInfoEvent;
            SetByteList();
        }

        private void Bluetooth_BLEInfoEvent(string Name, string ID)
        {
            BluetoothInfo bluetoothInfo = new BluetoothInfo(Name, ID);
            if (mBluetoothInfoList.Contains(bluetoothInfo))
            {
                int index = mBluetoothInfoList.IndexOf(bluetoothInfo);
                mBluetoothInfoList[index].Name = bluetoothInfo.Name;
            }
            else
            {
                mBluetoothInfoList.Add(bluetoothInfo);
            }
        }

        private void Bluetooth_ValueChanged(MsgType type, string str, byte[] data = null)
        {
            richTextBox1.AppendText($"[{DateTime.Now.ToLongTimeString()}]\t");
            richTextBox1.AppendText(type + "\t");
            richTextBox1.AppendText(str + "\n");
            if (data != null)
            {
                richTextBox1.AppendText("data: " + "\n");
                foreach (byte item in data)
                {
                    richTextBox1.AppendText(item + "\n");
                }
            }
            //Console.WriteLine();
            //Console.WriteLine("type: " + type);
            //Console.WriteLine("str: " + str);
            //if (data != null)
            //{
            //    Console.WriteLine("data: ");
            //    foreach (var item in data)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //throw new NotImplementedException();
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            bluetooth.StartBleDeviceWatcher();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //string MAC = "11:89:20:08:65:c2";
                string MAC = "11:89:20:08:44:a2";
                _ = bluetooth.SelectDeviceFromIdAsync(MAC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void button_Break_Click(object sender, EventArgs e)
        {
            bluetooth.Dispose();
        }

        private void SetByteList()
        {
            mBluetoothCode1 = new byte[10];
            mBluetoothCode1[0] = 0xF1;
            mBluetoothCode1[1] = 0x01;
            mBluetoothCode1[2] = 0x10;
            mBluetoothCode1[3] = 0x44;
            mBluetoothCode1[4] = 0xA2;
            mBluetoothCode1[5] = 0xAA;
            mBluetoothCode1[6] = 0xB1;
            mBluetoothCode1[7] = 0xE7;
            mBluetoothCode1[8] = 0x01;
            mBluetoothCode1[9] = 0x00;

            mBluetoothCode2 = new byte[10];
            mBluetoothCode2[0] = 0xF1;
            mBluetoothCode2[1] = 0x01;
            mBluetoothCode2[2] = 0x10;
            mBluetoothCode2[3] = 0x65;
            mBluetoothCode2[4] = 0xC2;
            mBluetoothCode2[5] = 0xAA;
            mBluetoothCode2[6] = 0xB1;
            mBluetoothCode2[7] = 0xE7;
            mBluetoothCode2[8] = 0x01;
            mBluetoothCode2[9] = 0x00;
        }

        private void maskedTextBox_Bluetooth_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Console.WriteLine(e.Position);
            Console.WriteLine(e.RejectionHint);
        }

        #region Bluetooth 1

        private void button_BT1_Change_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox_BT1_Address.Enabled)
                {
                    if (maskedTextBox_BT1_Address.MaskFull)
                    {
                        ushort value = Convert.ToUInt16(maskedTextBox_BT1_Address.Text, 16);
                        byte[] temp = BitConverter.GetBytes(value);
                        // 反向
                        mBluetoothCode1[3] = temp[1];
                        mBluetoothCode1[4] = temp[0];

                        button_BT1_Change.Text = "更改";
                        maskedTextBox_BT1_Address.Enabled = false;
                    }
                    else
                    {
                        throw new Exception("输入错误");
                    }
                }
                else
                {
                    button_BT1_Change.Text = "完成";
                    maskedTextBox_BT1_Address.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton_BT1_Open_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                mBluetoothCode1[8] = 0x01;
                mBluetoothCode1[9] = 0x01;
                bluetooth.Write(mBluetoothCode1);
            }
        }

        private void radioButton_BT1_Close_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                mBluetoothCode1[8] = 0x01;
                mBluetoothCode1[9] = 0x00;
                bluetooth.Write(mBluetoothCode1);
            }
        }

        private void button_BT1_2_Click(object sender, EventArgs e)
        {
            mBluetoothCode1[8] = 0x02;
            mBluetoothCode1[9] = 0x01;
            bluetooth.Write(mBluetoothCode1);
            Task.Delay(400).Wait();
            mBluetoothCode1[9] = 0x00;
            bluetooth.Write(mBluetoothCode1);
        }

        private void button_BT1_3_Click(object sender, EventArgs e)
        {
            mBluetoothCode1[8] = 0x03;
            mBluetoothCode1[9] = 0x01;
            bluetooth.Write(mBluetoothCode1);
            Task.Delay(400).Wait();
            mBluetoothCode1[9] = 0x00;
            bluetooth.Write(mBluetoothCode1);
        }

        #endregion

        #region Bluetooth 2

        private void button_BT2_Change_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox_BT2_Address.Enabled)
                {
                    if (maskedTextBox_BT2_Address.MaskFull)
                    {
                        ushort value = Convert.ToUInt16(maskedTextBox_BT2_Address.Text, 16);
                        byte[] temp = BitConverter.GetBytes(value);
                        // 反向
                        mBluetoothCode2[3] = temp[1];
                        mBluetoothCode2[4] = temp[0];

                        button_BT2_Change.Text = "更改";
                        maskedTextBox_BT2_Address.Enabled = false;
                    }
                    else
                    {
                        throw new Exception("输入错误");
                    }
                }
                else
                {
                    button_BT2_Change.Text = "完成";
                    maskedTextBox_BT2_Address.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton_BT2_Open_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                mBluetoothCode2[8] = 0x01;
                mBluetoothCode2[9] = 0x00;
                bluetooth.Write(mBluetoothCode2);
            }
        }

        private void radioButton_BT2_Close_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                mBluetoothCode2[8] = 0x01;
                mBluetoothCode2[9] = 0x01;
                bluetooth.Write(mBluetoothCode2);
            }
        }

        private void button_BT2_2_Click(object sender, EventArgs e)
        {
            mBluetoothCode2[8] = 0x02;
            mBluetoothCode2[9] = 0x01;
            bluetooth.Write(mBluetoothCode2);
            Task.Delay(400).Wait();
            mBluetoothCode2[9] = 0x00;
            bluetooth.Write(mBluetoothCode2);
        }

        private void button_BT2_3_Click(object sender, EventArgs e)
        {
            mBluetoothCode2[8] = 0x03;
            mBluetoothCode2[9] = 0x01;
            bluetooth.Write(mBluetoothCode2);
            Task.Delay(400).Wait();
            mBluetoothCode2[9] = 0x00;
            bluetooth.Write(mBluetoothCode2);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in mBluetoothInfoList)
            {
                richTextBox1.AppendText(item.ID + "\n");
            }
        }
    }

    public class BluetoothInfo
    {
        public string Name;
        public string ID;

        public BluetoothInfo(string name, string id)
        {
            Name = name;
            ID = id;
        }

        public override bool Equals(object obj)
        {
            return obj is BluetoothInfo info && ID == info.ID;
        }

        public override int GetHashCode()
        {
            int hashCode = 1997165910;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            return hashCode;
        }
    }
}
