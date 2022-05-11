using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filght.DAL;
using Flight.Model;
using System.Data;
namespace Filght.Entites
{
    public class DataUpdateRequest
    {
        public List<SecondModelFlights> AllRelevantFlightData = new List<SecondModelFlights>();
        public RequestFlights requestFlights = new RequestFlights();
        public DateTime dateTime = new DateTime();
        public delegate void delUpdateFlight();
        public event delUpdateFlight HandlerUpdate;

        public async void FlightDataInList()
        {
            var AllArrayFlight = await requestFlights.GetFilghtData();

            AllRelevantFlightData.Clear();
            foreach (var PartOfAFlight in AllArrayFlight.states)
            {
                SecondModelFlights oneFlight = new SecondModelFlights(PartOfAFlight[0], PartOfAFlight[2], PartOfAFlight[5], PartOfAFlight[6], PartOfAFlight[7]);
                AllRelevantFlightData.Add(oneFlight);
            }
            dateTime = DateTime.Now;
            HandlerUpdate();  //Start Event
        }

        public List<string> ListAllCountries()
        {
            var listCountry = (from c in AllRelevantFlightData
                               select c.Origin_country.ToString()).Distinct().ToList();
            return listCountry;
        }

        public List<string> ListTopFiveCountries()
        {
            var divGroupOrderByName = (from fligth in AllRelevantFlightData
                                       group fligth by fligth.Origin_country into numOfFlightsInEachCountry
                                       select new
                                       {
                                           Country = numOfFlightsInEachCountry.Key,
                                           numOfFlights = numOfFlightsInEachCountry.Count()

                                       }).OrderByDescending(mostFligth => mostFligth.numOfFlights).Take(5).ToList();

            List<string> topFive = new List<string>();
            foreach (var i in divGroupOrderByName)
            {
                topFive.Add(i.Country);
            }

           List<string> fiveTopcountry = topFive.ToList();

            return fiveTopcountry;
        }
    
        public string ShowIdAndNameCountriesOfTopFiveCountries(string country)
        {
            var FiveCountry = (from q in AllRelevantFlightData
                               where q.Origin_country == country
                               select q.Id + q.Origin_country).ToString();
            return FiveCountry;
        }

        public string DataFlight(string country)
        {
            var DetailsCountry = (from q in  AllRelevantFlightData
                                  where q.Origin_country == country
                                  select q).ToString();
            return  DetailsCountry;
        }

        public int CountFlights()
        {
            var CountFlight = AllRelevantFlightData.Count();

            return CountFlight;
        }

        public DateTime TimeUpdateFlights()
        {
            return dateTime;

        }

        public List<SecondModelFlights> HighestFlightShow()
        {
            var orderByDescendingResult = (from Highest in AllRelevantFlightData //Sorts the studentList collection in descending order
                                           orderby Highest.Baro_altitude descending
                                           select Highest).Take(1).ToList();
            return orderByDescendingResult;
        }

        public List<SecondModelFlights> BatteredFlightShow()
        {
            var orderByDescendingResult = (from Highest in AllRelevantFlightData //Sorts the studentList collection in descending order
                                           orderby Highest.Baro_altitude
                                           select Highest).Take(1).ToList();
            return orderByDescendingResult;
        }
    }
}
