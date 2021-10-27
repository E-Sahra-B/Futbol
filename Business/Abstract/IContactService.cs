using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IContactService
    {
       // IDataResult<List<About>> GetAll();
        //IDataResult<About> GetById(int Id);
        IResult Add(Contact contact);
        //IResult Update(About about);
        //IResult Delete(About about);
    }
}
