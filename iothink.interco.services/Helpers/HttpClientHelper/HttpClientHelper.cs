using iothink.interco.lib.Models.Incwo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace iothink.interco.services.Helpers.HttpClientHelper
{
    public static class HttpClientHelper
    {
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
            } else
            {
                throw new Exception("");
            }
        }

        #endregion
    }
}
