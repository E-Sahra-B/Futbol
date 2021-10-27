using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class LeagueManager:ILeagueService
    {
        ILeagueDal _leagueDal;
        public LeagueManager(ILeagueDal leagueDal)
        {
            _leagueDal = leagueDal;
        }
        //[SecuredOperation("admin,moderator")]
        public IResult Add(League league)
        {
            _leagueDal.Add(league);
            return new SuccessResult(Messages.LeagueAdded);
        }
        public IResult Delete(League league)
        {
            _leagueDal.Delete(league);
            return new SuccessResult(Messages.LeagueDeleted);
        }
        public IDataResult<List<League>> GetAll()
        {
            return new SuccessDataResult<List<League>>(_leagueDal.GetAll(), Messages.LeaguesListed);
        }
        public IDataResult<League> GetById(int leagueId)
        {
            return new SuccessDataResult<League>(_leagueDal.Get(l => l.LeagueId == leagueId));
        }
        public IResult Update(League league)
        {
            _leagueDal.Update(league);
            return new SuccessResult(Messages.LeagueUpdated);
        }
    }
}
