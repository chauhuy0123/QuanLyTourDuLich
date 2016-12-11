using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    using DAO.GenericRepository;
    using DTO;
    using System.Data.Entity.Validation;
    using System.Diagnostics;

    class UnitOfWork : IDisposable
    {
        protected static TourManagerDataSet _dataSet;
        private DTO.TourManagerEntities _entityContext = null;

        /**
        // private GenericRepository<DTO.Class> _classRepository;
        **/
        private GenericRepository<Customer> _customerRepository;

        public UnitOfWork()
        {
            _dataSet = new TourManagerDataSet();
            _entityContext = new DTO.TourManagerEntities();
        }



        public void Save()
        {
            try
            {
                _entityContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _entityContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        } 
    }
}
