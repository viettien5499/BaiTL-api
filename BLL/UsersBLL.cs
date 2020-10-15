using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UsersBLL: IUsersBLL
    {
        private IUsersDAL _res;
        public UsersBLL(IUsersDAL ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public List<UsersModel> getallUsers()
        {
            return _res.GetData();

        }
    }
}
