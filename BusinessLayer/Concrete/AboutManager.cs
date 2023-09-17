using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class IAboutManager : IAboutService
    {

        IAboutDal _aboutDal;

        public IAboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
            
        }

        public List<About> TGetList()
        {
            
            return _aboutDal.GetList();
        }

        public void TInsert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TUpdate(About t)
        {
           _aboutDal.Update(t);
        }
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
