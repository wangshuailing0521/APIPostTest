using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WEBAPITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.request_txt.Text = @"{
                ""Medtrum Organization"":""上海移宇科技股份有限公司"",
                ""Account Name"":""测试35"",
                ""Billing Country"":""中国"",
                ""Billing Region"":""上海"",
                ""Billing State"":""上海"",
                ""Billing City"":"""",
                ""Billing Street"":"""",
                ""Shipping Country"":""中国"",
                ""Shipping State"":""北京"",
                ""Shipping City"":""大庆"",
                ""Shipping Street"":"""",
                ""Settlement Method"":""现金"",""Payment Terms"":""Net 30 Days"",
                ""Billing Contact"":""测试33"",
                ""Billing Email"":""490652587@qq.com"",
                ""Type"":""""
                }";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUrl = this.loginUrl_txt.Text;
            string dbid = this.dbid_txt.Text;
            string user = this.user_txt.Text;
            string password = this.password_txt.Text;

            HttpClient httpClient = new HttpClient();
            httpClient.Url = loginUrl;          
            List<object> Parameters = new List<object>();
            Parameters.Add(dbid);
            Parameters.Add(user);
            Parameters.Add(password);

            //httpClient.Url = "http://47.254.177.237/k3cloud/Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUser.common.kdsvc";
            //Parameters.Add("5ea10048eff238");
            //Parameters.Add("沈蓉");
            //Parameters.Add("804420");

            Parameters.Add(2052);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            var iResult = JObject.Parse(httpClient.AsyncRequest())["LoginResultType"].Value<int>();
            if (iResult == 1)
            {
                string url = this.url_txt.Text;
                //todo:验证成功，处理业务
                httpClient.Url = url;

                Parameters = new List<object>();

                #region 销售订单
                string ss = @"{
                ""Medtrum Organization"":""上海移宇科技股份有限公司"",
                ""Account Name"":""Lobeck Medical AG"",
                ""Deal Name"":""谢晓琳"",
                ""Currency"":""欧元"",
                ""Exchange Rate"":""12"",
                ""Description"":""test"",
                ""CRD"":""2020-05-03 00:00:00"",
                ""Type"":""order"",
                ""Details"":[{
                ""Product Details Name"":""电阻 1ohm"",
                ""Quantity"":10,
                ""List Price"":123}]
                }";
                #endregion

                Parameters.Add(this.request_txt.Text);
                httpClient.Content = JsonConvert.SerializeObject(Parameters);
                var responseOut = httpClient.AsyncRequest();
                this.response_txt.Text = responseOut;
            }
        }
    }
}
