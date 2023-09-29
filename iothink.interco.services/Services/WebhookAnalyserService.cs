using iothink.interco.lib.Models.Incwo;
using iothink.interco.services.Helpers;
using iothink.interco.services.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iothink.interco.services.Services
{
    public class WebhookAnalyserService
    {
        public async Task<IincwoObject> WebhookAnalyse<T>(string data) where T : IincwoObject
        {
            WebhookData webhookData = FormatConverter.JsonToWebhookData(data);
            IincwoObject incwoObject = await IncwoService.GetElementByIdAsync<IincwoObject>(webhookData.zid, webhookData.zname);
            return incwoObject;
        }
    }
}
