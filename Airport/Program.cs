using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KøbenhavnsLufthavnEntities())
            {
                var planeRoute = new PlaneRoute()
                {
                    AirportOne = "CPH",
                    AirportTwo = "LAX",
                    RouteOwner = 1
                };
                context.PlaneRoutes.Add(planeRoute);

                context.SaveChanges();
            }
        }
    }
}
