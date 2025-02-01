namespace MyWinFormsApp;

using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        string city = textBox1.Text; // User input
        string apiKey = ""; // Replace with your OpenWeatherMap API key
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        using HttpClient client = new HttpClient();

        try
        {
            var weatherData = await client.GetFromJsonAsync<WeatherResponse>(url);
            if (weatherData != null)
            {
                labelTemperature.Text = $"Temperature: {weatherData.Main.Temp}°C";
                labelCondition.Text = $"Condition: {weatherData.Weather[0].Description}";
            }
            else
            {
                MessageBox.Show("No weather data found. Please check the city name.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error fetching weather data: {ex.Message}");
        }
    }
}

// Data models for the JSON response
public class WeatherResponse
{
    public Main Main { get; set; }
    public Weather[] Weather { get; set; }
}

public class Main
{
    public double Temp { get; set; }
}

public class Weather
{
    public string Description { get; set; }
}



