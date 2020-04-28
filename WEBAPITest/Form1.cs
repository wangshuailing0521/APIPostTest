using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WEBAPITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.Url = "http://desktop-ru7vte7/k3cloud/Kingdee.BOS.WebApi.ServicesStub.AuthService.ValidateUser.common.kdsvc";           
            List<object> Parameters = new List<object>();
            Parameters.Add("5ea0f099c8bbcf");//安吉测试帐套Id
            Parameters.Add("administrator");//用户名
            Parameters.Add("888888");//密码
            Parameters.Add(2052);
            httpClient.Content = JsonConvert.SerializeObject(Parameters);
            string ssss = httpClient.AsyncRequest();
            var iResult = JObject.Parse(httpClient.AsyncRequest())["LoginResultType"].Value<int>();
            if (iResult == 1)
            {
                //todo:验证成功，处理业务
                httpClient.Url = string.Concat("http://desktop-ru7vte7/k3cloud/WSL.YY.K3.FIN.PlugIn.API.Cust.ExecuteService,WSL.YY.K3.FIN.PlugIn.common.kdsvc");
                Parameters = new List<object>();

                //string ss = @"{ ""Creator"":"""",""NeedUpDateFields"":[],""NeedReturnFields"":[],""IsDeleteEntry"":""True"",""SubSystemId"":"""",
                //""IsVerifyBaseDataField"":""false"",""Model"":

                //{""FAlterID"":""0"",""FBillNo"":"""",""FBillType"":{""FNumber"":""1""},""FDate"":""2018-03-27"",
                //""Fjopnum"":""RK2018032200001"",
                //""FAssetOrgID"":{""FNumber"":""101.1""},
                //""FOwnerOrgID"":{""FNumber"":""101.1""},
                //""FName"":""大众高尔夫 1.6 AT|时尚型|白色|沪A00000"",
                //""FAssetTypeID"":{""FNumber"":""ZCLB02_SYS""},
                //""FUnitID"":{""FNumber"":""liang""},""FQuantity"":""1"",
                //""FAssetStatusID"":{""FNumber"":""ZCZT01_SYS""},
                //""FAlterModeID"":{""FNumber"":""BDFS01_SYS""},
                //""FBeginUseDate"":""2018-03-27"",""FZCLBBASE"":{""FNumber"":""112""},""FDisposalType"":""0"",""FWZBase"":{""FNumber"":""00""},
                //""FCARTYPE"":""1"",""FText"":""沪A00000"",""FCJNUMBER"":""wsx"",""FSource"":""1"",
                //""FCLPPCombo"":""1"",

                //""FFinance"":[{""FFinanceID"":""0"",""FAcctPolicyID"":{""FNumber"":""KJZC01_SYS""},
                //""FAcctDate"":""2018-03-27"",""FOriginalCost"":""489000.00"",""FLifePeriods"":""60"",
                //""FDeprMethod"":""1"",""FInputTax"":""11000.00"",""FExpenseValue"":""10000.00"",
                //""FFinanceCurrencyID"":{""FNumber"":""PRE001""},""FPurchaseValue"":""500000.00"",
                //""FResidualIncome"":""350""}],
                //""FInvoice"":[{""FEntryID"":""0"",""FINVOICENO"":""wsx"",""FINVOICEDATE"":""2018-03-22"",""FALLAMOUNTFOR"":""500000.00"",
                //""FAMOUNTFOR"":""489000.00""}],

                //""FCardDetail"":[{""FID"":""0"",""FDetailQuantity"":""1""}]}}";
                //                string ss = @"{ ""Creator"":"""",""NeedUpDateFields"":[],""NeedReturnFields"":[],""IsDeleteEntry"":""True"",
                //""SubSystemId"":"""",""IsVerifyBaseDataField"":""false"",""Model"":

                //{""FID"":""0"",""FBillNo"":"""",""FBillType"":{""FNumber"":""SCLLD01_SYS""},""FDate"":""2018-05-31"",
                //""FAssetOrgID"":{""FNumber"":""100.02.07.01""},""FOwnerOrgID"":{""FNumber"":""100.02.07.01""},
                //""FASSETTYPEID"":{""FNumber"":""1""},""FDisPoseMethod"":{""FNumber"":""BDFS10_SYS""},""FPeriodEnddate"":""2018-05-31"",
                //""FDisposeReason"":"""",""FAlterModeID"":{""FNumber"":""BDFS08_SYS""},
                //""FDISPOSALENTRY"":[{""FEntryID"":""0"",""FAlterId"":{""FNumber"":""02-11A-02-108-SH""},
                //""FDisposalCurrency"":{""FNumber"":""PRE001""},
                //""FDisposalFinance"":[{""FDetailID"":""0"",""FCAmount"":90500,""FQAmount"":12482.76}],
                //""FQuantity"":1,""FDISPOSEQTY"":1
                //}]
                //}}";
                // string ss = @"{""Creator"":"""",""NeedUpDateFields"":[],""NeedReturnFields"":[],""IsDeleteEntry"":""True"",""SubSystemId"":"""",""IsVerifyBaseDataField"":""false"",""Model"":{""FID"":""0"",""FBillNo"":"""",""FBillType"":{""FNumber"":""SCLLD01_SYS""},""FDate"":""2018 - 10 - 18"",""FAssetOrgID"":{""FNumber"":""100.02.02.01""},""FOwnerOrgID"":{""FNumber"":""100.02.02.01""},""FASSETTYPEID"":{""FNumber"":""1""},""FDisPoseMethod"":{""FNumber"":""BDFS10_SYS""},""FPeriodEnddate"":""2018 - 10 - 18"",""FDisposeReason"":"""",""FAlterModeID"":{""FNumber"":""BDFS08_SYS""},""FDISPOSALENTRY"":[{""FEntryID"":""0"",""FAlterId"":{""FNumber"":""02 - 127 - 05 - 063 - BJ""},""FDisposalCurrency"":{""FNumber"":""PRE001""},""FDisposalFinance"":[{""FDetailID"":""0"",""FCAmount"":""29500.00"",""FQAmount"":""4068.970""}],""FQuantity"":""1"",""FDISPOSEQTY"":""1""}]}}";
//                string ss = @"{""Medtrum Organization"":""1003"",""Account Name"":""策划i"",
//""Billing Country"":""中国"",""Billing State"":""上海"",""Billing City"":""上海市"",
//""Billing Street"":""普陀区"",
//""Settlement Method"":""JSFS01_SYS"",""Payment Terms"":""SKTJ02"",""IsVerifyBaseDataField"":""false"",
//""Model"":{""FOrgId"":{""FNumber"":""100.02.03.04""},""FSupplier"":{""FNumber"":""100.02.01.05""},
//""FAmount"":""75000.00"",""FNote"":"""",""FReceiveDate"":""2018 - 10 - 01"",""FReceiveAccount"":""123456789"",
//""FEntity"":[{""FEAmount"":""75000.00"",""FENote"":"""",""FAllAmount"":""75000.00"",
//""FOrg"":{""FNumber"":""100.02.03.04""}}]}}";

                string ss = @"{
""Medtrum Organization"":""移宇集团"",
""Account Name"":""测试31"",
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
""Billing Contact"":""测试31"",
""Billing Email"":""490652587@qq.com"",
""Type"":""""
}";
                Parameters.Add(ss);
                httpClient.Content = JsonConvert.SerializeObject(Parameters);
                var responseOut = httpClient.AsyncRequest();
                MessageBox.Show(responseOut);
            }
        }
    }
}
