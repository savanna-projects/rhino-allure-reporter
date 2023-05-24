using System.Runtime.Serialization;

namespace Reporters.Allure.Models
{
    [DataContract]
    internal class LabelModel
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}
