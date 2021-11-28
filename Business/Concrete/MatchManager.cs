using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class MatchManager:IMatchService
    {
        IMatchDal _matchDal;
        public MatchManager(IMatchDal matchDal)
        {
            _matchDal = matchDal;
        }
        //[SecuredOperation("admin,moderator")]
        public IResult Add(Match match)
        {
            _matchDal.Add(match);
            return new SuccessResult(Messages.MatchAdded);

        }
        public IResult Delete(Match match)
        {
            _matchDal.Delete(match);
            return new SuccessResult(Messages.MatchDeleted);
        }
        public List<Match> GetAll()
        {
            return _matchDal.GetAll();
        }
        public Match GetById(int matchId)
        {
            return _matchDal.Get(t => t.MatchId == matchId);
        }

        public List<Match> GetMatchListWithTeam()
        {
            return _matchDal.Get();
        }

        public IResult Update(Match match)
        {
            _matchDal.Update(match);
            return new SuccessResult(Messages.MatchUpdated);
        }
    }
}
