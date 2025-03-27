using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;

namespace database_app
{
    
    //public class APITest
    //{
    //   public HttpClient client;
    //    public async Task GetData()
    //    {
    //        client = new HttpClient();
    //        string call = "https://api.openweathermap.org/data/2.5/weather?lat=51&lon=51&appid=35191f5f03089db2dc2d68f960ec6bcb";
    //        string response = await client.GetStringAsync(call);
    //        Console.WriteLine(response);
    //    }
    //}

    public async Task<Weather> GetInfoFromApi(string city)
    {
        using HttpClient client = new HttpClient();
        string API_key = "35191f5f03089db2dc2d68f960ec6bcb";
        string json = await client.GetStringAsync(
            $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_key}");
        return JsonSerializer.Deserialize<Weather>(json);

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //APITest api = new APITest();
            //api.GetData().Wait();
        }
    }
}