using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdapterApp.Domain;

namespace VideoAdapterApp.DAL
{
    public interface IVideoKatalog
    {
        Katalog GetKatalog();
    }
}
