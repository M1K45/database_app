using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Threading.Tasks;
using database_app;

// console app for bacis API call
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
            WeatherAPI foo = JsonSerializer.Deserialize<WeatherAPI>(response);
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

