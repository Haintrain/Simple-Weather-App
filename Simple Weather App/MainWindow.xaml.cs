using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;
using System.Reflection.Metadata;

namespace Simple_Weather_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public string lon = "";

        public MainWindow()
        {
            InitializeComponent();
            WeatherInfo weather = new WeatherInfo();
            weather.cityName = "Auckland";

            weather.findCity();
            
    

        }

        public void getWeatherButton()
        {

        }


    }

    public class WeatherInfo
    {
        private string URL = "https://api.openweathermap.org/data/3.0/onecall?lat=";
        string APIKey = "a549e8431ab44cd0cf5441b58ca18a52";

        public string cityName = "";

        public string cityLocation = "";



        static readonly HttpClient client = new HttpClient();

        static async Task getInfo()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        public async Task<string> findCityInfo()
        {
            string cityURL = "http://api.openweathermap.org/geo/1.0/direct?q=" + cityName + "&limit=5&appid=" + APIKey;

            string responseBody = await client.GetStringAsync(cityURL);
            return responseBody;
        }

        public async Task findCity()
        {
            cityLocation = await findCityInfo();
            MessageBox.Show(cityLocation);

            var cityInfo = JsonSerializer.Deserialize<List<CityInfo>>(cityLocation);
            MessageBox.Show(cityInfo[0].name);
        }
    }
    public class LocalNames
    {
        public string io { get; set; }
        public string ca { get; set; }
        public string en { get; set; }
        public string id { get; set; }
        public string zh { get; set; }
        public string mi { get; set; }
        public string uk { get; set; }
        public string kn { get; set; }
        public string gd { get; set; }
        public string tr { get; set; }
        public string mn { get; set; }
        public string ko { get; set; }
        public string oc { get; set; }
        public string la { get; set; }
        public string ro { get; set; }
        public string te { get; set; }
        public string he { get; set; }
        public string bh { get; set; }
        public string sh { get; set; }
        public string ha { get; set; }
        public string sw { get; set; }
        public string ar { get; set; }
        public string ce { get; set; }
        public string lv { get; set; }
        public string fj { get; set; }
        public string pt { get; set; }
        public string ms { get; set; }
        public string an { get; set; }
        public string ur { get; set; }
        public string fo { get; set; }
        public string pa { get; set; }
        public string ky { get; set; }
        public string tt { get; set; }
        public string mk { get; set; }
        public string sm { get; set; }
        public string ta { get; set; }
        public string bg { get; set; }
        public string sr { get; set; }
        public string hy { get; set; }
        public string sk { get; set; }
        public string da { get; set; }
        public string kv { get; set; }
        public string gl { get; set; }
        public string az { get; set; }
        public string ga { get; set; }
        public string sv { get; set; }
        public string be { get; set; }
        public string no { get; set; }
        public string sc { get; set; }
        public string cu { get; set; }
        public string pl { get; set; }
        public string cs { get; set; }
        public string eo { get; set; }
        public string fr { get; set; }
        public string br { get; set; }
        public string nn { get; set; }
        public string hu { get; set; }
        public string qu { get; set; }
        public string ps { get; set; }
        public string vi { get; set; }
        public string hi { get; set; }
        public string uz { get; set; }
        public string jv { get; set; }
        public string de { get; set; }
        public string af { get; set; }
        public string my { get; set; }
        public string am { get; set; }
        public string cy { get; set; }
        public string es { get; set; }
        public string os { get; set; }
        public string it { get; set; }
        public string el { get; set; }
        public string ug { get; set; }
        public string @is { get; set; }
        public string hr { get; set; }
        public string th { get; set; }
        public string ru { get; set; }
        public string mr { get; set; }
        public string gu { get; set; }
        public string nl { get; set; }
        public string et { get; set; }
        public string ml { get; set; }
        public string ie { get; set; }
        public string bn { get; set; }
        public string ka { get; set; }
        public string na { get; set; }
        public string fy { get; set; }
        public string eu { get; set; }
        public string fi { get; set; }
        public string vo { get; set; }
        public string ja { get; set; }
        public string to { get; set; }
    }

    public class CityInfo
    {
        public string name { get; set; }
        public LocalNames local_names { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string country { get; set; }
        public string state { get; set; }
    }

}

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);



