using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRecommendations.Models
{
    public class Favorite
    {
        public int ID { get; set; }

        public string routeName { get; set; }

        public string routeInfo { get; set; }

        public string routeMark { get; set; }
    }
}
