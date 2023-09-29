using System;
using System.Collections.Generic;
using System.Text;
using iothink.interco.lib.Models.Incwo;
using Newtonsoft.Json;


namespace iothink.interco.services.Utils
{
    internal class FormatConverter
    {
        public static WebhookData JsonToWebhookData(string jsonData)
        {
            WebhookData data = JsonConvert.DeserializeObject<WebhookData>(jsonData);
            return data;
        }
    }
}
