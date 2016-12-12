using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity.SearchEngine
{
    // Adapter Pattern
    public class SearchEngine<TEntity> : ISearchAble<TEntity>
        where TEntity : class
    {
        ISearchAble<TEntity> _engine;

        public SearchEngine(IEnumerable<TEntity> source)
        {
            if (typeof(TEntity) == typeof(DTO.Customer))
            {
                _engine = (ISearchAble<TEntity>)
                    new CustomerSearchEngine((IEnumerable<DTO.Customer>)source);
            }

        }

        public IEnumerable<TEntity> Search(string keyword)
        {
            return _engine.Search(keyword);
        }
    }
}
