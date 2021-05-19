using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdapterApp.View;


namespace VideoAdapterApp.Presentor
{
    public interface IPresentor
    {
        IView View { get; }
    }
}
