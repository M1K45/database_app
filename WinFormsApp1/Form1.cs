using database_app;

using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public WeatherDBContext weather1;
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            weather1 = new WeatherDBContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string key = "35191f5f03089db2dc2d68f960ec6bcb";
            string call = $"https://api.openweathermap.org/data/2.5/weather?q=Wroclaw&appid={key}";
            string response = await client.GetStringAsync(call);
            Weather weather = JsonSerializer.Deserialize<Weather>(response);
            listBox1.Items.Add(weather.ToString());
        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            weather1.weathers.Add(new Weather()
            {
                name = city.Text,
                timezone = int.Parse(timezone.Text),
                main = new Temperature()
                {
                    temperature = double.Parse(temp.Text)
                },
                weather = new List<Description>()
                {
                    new Description()
                    {
                        description = weatherBox.Text
                    }
                }
            });
        }
    }
}
