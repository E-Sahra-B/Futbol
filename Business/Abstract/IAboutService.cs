using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAboutService
    {
       List<About> GetAll();
        //IDataResult<About> GetById(int Id);
        //IResult Add(About about);
        //IResult Update(About about);
        //IResult Delete(About about);
    }
}
