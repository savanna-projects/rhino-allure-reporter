using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Rhino.Reporters.Allure.Models
{
    /// <summary>
    /// Represents a result model used in Allure Reports.
    /// </summary>
    [DataContract]
    internal class ResultModel
    {
        /// <summary>
        /// Gets or sets the UUID (Universally Unique Identifier) of the result.
        /// </summary>
        [DataMember]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or sets the history ID associated with the result.
        /// </summary>
        [DataMember]
        public string HistoryId { get; set; }

        /// <summary>
        /// Gets or sets the full name of the result.
        /// </summary>
        [DataMember]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the collection of labels associated with the result.
        /// </summary>
        [DataMember]
        public IEnumerable<LabelModel> Labels { get; set; }

        // TODO: Change 'object' to the actual contract based on the report schema.
        /// <summary>
        /// Gets or sets a collection of links related to the result.
        /// </summary>
        [DataMember]
        public IEnumerable<object> Links { get; set; }

        /// <summary>
        /// Gets or sets the name of the result.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the status of the result.
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status details of the result.
        /// </summary>
        [DataMember]
        public StatusDetailsModel StatusDetails { get; set; }
    }
}
