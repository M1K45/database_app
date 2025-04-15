using database_app;

using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public CityCountryDBContext CityCountry;
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            CityCountry = new CityCountryDBContext();

            listBoxCity.DataSource = CityCountry.Cities.ToList<City>();
            listBoxCountry.DataSource = CityCountry.Countries.ToList<Country>();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string key = "35191f5f03089db2dc2d68f960ec6bcb";
            string call = $"https://api.openweathermap.org/data/2.5/weather?q=Wroclaw&appid={key}";
            string response = await client.GetStringAsync(call);
            WeatherAPI weather = JsonSerializer.Deserialize<WeatherAPI>(response);
            listBox1.Items.Add(weather.ToString());
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            // pobranie danych z API na podstawie danych wpisanych do textboxa
            string city = cityTextBox.Text;

            // if there is no city written in textbox in database:
            if (CityCountry.Cities.Find(city) == null)
            {
                string key = "35191f5f03089db2dc2d68f960ec6bcb";
                string call = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
                string response = await client.GetStringAsync(call);
                WeatherAPI weather = JsonSerializer.Deserialize<WeatherAPI>(response);

                City city1 = new City()
                {
                    name = weather.name,
                    temperature = weather.main.temp,
                    CountryId = weather.sys.country,
                    weather = weather.weather[0].description

                };

                CityCountry.Add(city1);

                // Adding new country only if it wasn't added previously.
                if (CityCountry.Countries.Find(weather.sys.country) == null)
                {
                    Country country1 = new Country()
                    {
                        country = weather.sys.country,
                        timezone = weather.timezone / 3600
                    };
                    CityCountry.Add(country1 );
                    listBoxCountry.Items.Add(country1);

                }
                CityCountry.SaveChanges();

                listBoxCity.Items.Add(city1);

            }
            else
            {
                MessageBox.Show($"City: {city} already exists in a database. Check it out!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxCountry.DataSource = CityCountry.Countries.OrderBy(c => c.timezone).ToList<Country>();
            listBoxCity.DataSource = CityCountry.Cities.OrderBy(c => c.Country.timezone).ToList<City>();

        }
    }
}
