using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class SecondModelFlights
    {

        public string Id { get; set; }

        public string Origin_country { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }

        public float Baro_altitude { get; set; }

        public int MyProperty { get; set; }

      //  public DateTime dateTime { get; set; }

       
        public SecondModelFlights(object id, object origin_country, object longitude, object latitude, object baro_altitude)
        {
           // this.dateTime = DateTime.Now;

            Id = id.ToString();

            Origin_country = origin_country.ToString();

            if (longitude != null)
            {
                Longitude = float.Parse(longitude.ToString()); ;
            }

            if (latitude != null)
            {
                Latitude = float.Parse(latitude.ToString()); ;
            }

            if (baro_altitude != null)
            {
                Baro_altitude = float.Parse(baro_altitude.ToString()); ;
            }
        }
    }
}
