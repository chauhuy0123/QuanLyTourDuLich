using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TourPriceBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();

        public TourPrice getCustomerById(int id)
        {
            return _unitOfWork.TourPriceRepository.GetByID(id);
        }

        public IEnumerable<TourPrice> getEntries()
        {
            return _unitOfWork.TourPriceRepository.GetAll();
        }

        public void add(TourPrice tourprice)
        {
            _unitOfWork.TourPriceRepository.Insert(tourprice);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TourPriceRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TourPriceRepository.Exists(key);
        }

        public void update(TourPrice price)
        {
            _unitOfWork.TourPriceRepository.Update(price);
            _unitOfWork.Save();
        }

        public float getMinPrice()
        {
            return (int) _unitOfWork.TourPriceRepository.GetAll().Min(p => p.price);
        }

        public float getMaxPrice()
        {
            return (int)_unitOfWork.TourPriceRepository.GetAll().Max(p => p.price);
        }
    }
}
