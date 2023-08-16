using EksiSozluk.BusinessLayer.Abstract;
using EksiSozluk.DataAccessLayer.Abstract;
using EksiSozluk.DtoLayer.Dtos.AppUserDtos;
using EksiSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.Concrete
{
    public class UsersManager : IUsersService
    {
        private readonly IUsersDal _userDal;
        public UsersManager(IUsersDal userDal)
        {
            _userDal = userDal; 
        }

        public void TDelete(AppUser t)
        {
          _userDal.Delete(t);
        }

        public AppUser TGetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<AppUser> TGetList()
        {
            return _userDal.GetList();
        }

        public void TInsert(AppUser t)
        {
           _userDal.Insert(t);
        }

        public void TUpdate(AppUser t)
        {
            _userDal.Update(t); 
        }
    }
}
