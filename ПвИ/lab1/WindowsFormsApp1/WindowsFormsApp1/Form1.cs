using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.valueOne.Text, out int firstValue) && int.TryParse(this.valueTwo.Text, out int secondValue))
            {

                var nvc = new List<KeyValuePair<string, string>>();
                nvc.Add(new KeyValuePair<string, string>("x", this.valueOne.Text));
                nvc.Add(new KeyValuePair<string, string>("y", this.valueTwo.Text));

                var url = "http://172.16.193.234:10109/task4/";
                using (var client = new HttpClient())
                {
                    var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(nvc) };
                    var res = await client.SendAsync(req);
                    this.result.Text = res.Content.ReadAsStringAsync().Result; ;
                }


            }
        }

    }
}
