using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    public class Firm : IincwoObject
    {
        /// <summary>
        /// Get or Set the ID of the firm
        /// </summary>
        [XmlElement("id")]
        public int id { get; set; }

        /// <summary>
        /// Get or Set the name of the firm
        /// </summary>
        [XmlElement("name")]
        public string name { get; set; }

        /// <summary>
        /// Get or Set the project ID of the firm
        /// </summary>
        [XmlElement("project_id")]
        public int projectId { get; set; }

        /// <summary>
        /// Get or Set the model firm ID
        /// </summary>
        [XmlElement("model_firm_id")]
        public int modelFirmId { get; set; }

        /// <summary>
        /// Get or Set the custom label id of the firm
        /// </summary>
        [XmlElement("custom_label_id")]
        public int customLabelId { get; set; }

        /// <summary>
        /// Get or Set the parent firm ID
        /// </summary>
        [XmlElement("parent_firm_id")]
        public int parentFirmId { get; set; }

        /// <summary>
        /// Get or Set the can be parent flag (0 or 1)
        /// </summary>
        [XmlElement("can_be_parent")]
        public int canBeParent { get; set; }

        /// <summary>
        /// Get or Set the firm type
        /// </summary>
        [XmlElement("firm_type")]
        public string firmType { get; set; }

        /// <summary>
        /// Get or Set the firm type 2
        /// </summary>
        [XmlElement("firm_type2")]
        public string firmType2 { get; set; }

        /// <summary>
        /// Get or Set the SIREN (Company number)
        /// </summary>
        [XmlElement("siren")]
        public string siren { get; set; }

        /// <summary>
        /// Get or Set the bank account id 
        /// </summary>
        [XmlElement("bank_account_id")]
        public string bankAccountId { get; set; }
    }
}
