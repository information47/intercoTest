using iothink.interco.lib.Models.Incwo;
using iothink.interco.services.Helpers.HttpClientHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iothink.interco.services.Services
{
    public class IncwoService
    {
        #region Get Methods

        /// <summary>
        /// Service method to get Project by identifier
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<Project> GetProjectByIdentifierAsync(int projectId)
        {
            // Inits
            var xml = "";
            var result = new Project();

            // Process get query using helper
            var response = await HttpClientHelper.ProcessGetQueryAsync("");

             // Get xml result if status code is 200
             xml = await response.Content.ReadAsStringAsync();
            

            // Init XML serialize with targeted model
            XmlSerializer serializer = new XmlSerializer(typeof(Project));

            // Read response to parse XML to C# object
            using (var reader = new StringReader(xml))
            {
                result = (Project)serializer.Deserialize(reader);
            }

            return result;
        }

        #endregion
    }
}
