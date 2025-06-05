using System.Net.Http.Json;

namespace CarlosMoretaProgreso2;

public partial class Chistes : ContentPage
{
    public Chistes()
    {
        InitializeComponent();
        _ = CargarChisteAsync();
    }

    private async void OtroChisteButton_Clicked(object sender, EventArgs e)
    {
        await CargarChisteAsync();
    }

    private async Task CargarChisteAsync()
    {
        try
        {
            using var http = new HttpClient();
            var url = "https://official-joke-api.appspot.com/random_joke";
            var chiste = await http.GetFromJsonAsync<Joke>(url);

            if (chiste != null)
                ChisteLabel.Text = $"{chiste.setup}\n\n{chiste.punchline}";
            else
                ChisteLabel.Text = "No se pudo cargar el chiste.";
        }
        catch
        {
            ChisteLabel.Text = "Error al cargar el chiste.";
        }
    }

    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}
