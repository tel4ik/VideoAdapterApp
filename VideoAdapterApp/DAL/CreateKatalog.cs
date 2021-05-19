using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using VideoAdapterApp.Domain;

namespace VideoAdapterApp.DAL
{
    public class CreateKatalog : IVideoKatalog
    {
        public Katalog GetKatalog()
        {
            const string path = @"C:\Users\tawer\OneDrive\Рабочий стол\C#_project\VideoAdapter\VideoAdapterApp\VideoAdapterApp\Content\infoVidAdapt.xml";
            if (!File.Exists(path)) return null;

            var xml = XDocument.Load(path);

            using (var stream = xml.CreateReader())
            {
                var ser = new XmlSerializer(typeof(Katalog));
                return (Katalog)ser.Deserialize(stream);
            }
        }
    }
}
