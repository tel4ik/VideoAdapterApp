using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoAdapterApp.Domain
{
    [XmlRoot("katalog")]
    public class Katalog
    {
        [XmlElement("VideoAdapter")]
        public List<VideoCard> VideoCards { get; set; }
    }
}
