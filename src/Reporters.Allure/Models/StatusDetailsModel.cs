using System.Runtime.Serialization;

namespace Rhino.Reporters.Allure.Models
{
    /// <summary>
    /// Represents a status details model used in Allure Reports.
    /// </summary>
    [DataContract]
    internal class StatusDetailsModel
    {
        /// <summary>
        /// Gets or sets a flag indicating whether the status is known.
        /// </summary>
        [DataMember]
        public bool Known { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether the status is muted.
        /// </summary>
        [DataMember]
        public bool Muted { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether the status is flaky.
        /// </summary>
        [DataMember]
        public bool Flaky { get; set; }

        /// <summary>
        /// Gets or sets a message associated with the status.
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a trace or stack trace associated with the status.
        /// </summary>
        [DataMember]
        public string Trace { get; set; }
    }
}
