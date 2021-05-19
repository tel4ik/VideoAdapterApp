using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VideoAdapterApp.Domain
{
    public class VideoCard
    {
        [XmlElement("name")]
        public string name { get; set; }

        [XmlElement("Core")]
        public string Core { get; set; }

        [XmlElement("technicalProcess")]
        public string technicalProcess { get; set; }

        [XmlElement("transistor")]
        public string transistor { get; set; }

        [XmlElement("frequency")]
        public string frequency { get; set; }

        [XmlElement("frequencyShaders")]
        public string frequencyShaders { get; set; }

        [XmlElement("ShadersBlocks")]
        public string ShadersBlocks { get; set; }

        [XmlElement("TMU")]
        public string TMU { get; set; }

        [XmlElement("ROP")]
        public string ROP { get; set; }

        [XmlElement("frequencyMem")]
        public string frequencyMem { get; set; }

        [XmlElement("busMem")]
        public string busMem { get; set; }

        [XmlElement("TypeMem")]
        public string TypeMem { get; set; }

        [XmlElement("ValueMem")]
        public string ValueMem { get; set; }

        [XmlElement("PSP")]
        public string PSP { get; set; }

        [XmlElement("ShadersModel")]
        public string ShadersModel { get; set; }

        [XmlElement("FRMpix")]
        public string FRMpix { get; set; }

        [XmlElement("FRMtex")]
        public string FRMtex { get; set; }

        [XmlElement("DirectX")]
        public string DirectX { get; set; }

        [XmlElement("interface")]
        public string Interface { get; set; }

        [XmlElement("energy")]
        public string energy { get; set; }

        [XmlElement("date")]
        public string date { get; set; }

        [XmlElement("price")]
        public string price { get; set; }

        [XmlElement("url")]
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
