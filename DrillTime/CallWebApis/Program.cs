using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DrillTime.DomainClasses;

namespace HttpClientSample 
{
   

    class Program
    {
        static HttpClient client = new HttpClient();

        static void ShowDrill(Drill drill)
        {
            Console.WriteLine($"Name: {drill.Name}\tPrice: {drill.Procedure}\tCategory: {drill.StartPosition}");
        }

        static async Task<Uri> CreateDrillAsync(Drill drill)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/drills", drill);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Drill> GetDrillAsync(string path)
        {
            Drill drill = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                drill = await response.Content.ReadAsAsync<Drill>();
            }
            return drill;
        }

        static async Task<Drill> UpdateDrillAsync(Drill drill)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/drills/{drill.Id}", drill);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated drill from the response body.
            drill = await response.Content.ReadAsAsync<Drill>();
            return drill;
        }

        static async Task<HttpStatusCode> DeleteDrillAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/drills/{id}");
            return response.StatusCode;
        }

        static void Main()
        {
            Console.WriteLine("Wait for webapi to spool up");
            Console.ReadLine();
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://192.168.1.163:12442/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new drill
                Drill drill = new Drill { Name = "Gizmo", SuggestedReps = 100, Procedure = "Widgets" };

                var url = await CreateDrillAsync(drill);
                Console.WriteLine($"Created at {url}");

                // Get the drill
                drill = await GetDrillAsync(url.PathAndQuery);
                ShowDrill(drill);

                // Update the drill
                Console.WriteLine("Updating price...");
                drill.SuggestedReps = 80;
                await UpdateDrillAsync(drill);

                // Get the updated drill
                drill = await GetDrillAsync(url.PathAndQuery);
                ShowDrill(drill);

                // Delete the drill
                var statusCode = await DeleteDrillAsync(drill.Id.ToString());
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

    }
}
