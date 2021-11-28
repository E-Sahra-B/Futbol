using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMatchDal : EfEntityRepositoryBase<Match, FootballContext>, IMatchDal
    {
        public List<Match> GetListWithTeam(int id)
        {
            //using (var c = new FootballContext())
            //{
            //    return c.Matches.Include(x => x.HomeTeams).ToList();
            //}
            //using (var t = new FootballContext())
            //{
            //    return t.Matches.Include(y => y.GuestTeams).ToList();
            //}

            using (var c = new FootballContext())
            {
                return c.Matches.Include(x => x.HomeTeams)
                    .Where(x => x.HomeTeamID == id).ToList() or
                    c.Matches.Include(y => y.GuestTeams)
                    .Where(y => y.GuestTeamID == id).ToList();
            }
        }
    }
}
