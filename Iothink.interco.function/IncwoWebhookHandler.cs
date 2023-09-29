using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using iothink.interco.services.Services;
using iothink.interco.lib.Models.Incwo;

namespace Iothink.interco.function
{
    public static class IncwoWebhookHandler
    {
        [FunctionName("IncwoWebhookHandler")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = "";
            try
            {
                // read the body of the request
                requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                
                // log the body of the request
                log.LogInformation($"Body data : {requestBody}");

                // define and send response
                string responseMessage = "element received";
               
                WebhookAnalyserService analyser = new WebhookAnalyserService();
                IincwoObject test = await analyser.WebhookAnalyse<IincwoObject>(requestBody);
                log.LogInformation($" --- IincwoObject retrieved --- : {test} ");
                
                return new OkObjectResult(responseMessage);
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                return new BadRequestObjectResult($"an error occured : {ex.Message}");
            }
          
        }
    }
}
