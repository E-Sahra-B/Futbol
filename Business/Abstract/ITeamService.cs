using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
namespace Business.Abstract
{
    public interface ITeamService
    {
        List<Team> GetAll();
        Team GetById(int teamId);
        void Add(Team team);
        void Update(Team team);
        void Delete(Team team);
    }
}
