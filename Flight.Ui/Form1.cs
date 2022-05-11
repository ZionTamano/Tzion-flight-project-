using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight.Model;
using Filght.Entites;
using Filght.DAL;

namespace Flight.Ui
{
    public partial class Form1 : Form
    {

        EntitesManager manager = new EntitesManager();
        object listviewkey = new object();
        public Form1()
        {
            InitializeComponent();
            //listView2.MouseClick += new MouseEventHandler(listView2_SelectedIndexChanged);
            //listView1.MouseClick += new MouseEventHandler(listView1_SelectedIndexChanged);
            //LIistViewShowIdCAndCountry.MouseDoubleClick += new MouseEventHandler(LIistViewShowIdCAndCountry_SelectedIndexChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            manager.RunAllProgram();
            manager.AllFunc.HandlerUpdate += ShowAllNameCountires;
            manager.AllFunc.HandlerUpdate += ShowCountFligth;
            manager.AllFunc.HandlerUpdate += ShowTopFiveNameCountires;
            manager.AllFunc.HandlerUpdate += ShowLUapdet;
        }

        public void ShowCountFligth()
        {
            if (CountFligths.InvokeRequired)
            {
                CountFligths.Invoke(new Action(() =>
                {
                    int count = manager.AllFunc.CountFlights();

                    CountFligths.Text = count.ToString();
                }));

            }
        }

