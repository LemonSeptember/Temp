using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace IP_Test
{
    public partial class Form_IP_Test : Form
    {
        public Form_IP_Test()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                IPAddress localIP = endPoint.Address;
                Console.WriteLine(endPoint);
                Console.WriteLine(localIP);
            }
        }

        private void button_SetIP_Click(object sender, EventArgs e)
        {
            SetIP();
        }

        private void setIPaddress()
        {
            string _ipaddress = "192.168.111.222";
            string _submask = "255.255.255.0";
            string _gateway = "192.168.111.1";
            string _dns1 = "123.1.11.1";

            string _doscmd = "netsh interface ip set address 本地连接 static " + _ipaddress + " " + _submask + " " + _gateway + " 1";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(_doscmd.ToString());
            _doscmd = "netsh interface ip set dns 本地连接 static " + _dns1;
            p.StandardInput.WriteLine(_doscmd.ToString());

            p.StandardInput.WriteLine("exit");
        }

        private void SetIP()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"])
                {
                    Console.WriteLine(mo.ToString());
                    ManagementBaseObject obj;

                    obj = mo.GetMethodParameters("EnableStatic");
                    Console.WriteLine(obj["IPAddress"]);
                    if (obj != null)
                    {
                        obj["IPAddress"] = new string[] { "192.168.1.100" };
                        obj["SubnetMask"] = new string[] { "255.255.255.0" };
                        mo.InvokeMethod("EnableStatic", obj, null);
                    }

                    if (obj != null)
                    {
                        obj = mo.GetMethodParameters("SetGateways");
                        obj["DefaultIPGateway"] = new string[] { "192.168.1.1" };
                        mo.InvokeMethod("SetGateways", obj, null);
                    }

                    obj = mo.GetMethodParameters("SetDNSServerSearchOrder");
                    if (obj != null)
                    {
                        string[] s = { "8.8.8.8", "8.8.8.4" };
                        obj["DNSServerSearchOrder"] = s;
                        mo.InvokeMethod("SetDNSServerSearchOrder", obj, null);
                    }
                    //break;
                }
            }
        }

        /// <summary>
        /// 设置静态IP
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="submask"></param>
        /// <param name="getway"></param>
        /// <param name="dns"></param>
        /// <param name="NetworkInterfaceID"></param>
        /// <returns></returns>
        private bool SetIPAddress(string[] ip, string[] submask, string[] getway, string[] dns, string NetworkInterfaceID)
        {
            if (string.IsNullOrEmpty(NetworkInterfaceID)) return false;
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            bool result = true;
            foreach (ManagementObject mo in moc)
            {
                if (NetworkInterfaceID == mo["SettingID"].ToString())
                {
                    string str;
                    ManagementBaseObject outPar;
                    ManagementBaseObject inPar;
                    if (ip != null && submask != null)
                    {
                        inPar = mo.GetMethodParameters("EnableStatic");
                        inPar["IPAddress"] = ip;
                        inPar["SubnetMask"] = submask;
                        outPar = mo.InvokeMethod("EnableStatic", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        result = result && (str == "0" || str == "1");
                    }
                    if (getway != null)
                    {
                        inPar = mo.GetMethodParameters("SetGateways");
                        inPar["DefaultIPGateway"] = getway;
                        outPar = mo.InvokeMethod("SetGateways", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        result = result && (str == "0" || str == "1");
                    }
                    if (dns != null)
                    {
                        inPar = mo.GetMethodParameters("SetDNSServerSearchOrder");
                        inPar["DNSServerSearchOrder"] = dns;
                        outPar = mo.InvokeMethod("SetDNSServerSearchOrder", inPar, null);
                        str = outPar["returnvalue"].ToString();
                        result = result && (str == "0" || str == "1");
                    }
                    return result;
                }
            }
            return false;
        }

        /// <summary>
        /// 设置自动IP
        /// </summary>
        /// <param name="NetworkInterfaceID"></param>
        /// <returns></returns>
        private bool SetIPAddress(string NetworkInterfaceID)
        {
            if (string.IsNullOrEmpty(NetworkInterfaceID)) return false;
            ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = wmi.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (!(bool)mo["IPEnabled"])
                    continue;
                if (NetworkInterfaceID == mo["SettingID"].ToString())
                {
                    mo.InvokeMethod("SetDNSServerSearchOrder", null);
                    mo.InvokeMethod("EnableStatic", null);
                    mo.InvokeMethod("SetGateways", null);
                    mo.InvokeMethod("EnableDHCP", null);
                    return true;
                }
            }
            return false;
        }
    }
}
