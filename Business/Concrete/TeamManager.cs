using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class TeamManager:ITeamService
    {
        ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }
        //[SecuredOperation("mod,admin")]
        //[ValidationAspect(typeof(TeamValidator))]
        public void Add(Team team)
        {
            //IResult result = BusinessRules.Run(CheckIfProductNameExists(team.TeamName));

            //if (result != null)
            //{
            //    return result;
            //}
            _teamDal.Add(team);
           // return new SuccessResult(Messages.TeamAdded);
        }
        public void Delete(Team team)
        {
            _teamDal.Delete(team);
           // return new SuccessResult(Messages.TeamDeleted);
        }
        //[SecuredOperation("admin,mod")]
        public List<Team> GetAll()
        {
           return _teamDal.GetAll();
        }
        public Team GetById(int teamId)
        {
            return _teamDal.Get(t => t.TeamId == teamId);
        }
        public void Update(Team team)
        {
            _teamDal.Update(team);
           // return new SuccessResult(Messages.TeamUpdated);
        }
        //private IResult CheckIfProductNameExists(string teamName)
        //{
        //    var result = _teamDal.GetAll(t => t.TeamName == teamName).Any();
        //    if (result)
        //    {
        //        return new ErrorResult(Messages.NameAlreadyExists);
        //    }
        //    return new SuccessResult();
        //}
    }
}
