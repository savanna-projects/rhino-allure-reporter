using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Reporters.Allure.Models
{
    [DataContract]
    internal class ResultModel
    {
        [DataMember]
        public string Uuid { get; set; }

        [DataMember]
        public string HistoryId { get; set; }

        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public IEnumerable<LabelModel> Labels { get; set; }

        // TODO: change `object` to the actual contract based on the report schema
        [DataMember]
        public IEnumerable<object> Links { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public StatusDetailsModel StatusDetails { get; set; }
    }
}
