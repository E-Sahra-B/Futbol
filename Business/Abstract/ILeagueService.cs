using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILeagueService
    {
        IDataResult<List<League>> GetAll();
        IDataResult<League> GetById(int leagueId);
        IResult Add(League league);
        IResult Update(League league);
        IResult Delete(League league);
    }
}
