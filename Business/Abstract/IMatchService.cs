using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMatchService
    {
        List<Match> GetAll();
        //IDataResult<Match> GetById(int matchId);
        void Add(Match match);
        //IResult Update(Match match);
        //IResult Delete(Match match);
    }
}
