using System.Runtime.Serialization;

namespace Rhino.Reporters.Allure.Models
{
    /// <summary>
    /// Represents a label model used in Allure Reports.
    /// </summary>
    [DataContract]
    internal class LabelModel
    {
        /// <summary>
        /// Gets or sets the key of the label.
        /// </summary>
        [DataMember]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value associated with the label.
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }
}
