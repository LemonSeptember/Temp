using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resources;

namespace Temp.UC
{

    /// <summary>
    /// 基本信息显示
    /// </summary>
    public partial class UCBasicInfo : UserControl
    {
        private const string DATE_DISPLAY_FORMAT = "yyy.MM.dd";

        public UCBasicInfo()
        {
            InitializeComponent();

            tableLayoutPanel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel, true, null);
        }

        public void UpdateBasicInfo(BasicInfo basicInfo)
        {
            if (basicInfo == null) { return; }

            labelNumberValue.Text = basicInfo.MacID.ToString();
            labelDataValue.Text = basicInfo.Date.ToString(DATE_DISPLAY_FORMAT);
            labelModelValue.Text = MacTypeDisplayValue(basicInfo.MacType);
            labelUserValue.Text = UserNumDisplayValue(basicInfo.User);
            labelTeamValue.Text = basicInfo.Team;
            labelWorkAreaValue.Text = basicInfo.WorkArea;
            labelCompanyValue.Text = basicInfo.Company;
            labelSideTypeValue.Text = SideStringDisplayValue(basicInfo.Side);
            labelLinkTypeValue.Text = LinkTypeDisplayValue(basicInfo.LinkType);
            labelCountValue.Text = CountDisplayValue(basicInfo.Count);
            //labelLineTypeValue.Text = LineTypeDisplayValue(basicInfo.LineType);


        }

        //private string LineTypeDisplayValue(xfLineType lineType)
        //{
        //    switch (lineType)
        //    {
        //        case xfLineType.MainLine;
        //    }

        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private string CountDisplayValue(short count)
        {
            if (count == short.MinValue)
                return string.Empty;
            else if (count == 1)
                return ResourceService.GetString("DrawPanel.count_down");
            else
                return ResourceService.GetString("DrawPanel.count_up");

        }

        /// <summary>
        /// 获取行别信息
        /// </summary>
        /// <param name="linkType"></param>
        /// <returns></returns>
        private string LinkTypeDisplayValue(short linkType)
        {
            switch (linkType)
            {
                case -1:
                    return string.Empty;
                case 0:
                    return ResourceService.GetString("FileReading.upstream");
                case 1:
                    return ResourceService.GetString("FileReading.downstream");
                case 2:
                    return ResourceService.GetString("FileReading.Station");
                case 3:
                    return ResourceService.GetString("FileReading.Link_line");
                case 4:
                    return ResourceService.GetString("FileReading.Single");
                default:
                    return ResourceService.GetString("FileReading.other");
            }
        }

        /// <summary>
        /// 股别字符串
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        private string SideStringDisplayValue(short side)
        {
            if (side == short.MinValue)
            {
                return string.Empty;
            }
            else if (side == 1)
            {
                return ResourceService.GetString("左");
            }
            else
            {
                return ResourceService.GetString("右");
            }
        }
        

        /// <summary>
        /// 获取机器型号
        /// </summary>
        /// <param name="macType">机型</param>
        /// <returns></returns>
        private string MacTypeDisplayValue(short macType)
        {
            switch(macType)
            {
                case 0:
                    return "GCT-8C/11";
                case 1:
                    return "GCT-11/8C";
                case 2:
                    return "SP";
                case 3:
                    return "GL";
                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// 获取人员信息
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        private string UserNumDisplayValue(string userNum)
        {
            //得到新的人员信息
            if (Rapp.Instance.User_list.ContainsKey(userNum))
                return Rapp.Instance.User_list[userNum];
            else
                return userNum;
        }
    }


}
