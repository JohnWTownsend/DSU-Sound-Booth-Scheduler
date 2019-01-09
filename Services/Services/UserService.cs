using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private DSUSoundBoothSchedulerContext _sbContext;

        public UserService(DSUSoundBoothSchedulerContext sbContext)
        {
            _sbContext = sbContext;
        }
        public DSUSoundBoothSchedulerUser GetUserById(string id)
        {
            DSUSoundBoothSchedulerUser user = _sbContext.Users.Find(id);
            return user;
        }
    }
}
