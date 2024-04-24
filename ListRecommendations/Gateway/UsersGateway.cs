using ListRecommendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRecommendations.Gateway
{
    class UsersGateway
    {
        ApplicationDBContext dBContext = new ApplicationDBContext();

        public bool Add(Users users)
        {
            dBContext.Users.Add(users);
            return dBContext.SaveChanges() > 0;
        }

        public List<Users>GetAll()
        {
            return dBContext.Users.ToList();
        }
    }
}
