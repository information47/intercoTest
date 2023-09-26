using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace iothink.interco.lib.Models.Incwo
{
    public class Proposal
    {
        /// <summary>
        /// Get or Set the id of the proposal
        /// </summary>
        [XmlElement("id")]
        public int id { get; set; }

        /// <summary>
        /// Get or Set the progress id of the proposal
        /// </summary>
        [XmlElement("progress_id")]
        public int progressId { get; set; }

        /// <summary>
        /// Get or Set the project id of the proposal
        /// </summary>
        [XmlElement("project_id")]
        public int projectId { get; set; }

        /// <summary>
        /// Get or Set the reference of the proposal
        /// </summary>
        [XmlElement("reference")]
        public string reference { get; set; }

        /// <summary>
        /// Get or Set the creator id of the proposal
        /// </summary>
        [XmlElement("creator_id")]
        public int creatorId { get; set; }

        /// <summary>
        /// Get or Set the creation date of the proposal
        /// </summary>
        [XmlElement("created_at")]
        public DateTime creationDate { get; set; }

        /// <summary>
        /// Get or Set the contact id of the proposal
        /// </summary>
        [XmlElement("contact_id")]
        public int contactId { get; set; }

        /// <summary>
        /// Get or Set the firm id of the proposal
        /// </summary>
        [XmlElement("firm_id")]
        public int firmId { get; set; }

        /// <summary>
        /// Get or Set the sheet_type of the proposal
        /// </summary>
        [XmlElement("sheet_type")]
        public string sheetType { get; set; }

        /// <summary>
        /// Get or Set the title of the proposal
        /// </summary>
        [XmlElement("title")]
        public string title { get; set; }

        /// <summary>
        /// Get or Set the billing date of the proposal
        /// </summary>
        [XmlElement("billing_date")]
        public DateTime billingDate { get; set; }

        /// <summary>
        /// Get or Set the VAT cost of the proposal
        /// </summary>
        [XmlElement("vat_cost")]
        public double vatCost { get; set; }

        /// <summary>
        /// Get or Set the shipping cost of the proposal
        /// </summary>
        [XmlElement("shipping_cost")]
        public double shippingCost { get; set; }

        /// <summary>
        /// Get or Set the language of the proposal
        /// </summary>
        [XmlElement("language")]
        public string language { get; set; }

        /// <summary>
        /// Get or Set the bank account id of the proposal
        /// </summary>
        [XmlElement("bank_account_id")]
        public int bankAccountId { get; set; }

        /// <summary>
        /// Get or Set the lead id of the proposal
        /// </summary>
        [XmlElement("lead_id")]
        public int leadId { get; set; }

        /// <summary>
        /// Get or Set the reduction percentage of the proposal
        /// </summary>
        [XmlElement("reduction_percent")]
        public double reductionPercent { get; set; }

        /// <summary>
        /// Get or Set the reduction currency of the proposal
        /// </summary>
        [XmlElement("reduction_currency")]
        public double reductionCurrency { get; set; }

        /// <summary>
        /// Get or Set the comment of the proposal
        /// </summary>
        [XmlElement("comment")]
        public double comment { get; set; }

    }
}
