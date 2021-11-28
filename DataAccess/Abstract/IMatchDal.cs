using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IMatchDal : IEntityRepository<Match>
    {
        List<Match> GetListWithTeam(int id);
    }
}
