using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Rhino.Reporters.Allure.Models
{
    /// <summary>
    /// Represents a container model used in Allure Reports.
    /// </summary>
    [DataContract]
    internal class ContainerModel
    {
        /// <summary>
        /// Gets or sets the UUID (Universally Unique Identifier) of the container.
        /// </summary>
        [DataMember]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or sets the name of the container.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the collection of child elements associated with the container.
        /// </summary>
        [DataMember]
        public IEnumerable<string> Children { get; set; }

        // TODO: Change 'object' to the actual contract based on the report schema.
        /// <summary>
        /// Gets or sets a collection of 'before' elements in the container.
        /// </summary>
        [DataMember]
        public IEnumerable<object> Befores { get; set; }

        // TODO: Change 'object' to the actual contract based on the report schema.
        /// <summary>
        /// Gets or sets a collection of 'after' elements in the container.
        /// </summary>
        [DataMember]
        public IEnumerable<object> Afters { get; set; }

        /// <summary>
        /// Gets or sets the start timestamp of the container.
        /// </summary>
        [DataMember]
        public long Start { get; set; }

        /// <summary>
        /// Gets or sets the stop timestamp of the container.
        /// </summary>
        [DataMember]
        public long Stop { get; set; }
    }
}
