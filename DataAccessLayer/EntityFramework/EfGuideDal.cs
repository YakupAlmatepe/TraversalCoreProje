using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepositpory<Guide>, IGuideDal
    {
    }
}
