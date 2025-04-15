using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using database_app;
using Microsoft.EntityFrameworkCore;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private HttpClient client;
        public CityCountryDBContext CityCountry;
        public ObservableCollection<City> Cities { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();
            client = new HttpClient();
            CityCountry = new CityCountryDBContext();
            var citiesFromDb = CityCountry.Cities.ToList();
            foreach (var c in citiesFromDb)
            {
                Cities.Add(c);
            }

            BindingContext = this;
        }


        private async void AddCityClicked(object sender, EventArgs e)
        {


            string city = EntryCity.Text;
            if (CityCountry.Cities.Find(city) == null)
            {
                string key = "35191f5f03089db2dc2d68f960ec6bcb";
                string call = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}";
                string response = await client.GetStringAsync(call);
                WeatherAPI weather = JsonSerializer.Deserialize<WeatherAPI>(response);

                City c = new City()
                {
                    name = weather.name,
                    temperature = weather.main.temp,
                    CountryId = weather.sys.country,
                    weather = weather.weather[0].description

                };
                CityCountry.Cities.Add(c);
                Cities.Add(c);

                // Adding new country only if it wasn't added previously.
                if (CityCountry.Countries.Find(weather.sys.country) == null)
                {
                    CityCountry.Add(new Country()
                    {
                        country = weather.sys.country,
                        timezone = weather.timezone / 3600
                    });
                }
                CityCountry.SaveChanges();
                BindingContext = this;
                
            }
            else
            {
                await DisplayAlert("Ostrzeżenie", "To miasto już istnieje w bazie", "OK");
                return;
            }
        }

        private async void AddManuallyClicked(object sender, EventArgs e) {


            string city = EntryCityManual.Text;
            if (CityCountry.Cities.Find(city) != null)
            {
                await DisplayAlert("Ostrzeżenie", "To miasto już istnieje w bazie", "OK");
                return;

            }
            if (EntryTemperature.Text == null || Entrycountry.Text == null || EntryWeather.Text == null || EntryTimezone == null)
            {
                await DisplayAlert("Ostrzeżenie", "Proszę wypełnić wszystkie pola ", "OK");
                return;

            }

            int temperature = int.Parse(EntryTemperature.Text);
            string country = Entrycountry.Text;
            string weather = EntryWeather.Text;
            int timezone = int.Parse(EntryTimezone.Text);



            City ci = new City()
            {
                name = city,
                temperature = temperature,
                CountryId = country,
                weather = weather,

            };
            CityCountry.Cities.Add(ci);

            Country co = new Country()
            {
                country = country,
                timezone = timezone,
            };
            CityCountry.Countries.Add(co);

            CityCountry.SaveChanges();

            Cities.Add(ci);
            BindingContext = this;
        }
    }

}
