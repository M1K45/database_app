using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Threading.Tasks;
using database_app;

/*
 * Pytania do prowadzącego 
 * - problem z bazą danych - nie mogę jej utworzyć
 * - jak dodać na gita kolejny projekt, jeśli go się utworzyło? 
 */ 


namespace database_app
{

    public class APITest
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call = "https://api.openweathermap.org/data/2.5/weather?lat=51&lon=51&appid=35191f5f03089db2dc2d68f960ec6bcb";
            string response = await client.GetStringAsync(call);
            Weather foo = JsonSerializer.Deserialize<Weather>(response);
            Console.WriteLine(response);
            Console.WriteLine("Wynik: " + foo.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            APITest test = new APITest();
            test.GetData().Wait();
            
        }
    }
}

//using database_app;
//using System.Text.Json;

//namespace WinFormsApp1
//{
//    public partial class Form1 : Form
//    {
//        private HttpClient client;
//        public Form1()
//        {
//            InitializeComponent();
//            client = new HttpClient();
//        }

//        private async void button1_Click(object sender, EventArgs e)
//        {
//            string key = "35191f5f03089db2dc2d68f960ec6bcb";
//            string call = $"https://api.openweathermap.org/data/2.5/weather?q=Wroclaw&appid={key}";
//            string response = await client.GetStringAsync(call);
//            Weather weather = JsonSerializer.Deserialize<Weather>(response);
//            listBox1.Items.Add(weather.ToString());
//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
