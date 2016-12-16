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
    class TourSitePresenter : ITourSitePresenter
    {
        private ITourSiteView _view;
        private TourSiteBUS _bus;
        private IEnumerable<TourSite> _tourSites;
        public TourSitePresenter(ITourSiteView view)
        {
            _view = view;
            _bus = new TourSiteBUS();
        }

        public void loadAllTourSites()
        {
            _tourSites = _bus.getEntries();
            _view.updateTourSiteView(_tourSites);
        }

    }
}
