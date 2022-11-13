using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Client_Rest_in_.net_MAUI
{
    public partial class MainPage : ContentPage
    {
        HttpClient httpClient = new HttpClient();
        string auth;
        public MainPage()
        {
            InitializeComponent();
            httpClient.BaseAddress = new System.Uri("https://imost.iut-clermont.uca.fr/chimithequedev/");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>();
            User user = new User();
            user.person_email = txtEmail.Text;
            user.person_password = txtPassword.Text;
            auth = GetToken(user);
            edit.Text = auth;
            GetStorage();
        }

        private String GetToken(User _user)
        {
            var json = JsonConvert.SerializeObject(_user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("get-token", data).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            //var token = JsonConvert.DeserializeObject<Token>(responseString);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", responseString);
            return responseString;
        }

        private void GetStorage()
        {
            var response = httpClient.GetAsync("storelocations").Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            var storage = JsonConvert.DeserializeObject<Result>(responseString);
            edit.Text = edit.Text+" "+ storage.ToString();
        }

        private class User
        {
            public string person_email { get; set; }
            public string person_password { get; set; }
            
        }
        
        public class Result
        {
            public List<StoreLocation> Rows { get; set; } = new List<StoreLocation>();
            public int Total { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"[Rows :");
                foreach (var r in Rows)
                {
                    sb.Append($"\t{r}\n");
                }
                sb.Append($"[Total : {Total}]");
                return sb.ToString();
            }
        }

        public class StoreLocation
        {
            public StoreLocationId StoreLocation_Id { get; set; }

            public StoreLocationName StoreLocation_Name { get; set; }

            public override string ToString()
            {
                return $"[Id: {StoreLocation_Id.Int64}] ; [Name: {StoreLocation_Name.String}]";
            }
        }

        public class StoreLocationId
        {
            public long Int64 { get; set; }

            public bool Valid { get; set; }
        }

        public class StoreLocationName
        {
            public string String { get; set; }
            public bool Valid { get; set; }
        }
    }

    internal class Token
    {
        public string token { get; set; }
    }
}