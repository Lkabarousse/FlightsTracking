using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsTracking.Application.Features.Utility
{
    public class FlightsHelper
    {
        public static double GetDistanceFromLatLonInKm(double latDep, double lonDep, double latArr, double lonArr)
        {
            if ((latDep == latArr) && (lonDep == lonArr))
            {
                return 0;
            }
            else
            {
                double theta = lonDep - lonArr;
                double dist = Math.Sin(Deg2rad(latDep)) * Math.Sin(Deg2rad(latArr)) + Math.Cos(Deg2rad(latDep)) * Math.Cos(Deg2rad(latArr)) * Math.Cos(Deg2rad(theta));
                dist = Math.Acos(dist);
                dist = Rad2deg(dist);
                dist = dist * 60 * 1.1515 * 1.609344;

                return (dist);
            }
        }
        // This function converts decimal degrees to radians             
        private static double Deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }


        // This function converts radians to decimal degrees            
        private static double Rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
    }
}
