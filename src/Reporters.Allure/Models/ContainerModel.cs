using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Reporters.Allure.Models
{
    [DataContract]
    internal class ContainerModel
    {
        [DataMember]
        public string Uuid { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public IEnumerable<string> Children { get; set; }

        // TODO: change `object` to the actual contract based on the report schema
        [DataMember]
        public IEnumerable<object> Befores { get; set; }

        // TODO: change `object` to the actual contract based on the report schema
        [DataMember]
        public IEnumerable<object> Afters { get; set; }

        [DataMember]
        public long Start { get; set; }

        [DataMember]
        public long Stop { get; set; }
    }
}
