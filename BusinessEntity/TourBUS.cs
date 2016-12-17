using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        public Tour getCustomerById(int id)
        {
            return _unitOfWork.TourRepository.GetByID(id);
        }

        public IEnumerable<Tour> getEntries()
        {
            return _unitOfWork.TourRepository.GetAll();
        }

        public void add(Tour tour)
        {
            // T-T
            //DAO.GenericRepository.GenericRepository<TourSite> repo 
            //    = _unitOfWork.createTourSiteRepo();
            //foreach (var item in tour.TourSites)
            //{
            //    repo.Update(item);
            //}
            //tour.TourSites = null;
            _unitOfWork.TourRepository.Insert(tour);
            _unitOfWork.Save();

            //_unitOfWork.DestinationRepository.
            //_unitOfWork.TourRepository.Refresh();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourRepository.Delete(id);
            _unitOfWork.Save();
        }
        public void delete(Tour tour)
        {
            _unitOfWork.TourRepository.Delete(tour);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourRepository.Exists(key);
        }

        public void update(Tour tour)
        {
            _unitOfWork.TourRepository.Update(tour);
            _unitOfWork.Save();
        }
        public void refresh()
        {
            _unitOfWork.TourRepository.Refresh();
        }
    }
}
