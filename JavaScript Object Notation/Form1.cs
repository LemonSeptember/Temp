using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JavaScript_Object_Notation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////JavaScriptSerializer javaScript = new JavaScriptSerializer();
            //var objects = new { name = "百度经验" };
            //string str = JsonConvert.SerializeObject(objects);
            //JArray jArray;


            //string jsonText = @"{""zone"":""海淀"",""zone_en"":""haidian""}";
            //JObject jObject = (JObject)JsonConvert.DeserializeObject(jsonText);



            //int retCode = -1;//返回码，0表示成功，其他表示失败
            //string returnMessage = string.Empty;//返回消息，对返回码的描述
            //string jsonStr = "{\"RetCode\":3,\"ReturnMessage\":\"测试消息\"}";
            //JObject jsonObj = JsonConvert.DeserializeObject<JObject>(jsonStr);
            //if (jsonObj != null)
            //{
            //    if (jsonObj.ContainsKey("RetCode") && jsonObj["RetCode"] != null)
            //    {
            //        int.TryParse(jsonObj["RetCode"].ToString(), out retCode);
            //    }

            //    if (jsonObj.ContainsKey("ReturnMessage") && jsonObj["ReturnMessage"] != null)
            //    {
            //        returnMessage = jsonObj["ReturnMessage"].ToString();
            //    }
            //}



        }

        //public static JArray GetData2JArray(string url, string key)
        //{
        //string jsonData = HttpHelper.HttpGet(url, "", "gb2312");
        //JObject obj = JObject.Parse(jsonData);
        //return (JArray)obj[key];
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //D:\Project\Replay2\.vs\VSWorkspaceState.json

            ReadJSONfile();
        }

        private void ReadJSONfile()
        {
            try
            {
                StreamReader file = File.OpenText(@"D:\Project\Replay2\.vs\VSWorkspaceState.json");
                JsonTextReader reader = new JsonTextReader(file);
                JObject jsonObject = (JObject)JToken.ReadFrom(reader);

                firstName = (JArray)jsonObject["ExpandedNodes"];
                lastName = (string)jsonObject["SelectedNode"];
                boolName = (bool)jsonObject["PreviewInSolutionExplorer"];

                richTextBox1.Text = jsonObject.First.ToString() + "\n";
                richTextBox1.AppendText(firstName.ToString() + "\n");
                richTextBox1.AppendText(lastName + "\n");
                richTextBox1.AppendText(boolName.ToString());

                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //throw;
            }
        }
        JArray firstName;
        string lastName;
        bool boolName;
        private void WriteJSON()
        {
            string fileName = @"C:\Users\KETIZU2\Desktop\abc.json";
            try
            {
                string json = File.ReadAllText(@"D:\Project\Replay2\.vs\VSWorkspaceState.json");
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                jsonObj["L_BPointMoveDelay"] = firstName.ToString();
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(fileName, output);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteJSON();
        }
    }
}

