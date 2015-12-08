using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Serialization;

namespace NetworkSwitch
{

    [Serializable]
    public class Profile
    {
        [XmlIgnore]
        public IPNetwork Network { get; set; }

        [XmlElement("Network")]
        public string ipNetwork { get { return Network.ToString(); } set { Network = IPNetwork.Parse(value); } }

        [XmlIgnore]
        public IPAddress Address { get; set; }

        [XmlElement("Address")]
        public string address { get { return Address.ToString(); } set { Address = IPAddress.Parse(value); } }

        [XmlIgnore]
        public IPAddress GateWay { get; set; }

        [XmlElement("GateWay")]
        public string gateWay { get { return GateWay.ToString(); } set { GateWay = IPAddress.Parse(value); } }

        public string Name { get; set; }

        override public string ToString()
        {
            return Name;
        }
    }
}
