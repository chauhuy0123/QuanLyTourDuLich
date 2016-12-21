using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class TransportBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();
    
        public Transport getCustomerById(int id)
        {
            return _unitOfWork.TransportRepository.GetByID(id);
        }

        public IEnumerable<Transport> getEntries()
        {
            return _unitOfWork.TransportRepository.GetAll();
        }

        public void add(Transport transport)
        {
            _unitOfWork.TransportRepository.Insert(transport);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.TransportRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.TransportRepository.Exists(key);
        }

        public void update(Transport transport)
        {
            _unitOfWork.TransportRepository.Update(transport);
            _unitOfWork.Save();
        }


        public IEnumerable<Transport> getTransportTourGroup()
        {
            return _unitOfWork
                .TransportRepository
                .GetMany(transport => (transport.TourGroups != null && transport.TourGroups.Count != 0));


        }
    }
}
