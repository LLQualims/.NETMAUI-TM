using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;
using TrackMobile.Models;

namespace TrackMobile;
public partial class APPAPVIS : ContentPage
{
    private readonly HttpClient _httpClient;

    public APPAPVIS()
    {
        InitializeComponent();
        _httpClient = new HttpClient();
    }

    private async void RecupereAppareilVis(object sender, EventArgs e)
    {
        string URL = "http://192.168.39.68:7293/8.1b/app/appareil/vis";

        try
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiJ9.eyJJZCI6ImI2NGQ5N2RkLTE4YTAtNDJkMi1hZTNkLWViM2Q5ZDRlYTQ5MCIsInN1YklkIjoiNzYiLCJzdWIiOiJLUCIsImp0aSI6IjFkZGEyODRmLTZjZTQtNGRlMC04NDEzLTk1NGI2YWI2YWM0MCIsIlByb2ZpbEVRTSI6IjYiLCJQcm9maWxMQUIiOiIxMCIsIm5iZiI6MTcxOTQ5ODE1OSwiZXhwIjoyMDE5NTAxNzU5LCJpYXQiOjE3MTk0OTgxNTksImlzcyI6IklOT0tZIiwiYXVkIjoiUVVBTElNUyJ9.TaF3QoT2AooxmPD6l_vXWFCnKDguU0pGiaGymo4_6mg");

            HttpResponseMessage response = await _httpClient.GetAsync(URL);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            using (JsonDocument doc = JsonDocument.Parse(content))
            {
                JsonElement root = doc.RootElement;
                JsonElement contenuElement = root.GetProperty("contenu");
                Debug.WriteLine(contenuElement);
                var appareils = new List<APPAppareil>();

                foreach (JsonElement element in contenuElement.EnumerateArray())
                {
                    var appareil = new APPAppareil
                    {
                        NumeroAppareil = element.GetProperty("numeroAppareil").GetString(),
                        DesignationAppareil = element.GetProperty("designationAppareil").GetString()
                    };
                    appareils.Add(appareil);
                }
                listAppareil.ItemsSource = appareils;
            }

        }
        catch (Exception ex)
        {
            ResultLabel.Text = $"Erreur: {ex.Message}";
        }
    }
}