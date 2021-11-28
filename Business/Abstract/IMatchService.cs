using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMatchService
    {
        List<Match> GetAll();
        Match GetById(int matchId);
        IResult Add(Match match);
        IResult Update(Match match);
        IResult Delete(Match match);
        List<Match> GetMatchListWithTeam();
    }
}
