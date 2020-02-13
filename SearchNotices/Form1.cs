using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Configuration;
using System.Diagnostics;

namespace SearchNotices
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

      void ChangeEnabled(bool enabled)
      {
         foreach (Control c in this.Controls)
         {
            c.Enabled = enabled;
         }
      }

      private void btnCallApi_Click(object sender, EventArgs e)
      {
         ChangeEnabled(false);
         Application.UseWaitCursor = true;
         txtFilePath.Text = "";
         ProcessAPI();
         Application.UseWaitCursor = false;
         ChangeEnabled(true);
      }

      private void ProcessAPI()
      {
         try
         {
            string StrEndpoint = ConfigurationSettings.AppSettings["EndPoint"].ToString();
            string FirmId = ConfigurationSettings.AppSettings["FirmId"].ToString();
            string UserName = ConfigurationSettings.AppSettings["UserName"].ToString();
            string Password = ConfigurationSettings.AppSettings["Password"].ToString();

            string NDate = DateNotice.Value.ToString("yyyyMMdd"); //20191106
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(StrEndpoint);
            byte[] bytes;
            string StrXml = @"<soapenv:Envelope xmlns:soapenv = ""http://schemas.xmlsoap.org/soap/envelope/""><soapenv:Header><s:Security soapenv:mustUnderstand=""1"" xmlns:u=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"" xmlns:s=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd""><s:UsernameToken u:Id=""unt_20""><s:Username>" + UserName;
            StrXml = StrXml + @"</s:Username><s:Password Type=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"">" + Password;
            StrXml = StrXml + @"</s:Password></s:UsernameToken></s:Security></soapenv:Header><soapenv:Body><a:searchNotices xmlns:a=""http://webservice.civilfiling.ecourts.ito.aoc.nj/""><arg0><firmId>" + FirmId;
            StrXml = StrXml + @"</firmId><noticeDate>" + NDate + "</noticeDate></arg0></a:searchNotices></soapenv:Body></soapenv:Envelope>";
            bytes = System.Text.Encoding.ASCII.GetBytes(StrXml);
            request.ContentType = "text/xml; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
               Stream responseStream = response.GetResponseStream();
               string responseStr = new StreamReader(responseStream).ReadToEnd();

               int startIndex = responseStr.IndexOf(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"">");
               int endIndex = responseStr.IndexOf(@"</soapenv:Envelope>");
               var xml = responseStr.Substring(startIndex, endIndex - startIndex + 19);


               string[] tokens = responseStr.Split(new[] { "Content-ID" }, StringSplitOptions.None);
               StringBuilder sb = new StringBuilder();
               foreach (string data in tokens)
               {
                  string part = data;
                  if (part.Contains("apache.org") && part.Contains("--MIMEBoundary") && !part.Contains("xml"))
                  {
                     int startIndex1 = part.IndexOf(@"apache.org>");
                     int endIndex1 = part.IndexOf(@"--MIMEBoundary");
                     var xml1 = part.Substring(startIndex1 + 11, endIndex1 - startIndex1 - 11);
                     sb.Append(xml1.ToString() + Environment.NewLine);
                  }
               }
               if (sb.Length > 0)
               {
                  string filePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                  filePath = Path.Combine(filePath, "Result_" + DateTime.Now.ToString("yyyyMMMdd_hhmmss") + ".txt");
                  File.WriteAllText(filePath, sb.ToString());
                  txtFilePath.Text = filePath;
                  Process.Start("notepad.exe", filePath);

               }
               else
               {
                  MessageBox.Show("No data received");
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"ERROR: {ex.Message}");
         }

      }

      private void button1_Click(object sender, EventArgs e)
      {
         string filePath = txtFilePath.Text;
         if (!string.IsNullOrWhiteSpace(filePath))
            Process.Start("notepad.exe", filePath);
         else
            MessageBox.Show("Invalid file path");
      }
   }
}
