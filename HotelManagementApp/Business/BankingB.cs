using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
//using VietQR;
using RestSharp;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace Business
{
    /// <summary>
    /// APIRequestB.cs
    /// </summary>
    public class APIRequestB
    {
        public long accountNo { get; set; }
        public string accountName { get; set; }
        public int acqId { get; set; }
        public int amount { get; set; }
        public string addInfo { get; set; }
        public string format { get; set; }
        public string template { get; set; }
    }
    public class Data
    {
        public int acpId { get; set; }
        public string accountName { get; set; }
        public string qrCode { get; set; }
        public string qrDataURL { get; set; }
    }

    public class APIResponse
    {
        public string code { get; set; }
        public string desc { get; set; }
        public Data data { get; set; }
    }
    
    /// <summary>
    // BankB.cs
    /// </summary>
    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string bin { get; set; }
        public string shortName { get; set; }
        public string logo { get; set; }
        public int transferSupported { get; set; }
        public int lookupSupported { get; set; }
        public string short_name { get; set; }
        public int support { get; set; }
        public int isTransfer { get; set; }
        public string swift_code { get; set; }
    }

    public class BankB
    {
        public string code { get; set; }
        public string desc { get; set; }
        public IList<Datum> data { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>


    public class BankingB
    {
        private static readonly long soTaiKhoan = 1110566786;
        private static readonly string tenTaiKhoan = "NGUYEN HUU TUAN";
        private static readonly int maNganHang = 970418;
        private static readonly string format = "text";
        private static readonly string template = "print";

        public Image GetImageQR(int amout, string noiDung = null)
        {
            var apiResquest = new APIRequestB
            {
                accountNo = soTaiKhoan,
                accountName = tenTaiKhoan,
                acqId = maNganHang,
                amount = amout,
                addInfo = noiDung,
                format = format,
                template = template,
            };
            var jsonRequest = JsonConvert.SerializeObject(apiResquest);

            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;

            var dataResult = JsonConvert.DeserializeObject<APIResponse>(content);

            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            return image;
        }

        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }


}
