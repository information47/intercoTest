using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    [XmlRoot("lead")]
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
        /// Get or Set the topic of the lead
        /// </summary>
        [XmlElement("topic")]
        public string topic { get; set; }

        /// <summary>
        /// Get or Set the firm ID of the lead
        /// </summary>
        [XmlElement("firm_id")]
        public int firmId { get; set; }

        /// <summary>
        /// Get or Set the amount of sale without taxes for the lead
        /// </summary>
        [XmlElement("value")]
        public double amount { get; set; }

        /// <summary>
        /// Get or Set the expecting date of signing the sale
        /// parse correctly the date by the way
        /// </summary>
        [XmlIgnore]
        public DateTime signingDate { get; set; }

        [XmlElement("value_date")]
        public string SigningDateString
        {
            get { return signingDate.ToString("dd-MM-yyyy"); }
            set { signingDate = DateTime.ParseExact(value, "dd-MM-yyyy", CultureInfo.InvariantCulture); }
        }

        /// <summary>
        /// Get or Set the confidence percentage of the lead
        /// </summary>
        [XmlElement("confidence_pct")]
        public int confidencePct { get; set; }

    }
}
