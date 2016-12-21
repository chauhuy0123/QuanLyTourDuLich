using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourGroupBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();
        TourManagerEntities _context = new TourManagerEntities();

        private static DateTime MinDate = new DateTime(2000, 1, 1);
        private static DateTime MaxDate = new DateTime(2100, 1, 1);


        public TourGroup getCustomerById(int id)
        {
            return _unitOfWork.TourGroupRepository.GetByID(id);
        }

        public IEnumerable<Customer> getAllCustomers()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }

        public IEnumerable<Customer> getCustomerInTourGroup(int tourGroupid)
        {
            return _unitOfWork.CustomerRepository.GetMany(c => c.TourGroups.Where(group => group.id == tourGroupid).Count() != 0);
        }

        public IEnumerable<TourGroup> getEntries()
        {
            return _unitOfWork.TourGroupRepository.GetAll();
        }

        public void add(TourGroup tourGroup)
        {
            _unitOfWork.TourGroupRepository.Insert(tourGroup);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourGroupRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourGroupRepository.Exists(key);
        }

        public void update(TourGroup tourGroup)
        {
            _unitOfWork.TourGroupRepository.Update(tourGroup);
            _unitOfWork.Save();
        }

        public DateTime getMinDepartDate()
        {
            var entries = _unitOfWork.TourGroupRepository.GetAll();
            if (entries.Count() == 0)
                return TourGroupBUS.MinDate;
            return entries.Min(group => group.depart_date);
        }
        public DateTime getMaxReturnDate()
        {
            var entries = _unitOfWork.TourGroupRepository.GetAll();
            if (entries.Count() == 0)
                return TourGroupBUS.MaxDate;
            return entries.Max(group => group.return_date);
        }

        public IEnumerable<TourGroup> getTourGroupByTour(Tour tour)
        {
            return _unitOfWork.TourGroupRepository.GetMany(tourgroup => tourgroup.tour_id == tour.id);
        }

        public IEnumerable<TourGroup> getAllTourGroupByName(string name)
        {
            return _unitOfWork.TourGroupRepository.GetMany(tourgroup => tourgroup.name == name);
        }
    }
}
