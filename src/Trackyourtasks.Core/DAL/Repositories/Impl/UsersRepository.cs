﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trackyourtasks.Core.DAL.DataModel;

namespace Trackyourtasks.Core.DAL
{
    public class UsersRepository : IUsersRepository
    {
        TrackYourTasksDataContext _context = new TrackYourTasksDataContext();

        #region IUsersRepository Members

        public User FindUserById(int id)
        {
            return (from user in _context.Users where user.Id == id select user).SingleOrDefault();
        }

        public User FindUserByEmail(string email)
        {
            return (from user in _context.Users where user.Email == email select user).SingleOrDefault();
        }

        public void SaveUser(User user)
        {
            if (user.Id == 0)
            {
                _context.Users.InsertOnSubmit(user);
            }
            _context.SubmitChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Users.DeleteOnSubmit(user);
            _context.SubmitChanges();
        }

        #endregion
    }
}
