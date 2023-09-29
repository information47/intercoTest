using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace iothink.interco.lib.Models.Incwo
{
    public class WebhookData
    {
        /// <summary>
        /// get or set the action done on the incwo object
        /// </summary>
        [JsonProperty("object_action")]
        public string Action { get; set; }

        /// <summary>
        /// get or set the modified objects of the incwo object
        /// </summary>
        [JsonProperty("object_changes")]
        public object objectChanges { get; set; }

        /// <summary>
        /// get or set the buisness file id of the incwo object
        /// </summary>

        [JsonProperty("buisness_file_id")]
        public int buisnessFileId { get; set; }

        /// <summary>
        /// get or set the zid of the incwo object
        /// </summary>
        [JsonProperty("object_zid")]
        public int zid { get; set; }

        /// <summary>
        /// get or set the zname of the incwo object
        /// </summary>
        [JsonProperty("object_zname")]
        public string zname { get; set; }

        /// <summary>
        /// get or set the data of the incwo object
        /// </summary>
        [JsonProperty("object_data")]
        public object data { get; set; }

        /// <summary>
        /// get or set the user id of the incwo object
        /// </summary>
        [JsonProperty("user_id")]
        public int userId { get; set; }

    }
}
