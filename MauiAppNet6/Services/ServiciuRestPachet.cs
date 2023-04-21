using MainAppNet6;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MuaiAppNet6.Services
{
    public class ServiciuRestPachet: MauiAppNet6.Services.PacheteRepository
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public ObservableCollection<Pachet> pachete { get; set; }

        private static string BASE_URL { get; set; } = "https://api.json-generator.com/templates/QfWaI-tw83yO/data?access_token=wg3941mqbnsw25mf6mlj4w9oz57ax2qu7029vumv";

        public ServiciuRestPachet() {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<ObservableCollection<Pachet>> LoadPachet()
        {
            pachete = new ObservableCollection<Pachet>();

            Uri uri = new Uri(BASE_URL);
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    content = content.Insert(0, "{\"pachete\":");
                    content = content.Insert(content.Length, "}");
                    Pachete temp = JsonSerializer.Deserialize<Pachete>(content, serializerOptions);
                    pachete = temp.pachete;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return pachete;
        }
    }
}
