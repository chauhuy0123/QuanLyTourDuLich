using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    interface ITransportPresenter
    {
        void loadAllTransports();
        
        // load transport has tourgroup
        void loadAllActiveTransports();
    }
}