        public void ShowAllNameCountires()
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() =>
                {
                    List<string> names = manager.AllFunc.ListAllCountries();
                    lock (listviewkey)
                    {
                        listView1.Clear();
                        listView1.Columns.Add("", 100);
                        listView1.View = View.Details;
                        foreach (var name in names)
                        {
                            listView1.Items.Add(name);
                        }
                    }
                }));
            }
        }

        public void ShowTopFiveNameCountires()
        {
            if (listView2.InvokeRequired)
            {
                listView2.Invoke(new Action(() =>
                {
                    List<string> names = manager.AllFunc.ListTopFiveCountries();
                    lock (listviewkey)
                    {
                        listView2.Clear();
                        listView2.Columns.Add("", 100);
                        listView2.View = View.Details;
                        foreach (var name in names)
                        {
                            listView2.Items.Add(name);

                        }
                    }
                }));
            }
        }

        public void ShowLUapdet()
        {
            if (ShowLastUpdate.InvokeRequired)
            {
                ShowLastUpdate.Invoke(new Action(() =>
                {
                    ShowLastUpdate.Text = manager.AllFunc.TimeUpdateFlights().ToString();

                }));
            }
        }

        public void ShowHighest()
        {
            List<SecondModelFlights> flight = manager.AllFunc.HighestFlightShow();
            listViewFlightDetails.Clear();
            listViewFlightDetails.Columns.Add("", 150);
            listViewFlightDetails.View = View.Details;
            foreach (var item in flight)
            {
                //listViewFlightDetails.Items.Add("Id:" + item.Id + "\n " + "Country:" + item.Origin_country + "\n" + "Longitude:" + item.Longitude + "\n" + "Latitude:" + item.Latitude + "\n" + "Baro_altitude:" + item.Baro_altitude);
                listViewFlightDetails.Items.Add("Id:" + item.Id);
                listViewFlightDetails.Items.Add("Origin_country:" + item.Origin_country);
                listViewFlightDetails.Items.Add("Longitude:" + item.Longitude);
                listViewFlightDetails.Items.Add("Latitude:" + item.Latitude);
                listViewFlightDetails.Items.Add("Baro_altitude:" + item.Baro_altitude);
            }
        }

        public void BatteredHighest()
        {
            List<SecondModelFlights> flight = manager.AllFunc.BatteredFlightShow();
            listViewFlightDetails.Clear();
            listViewFlightDetails.Columns.Add("", 150);
            listViewFlightDetails.View = View.Details;
            foreach (var item in flight)
            {
                listViewFlightDetails.Items.Add("Id:" + item.Id);
                listViewFlightDetails.Items.Add("Origin_country:" + item.Origin_country);
                listViewFlightDetails.Items.Add("Longitude:" + item.Longitude);
                listViewFlightDetails.Items.Add("Latitude:" + item.Latitude);
                listViewFlightDetails.Items.Add("Baro_altitude:" + item.Baro_altitude);
            }
        }

        private void ListCounteris_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = null;

            lock (listviewkey)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    country = listView1.SelectedItems[0].SubItems[0].Text;
                }
            }

            if (country != null)
            {
                LIistViewShowIdCAndCountry.Clear();
                LIistViewShowIdCAndCountry.Columns.Add("", 200);
                LIistViewShowIdCAndCountry.View = View.Details;
                foreach (var item in manager.AllFunc.AllRelevantFlightData)
                {
                    if (item.Origin_country == country)
                    {
                        LIistViewShowIdCAndCountry.Items.Add("Id:" + item.Id + " , " + "Country:" + item.Origin_country);
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("No country is selected");
            //}
        }

        private void CountFligths_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = null;

            lock (listviewkey)
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    country = listView2.SelectedItems[0].SubItems[0].Text;
                }
            }

            if (country != null)
            {
                LIistViewShowIdCAndCountry.Clear();
                LIistViewShowIdCAndCountry.Columns.Add("", 200);
                LIistViewShowIdCAndCountry.View = View.Details;
                foreach (var item in manager.AllFunc.AllRelevantFlightData)
                {
                    if (item.Origin_country == country)
                    {
                        LIistViewShowIdCAndCountry.Items.Add("Id:" + item.Id +" , "+"Country:" + item.Origin_country);
                    }
                }
            }
        }

        private void LIistViewShowIdCAndCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Idcountry = null;
            lock (listviewkey)
            {
                if (LIistViewShowIdCAndCountry.SelectedItems.Count > 0)
                {
                     Idcountry = LIistViewShowIdCAndCountry.SelectedItems[0].SubItems[0].Text;
                }
            }
            
            if (Idcountry != null)
            {
                List<string> id = Idcountry.Split(':', ' ').ToList();
                listViewFlightDetails.Items.Clear();
                listViewFlightDetails.Columns.Add("", 150);
                listViewFlightDetails.View = View.Details;
                foreach (var item in manager.AllFunc.AllRelevantFlightData)
                {

                    if (item.Id == id[1].ToString())
                    {
                        listViewFlightDetails.Items.Add("Id:" + item.Id);
                        listViewFlightDetails.Items.Add("Origin_country:" + item.Origin_country);
                        listViewFlightDetails.Items.Add("Longitude:" + item.Longitude);
                        listViewFlightDetails.Items.Add("Latitude:" + item.Latitude);
                        listViewFlightDetails.Items.Add("Baro_altitude:" + item.Baro_altitude);
                    }
                }
            }
        }

        private void listViewFlightDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HighestFlight_Click(object sender, EventArgs e)
        {
            ShowHighest();
        }

        private void LowestFlight_Click(object sender, EventArgs e)
        {
            BatteredHighest();
        }

        private void LastUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void ShowLastUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
             manager.RunLoop = false;
        }

        //private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    var country = listView2.SelectedItems[0].SubItems[0].Text;
        //    // LIistViewShowIdCAndCountry.Items.Clear();
        //    foreach (var item in manager.AllFunc.AllRelevantFlightData)
        //    {
        //        if (item.Origin_country == country)
        //        {
        //            LIistViewShowIdCAndCountry.Items.Add("Id:" + item.Id + " " + "Country:" + item.Origin_country);
        //            return;
        //        }
        //    }
        //}

        //public void ClickOnListViewShowCountryAndId()
        //{
        //    if (listView2.InvokeRequired)
        //    {
        //        listView2.Invoke(new Action(() =>
        //        {
        //            List<string> ids = manager.AllFunc.ShowIdAndNameCountriesOfTopFiveCountries();
        //            listView2.Clear();
        //            foreach (var name in names)
        //            {
        //                listView2.Items.Add(name);
        //            }
        //        }));
        //    }
        //}
        // DateTime.Now.Year.ToString();
        // CountFligths.Visible = true;
    }
}
