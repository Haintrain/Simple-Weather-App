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
using System.Globalization;

namespace Simple_Weather_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeatherReport weather;

        IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-EN");



        public string lon = "";

        public MainWindow()
        {
            InitializeComponent();
            weather = new WeatherReport();
        }

        public void GetWeatherButton(object sender, RoutedEventArgs e)
        {
            weather.cityInfo = null;
            weather.cityName = MainTextBox.Text.ToString();

            waiting();
        }

        async Task waiting()
        {
            int value = await weather.FindCity();

            if(value == -1)
            {
                return;
            }

            double temperatureCelcius = Math.Round(double.Parse(weather.weatherInfo.main.temp.ToString(), provider) - 273.15, 2);
            double temperatureFahrenheit = Math.Round(temperatureCelcius * 9 / 5 + 32, 2);

            MainTextBlock.Text = char.ToUpper(weather.weatherInfo.weather[0].description[0]) + weather.weatherInfo.weather[0].description.Substring(1) + " and a temperature of " + temperatureCelcius.ToString() + " C or " + temperatureFahrenheit.ToString() + " F";
        }
    }

    public class WeatherReport
    {
        string APIKey = "a549e8431ab44cd0cf5441b58ca18a52";

        public string cityName = "";
        public string cityLocation = "";

        public List<CityInfo>? cityInfo = new List<CityInfo>();
        public WeatherInfo? weatherInfo = new WeatherInfo();

        static readonly HttpClient client = new HttpClient();

        public async Task GetInfo()
        {
            string weatherURL = "https://api.openweathermap.org/data/2.5/weather?lat=" + cityInfo[0].lat + "&lon=" + cityInfo[0].lon + "&appid=" + APIKey;
            string responseBody = await client.GetStringAsync(weatherURL);

            cityLocation = responseBody;
            weatherInfo = JsonSerializer.Deserialize<WeatherInfo>(cityLocation);
        }

        public async Task<int> FindCity()
        {
            string cityURL = "http://api.openweathermap.org/geo/1.0/direct?q=" + cityName + "&limit=5&appid=" + APIKey;
            string responseBody = await client.GetStringAsync(cityURL);

            if (responseBody == "[]")
            {
                MessageBox.Show("Please enter a valid city");
                return -1;
            }

            cityLocation = responseBody;
            cityInfo = JsonSerializer.Deserialize<List<CityInfo>>(cityLocation);
      
            await GetInfo();

            return 1;
        }
    }
    public class LocalNames
    {
        public string? io { get; set; }
        public string? ca { get; set; }
        public string? en { get; set; }
        public string? id { get; set; }
        public string? zh { get; set; }
        public string? mi { get; set; }
        public string? uk { get; set; }
        public string? kn { get; set; }
        public string? gd { get; set; }
        public string? tr { get; set; }
        public string? mn { get; set; }
        public string? ko { get; set; }
        public string? oc { get; set; }
        public string? la { get; set; }
        public string? ro { get; set; }
        public string? te { get; set; }
        public string? he { get; set; }
        public string? bh { get; set; }
        public string? sh { get; set; }
        public string? ha { get; set; }
        public string? sw { get; set; }
        public string? ar { get; set; }
        public string? ce { get; set; }
        public string? lv { get; set; }
        public string? fj { get; set; }
        public string? pt { get; set; }
        public string? ms { get; set; }
        public string? an { get; set; }
        public string? ur { get; set; }
        public string? fo { get; set; }
        public string? pa { get; set; }
        public string? ky { get; set; }
        public string? tt { get; set; }
        public string? mk { get; set; }
        public string? sm { get; set; }
        public string? ta { get; set; }
        public string? bg { get; set; }
        public string? sr { get; set; }
        public string? hy { get; set; }
        public string? sk { get; set; }
        public string? da { get; set; }
        public string? kv { get; set; }
        public string? gl { get; set; }
        public string? az { get; set; }
        public string? ga { get; set; }
        public string? sv { get; set; }
        public string? be { get; set; }
        public string? no { get; set; }
        public string? sc { get; set; }
        public string? cu { get; set; }
        public string? pl { get; set; }
        public string? cs { get; set; }
        public string? eo { get; set; }
        public string? fr { get; set; }
        public string? br { get; set; }
        public string? nn { get; set; }
        public string? hu { get; set; }
        public string? qu { get; set; }
        public string? ps { get; set; }
        public string? vi { get; set; }
        public string? hi { get; set; }
        public string? uz { get; set; }
        public string? jv { get; set; }
        public string? de { get; set; }
        public string? af { get; set; }
        public string? my { get; set; }
        public string? am { get; set; }
        public string? cy { get; set; }
        public string? es { get; set; }
        public string? os { get; set; }
        public string? it { get; set; }
        public string? el { get; set; }
        public string? ug { get; set; }
        public string? @is { get; set; }
        public string? hr { get; set; }
        public string? th { get; set; }
        public string? ru { get; set; }
        public string? mr { get; set; }
        public string? gu { get; set; }
        public string? nl { get; set; }
        public string? et { get; set; }
        public string? ml { get; set; }
        public string? ie { get; set; }
        public string? bn { get; set; }
        public string? ka { get; set; }
        public string? na { get; set; }
        public string? fy { get; set; }
        public string? eu { get; set; }
        public string? fi { get; set; }
        public string? bvo { get; set; }
        public string? ja { get; set; }
        public string? to { get; set; }
    }

    public class CityInfo
    {
        public string? name { get; set; }
        public LocalNames? local_names { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string? country { get; set; }
        public string? state { get; set; }

        public void getCoords()
        {

        }
    }
    public class Clouds
    {
        public int all { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
    }

    public class WeatherInfo
    {
        public Coord? coord { get; set; }
        public List<Weather>? weather { get; set; }
        public string? @base { get; set; }
        public Main? main { get; set; }
        public int visibility { get; set; }
        public Wind? wind { get; set; }
        public Clouds? clouds { get; set; }
        public int dt { get; set; }
        public Sys? sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string? name { get; set; }
        public int cod { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string? country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string? main { get; set; }
        public string? description { get; set; }
        public string? icon { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }
    }
}