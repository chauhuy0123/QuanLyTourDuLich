using BusinessEntity;
using DTO;
using QuanLyTourDuLich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTourDuLich.Presenters
{
    class TransportPresenter : ITransportPresenter
    {
        TransportBUS _bus;

        ITransportView _view;

        IEnumerable<Transport> _transports;

        public TransportPresenter(ITransportView view)
        {
            _view = view;
            _bus = new TransportBUS();
        }

        public void loadAllTransports()
        {
            _transports = _bus.getEntries();
            _view.upateTransportsView(_transports);
        }

        public void loadAllActiveTransports()
        {
            _transports = _bus.getTransportTourGroup();
            _view.upateTransportsView(_transports);
        }
    }
}
