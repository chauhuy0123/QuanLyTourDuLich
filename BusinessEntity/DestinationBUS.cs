using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class DestinationBUS
    {
        UnitOfWork _unitOfWork = new DAO.UnitOfWork();


        public Destination getCustomerById(int id)
        {
            return _unitOfWork.DestinationRepository.GetByID(id);
        }

        public IEnumerable<Destination> getEntries()
        {
            return _unitOfWork.DestinationRepository.GetAll();
        }

        public void add(Destination destination)
        {
            _unitOfWork.DestinationRepository.Insert(destination);
            _unitOfWork.Save();
        }

        public void deletaById(int id)
        {
            _unitOfWork.DestinationRepository.Delete(id);
            _unitOfWork.Save();
        }

        public bool isExists(int key)
        {
            return _unitOfWork.DestinationRepository.Exists(key);
        }

        public void update(Destination destination)
        {
            _unitOfWork.DestinationRepository.Update(destination);
            _unitOfWork.Save();
        }
    }
}
