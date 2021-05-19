using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoAdapterApp.Domain;

namespace VideoAdapterApp.View
{
    public interface IView
    {
        IEnumerable<VideoCard> katalog { set; }
        VideoCard ShowSpecification { set; }
        VideoCard SelectedVideoCard { get; set; }
        VideoCard TakeFromGrid { get; }

        event EventHandler SelectedVideoCardChanged;
        event EventHandler DeleteVideoCard;
        event EventHandler AddVideoCard;
        event EventHandler ClearGridButton;

        event EventHandler ShowMainL;
        event EventHandler ShowCompareList;
        event EventHandler DeleteFromCompareList;

        event EventHandler DropCompareListInFile;

        event EventHandler AddToCompareList;

        void ClearGrid();

        /*event EventHandler AddVideoCardCompare;

        event EventHandler AddVideoCard;*/
        void Show();
        void Close();
    }
}
