using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    [XmlRoot("contact")]
    public class Contact : IincwoObject
    {
        /// <summary>
        /// Get or Set the id of the contact
        /// </summary>
        [XmlElement("id")]
        public int id { get; set; }

        /// <summary>
        /// Get or Set the civility label id of the contact
        /// </summary>
        [XmlElement("civility_label_id")]
        public int civilityLabelId { get; set; }

        /// <summary>
        /// Get or Set the last name of the contact
        /// </summary>
        [XmlElement("last_name")]
        public string lastName { get; set; }

        /// <summary>
        /// Get or Set the first name of the contact
        /// </summary>
        [XmlElement("first_name")]
        public string firstName { get; set; }

        /// <summary>
        /// Get or Set the country of the contact
        /// </summary>
        [XmlElement("country")]
        public string country { get; set; }

        /// <summary>
        /// Get or Set the project id of the contact
        /// </summary>
        [XmlElement("project_id")]
        public int projectId { get; set; }

        /// <summary>
        /// Get or Set the reference of the contact
        /// </summary>
        [XmlElement("reference")]
        public string reference { get; set; }

        /// <summary>
        /// Get or Set the creator id of the contact
        /// </summary>
        [XmlElement("creator_id")]
        public int creatorId { get; set; }

        /// <summary>
        /// Get or Set the creation date of the contact
        /// </summary>

        [XmlIgnore]
        public DateTime creationDate { get; set; }

        [XmlElement("created_at")]
        public string creationDateString
        {
            get { return creationDate.ToString("dd-MM-yyyy-HH-mm"); }
            set
            {
                // Parse date from string, in specific format
                if (DateTime.TryParseExact(value, "dd-MM-yyyy-HH-mm", null, System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    creationDate = result;
                }
                else
                {
                    // Si la désérialisation échoue, vous pouvez jeter une exception
                    throw new FormatException("incorrect date format in XML.");
                }
            }
        }

        /// <summary>
        /// Get or Set the firm id of the contact
        /// </summary>
        [XmlElement("firm_id")]
        public int firmId { get; set; }

        /// <summary>
        /// Get or Set the contact type of the contact
        /// </summary>
        [XmlElement("contact_type")]
        public string contactType { get; set; }

        /// <summary>
        /// Get or Set the language of the contact
        /// </summary>
        [XmlElement("language")]
        public string language { get; set; }

        /// <summary>
        /// Get or Set the bank account id of the contact
        /// </summary>
        [XmlElement("bank_account_id")]
        public int bankAccountId { get; set; }

        


    }
}
