using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    public class Lead : IincwoObject
    {
        /// <summary>
        /// Get or Set the ID of the lead
        /// </summary>
        [XmlElement("id")]
        public int id { get; set; }

        /// <summary>
        /// Get or Set the manager ID of the lead
        /// </summary>
        [XmlElement("manager_id")]
        public int managerId { get; set; }

        /// <summary>
        /// Get or Set the client name of the lead
        /// </summary>
        [XmlElement("client_name")]
        public int clientName { get; set; }

        /// <summary>
        /// Get or Set the topic of the lead
        /// </summary>
        [XmlElement("topic")]
        public int topic { get; set; }

        /// <summary>
        /// Get or Set the firm ID of the lead
        /// </summary>
        [XmlElement("firm_id")]
        public int firmId { get; set; }

        /// <summary>
        /// Get or Set the amount of sale without taxes for the lead
        /// </summary>
        [XmlElement("value")]
        public int amount { get; set; }

        /// <summary>
        /// Get or Set the expecting date of signing the sale
        /// </summary>
        [XmlElement("value_date")]
        public int signingDate { get; set; }

        /// <summary>
        /// Get or Set the confidence percentage of the lead
        /// </summary>
        [XmlElement("confidence_pct")]
        public int confidencePct { get; set; }

        /// <summary>
        /// Get or Set the project ID of the lead
        /// </summary>
        [XmlElement("project_id")]
        public int projectId { get; set; }

    }
}
