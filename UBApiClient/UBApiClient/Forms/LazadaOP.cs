using Lazop.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UBApiClient.Forms
{
    public partial class LazadaOP : DevExpress.XtraEditors.XtraForm
    {
        public LazadaOP()
        {
            InitializeComponent();
        }

        private void GetProduct()
        {
            string url = "https://api.lazada.co.th/rest/";
            string appkey = "104263";
            string appSecret = "pDXPlirsfPMUfgcslqXTgxzenmUNaCyv";
            string accessToken = "50000901914ecEatweZfAUCKsw1bd00238hohNIzHQyDlzmpqCxv2wrmwzXSRI";

            ILazopClient client = new LazopClient(url, appkey, appSecret);
            LazopRequest request = new LazopRequest();
            request.SetApiName("/products/get");
            request.SetHttpMethod("GET");
            request.AddApiParameter("filter", "live");
            request.AddApiParameter("update_before", "");
            request.AddApiParameter("search", "");
            request.AddApiParameter("create_before", "");
            request.AddApiParameter("offset", "");
            request.AddApiParameter("create_after", "");
            request.AddApiParameter("update_after", "");
            request.AddApiParameter("limit", "");
            request.AddApiParameter("options", "");
            request.AddApiParameter("sku_seller_list", "");
            LazopResponse response = client.Execute(request, accessToken);
            Console.WriteLine(response.IsError());
            Console.WriteLine(response.Body);
        }

        private void GetAccessToken()
        {
            string url = "https://auth.lazada.com/rest/";
            string appkey = "104263";
            string appSecret = "pDXPlirsfPMUfgcslqXTgxzenmUNaCyv";

            ILazopClient client = new LazopClient(url, appkey, appSecret);
            LazopRequest request = new LazopRequest();
            request.SetApiName("/auth/token/create");
            request.AddApiParameter("code", "0_104263_As2Mg6jkZjT0NNJDWYjCCVgL114");
            LazopResponse response = client.Execute(request);
            Console.WriteLine(response.IsError());
            Console.WriteLine(response.Body);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.GetProduct();
            //this.GetAccessToken();
        }
    }
}
