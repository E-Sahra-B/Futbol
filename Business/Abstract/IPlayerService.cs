using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPlayerService
    {
        List<Player> GetAll();
        //IDataResult<Player> GetById(int playerId);
        void Add(Player player);
        //IResult Update(Player player);
        //IResult Delete(Player player);
    }
}
