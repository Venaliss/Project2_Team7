using ListRecommendations.Gateway;
using ListRecommendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRecommendations.Manager
{
    class UsersManager
    {
        UsersGateway usersGateway = new UsersGateway();

        public bool Add(Users users)
        {
            return usersGateway.Add(users);
        }

        public List<Users> GetAll()
        {
            return usersGateway.GetAll();
        }
    }
}
