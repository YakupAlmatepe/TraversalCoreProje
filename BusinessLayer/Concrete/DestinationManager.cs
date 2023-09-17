using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void TInsert(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }
        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }
        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }
        public List<Destination> TGetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }
    }
}
