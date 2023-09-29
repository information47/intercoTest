using iothink.interco.lib.Enums.Incwo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    public class Project : IincwoObject
    {
        /// <summary>
        /// Get or Set the identifier of the project
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// Get or Set the Name of the project
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Get or Set the Reference of the project
        /// </summary>
        [XmlElement("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Get or Set the Status identifier of the project
        /// </summary>
        [XmlElement("status_id")]
        public int StatusId { get; set; }

        /// <summary>
        /// Get or Set the Date of creation of the project
        /// </summary>
        [XmlElement("created_at")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Get or Set the Date of update of the project
        /// </summary>
        [XmlElement("updated_at")]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Get or Set the Creator identifier
        /// </summary>
        [XmlElement("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// Get or Set the model of contributor as enum
        /// </summary>
        [XmlElement("contribution_model")]
        public EContributorModel ContributorModel { get; set; }
    }
}
