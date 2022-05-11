using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filght.DAL;
using Flight.Model;

namespace Filght.Entites
{
    public class EntitesManager
    {
        public bool RunLoop = true;
        public DataUpdateRequest AllFunc = new DataUpdateRequest();

        public void RunAllProgram()
        {
            Task.Run(() =>
            {
                while (RunLoop)
                {
                    AllFunc.FlightDataInList();
                    System.Threading.Thread.Sleep(30000);
                }
            });
        }
    }
}
