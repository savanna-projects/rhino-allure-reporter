using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reporters.Allure.Models
{
    [DataContract]
    internal class StatusDetailsModel
    {
        [DataMember]
        public bool Known { get; set; }

        [DataMember]
        public bool Muted { get; set; }

        [DataMember]
        public bool Flaky { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Trace { get; set; }
    }
}
