using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PlayerManager:IPlayerService
    {
        IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }
        //[SecuredOperation("admin,mod")]
        public void Add(Player player)
        {
            _playerDal.Add(player);
        }
        public void Delete(Player player)
        {
            _playerDal.Delete(player);
            //return new SuccessResult(Messages.PlayerDeleted);
        }
        public List<Player> GetAll()
        {
           return _playerDal.GetAll();
        }
        public Player GetById(int playerId)
        {
            return _playerDal.Get(p => p.PlayerId == playerId);
        }
        public IResult Update(Player player)
        {
            _playerDal.Update(player);
            return new SuccessResult(Messages.PlayerUpdated);
        }
    }
}
