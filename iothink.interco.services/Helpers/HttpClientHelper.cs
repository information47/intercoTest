using iothink.interco.lib.Models.Incwo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iothink.interco.services.Helpers
{
    public static class HttpClientHelper
    {
        private static string incwoUsername = Environment.GetEnvironmentVariable("IncwoUsername");
        private static string incwoPassword = Environment.GetEnvironmentVariable("IncwoPassword");
        #region Get Helpers

        public static async Task<HttpResponseMessage> ProcessGetQueryAsync(string url)
        {
            // Inits
            var httpClient = new HttpClient();

            // Http call to Incwo API
            var response = await httpClient.GetAsync(url);

            // Check status code of responce
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                throw new Exception("");
            }
        }

        public static async Task<HttpResponseMessage> GetIncwoDataAsync(string url)
        {
            // Créez une instance HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                // Créez une chaîne "login:password"
                string authString = $"{incwoUsername}:{incwoPassword}";
                // Encodez la chaîne en base64
                string base64Auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(authString));

                // Ajoutez les en-têtes de la requête
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + base64Auth);
                httpClient.DefaultRequestHeaders.Add("Accept", "application/xml"); // Spécifiez le type de contenu accepté

                try
                {
                    // Envoyez la requête GET à l'API Incwo
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Vérifiez si la requête a réussi (code 2xx)
                    if (response.IsSuccessStatusCode)
                    {
                        // Lisez la réponse en tant que chaîne XML
                        string xmlData = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Réponse XML de l'API Incwo :");
                        Console.WriteLine(xmlData);
                        return response;
                    }
                    else
                    {
                        Console.WriteLine($"Échec de la requête : {response.StatusCode} {response.ReasonPhrase}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur s'est produite : " + ex.Message);
                    return null;
                }
            }
        }

        #endregion
    }
}
