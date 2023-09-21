using iothink.interco.lib.Enums.Incwo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    public class Project
    {
        /// <summary>
        /// Get or Set the identifier of the project
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// Get or Set the Name of the project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or Set the Reference of the project
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Get or Set the Status identifier of the project
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Get or Set the Date of creation of the project
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Get or Set the Date of update of the project
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Get or Set the Creator identifier
        /// </summary>
        [XmlElement("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// Get or Set the model of contributor as enum
        /// </summary>
        public EContributorModel ContributorModel { get; set; }
    }
}
