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
    class DestinationPresenter : IDestinationPresenter
    {
        IDestinationView _view;
        DestinationBUS _bus;
        IEnumerable<Destination> _destinations;

        public DestinationPresenter(IDestinationView view)
        {
            _view = view;
            _bus = new DestinationBUS();
        }

        public void loadAllDestinations()
        {
            _destinations = _bus.getEntries();
            _view.updateDestinationView(_destinations);
        }


        public void addDestination(Destination destination)
        {
            _bus.add(destination);
            _destinations =_bus.getEntries();
            _view.updateDestinationView(_destinations);
        }
    }
}
