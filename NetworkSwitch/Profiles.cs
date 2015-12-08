using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NetworkSwitch
{

    [Serializable]
    public class Profiles
    {
        public static string filename = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "NetworkSwitching.xml");
        public List<Profile> Items { get; set; }

        public static Profiles Unserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Profiles));
            using (StreamReader rd = new StreamReader(filename))
            {
                return xs.Deserialize(rd) as Profiles;
            }
        }

        public void Serialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Profiles));
            using (StreamWriter wr = new StreamWriter(filename))
            {
                xs.Serialize(wr, this);
            }
        }

        public Profiles()
        {
            Items = new List<Profile>();
        }

    }
}
