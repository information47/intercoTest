using iothink.interco.lib.Models.Incwo;
using iothink.interco.services.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using iothink.interco.services.Utils;

namespace iothink.interco.services.Services
{
    public class IncwoService
    {
        private static string incwoUrl = Environment.GetEnvironmentVariable("IncwoUrl");
        private static string incwoToken = Environment.GetEnvironmentVariable("IncwoPersonalToken");
        #region Get Methods

        /// <summary>
        /// Service method to get Project by identifier
        /// </summary>
        /// <param name="incwoObjectId"></param>
        /// <returns></returns>
        public static async Task<IincwoObject> GetElementByIdAsync<T>(int incwoObjectId, string zName)
        {
            // Inits
            string url = incwoUrl + zName + "/show/" + incwoToken + "/" + incwoObjectId + ".xml";
            var xml = "";
            IincwoObject result;

            // Process get query using helper
            var response = await HttpClientHelper.GetIncwoDataAsync(url);

            // Get xml result if status code is 200
            xml = await response.Content.ReadAsStringAsync();
            
            IncwoObjectFactory factory = new IncwoObjectFactory();
            IincwoObject obj = factory.CreateObject<IincwoObject>(zName);

            // Init XML serializer
            XmlSerializer serializer = new XmlSerializer(obj.GetType());

            // Read response to parse XML to C# object
            using (var reader = new StringReader(xml))
            {
                result = (IincwoObject)serializer.Deserialize(reader);
            }
            
            return result;
        }

        #endregion
    }
}
