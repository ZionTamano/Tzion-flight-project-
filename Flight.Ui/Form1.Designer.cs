namespace Flight.Ui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.ListCounteris = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CountFligths = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.LIistViewShowIdCAndCountry = new System.Windows.Forms.ListView();
            this.TopFiveCountries = new System.Windows.Forms.Label();
            this.FlightsCounter = new System.Windows.Forms.Label();
            this.Flights = new System.Windows.Forms.Label();
            this.listViewFlightDetails = new System.Windows.Forms.ListView();
            this.FiligthDetails = new System.Windows.Forms.Label();
            this.HighestFlight = new System.Windows.Forms.Button();
            this.LowestFlight = new System.Windows.Forms.Button();
            this.LastUpdate = new System.Windows.Forms.Label();
            this.ShowLastUpdate = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(127, 47);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ListCounteris
            // 
            this.ListCounteris.AutoSize = true;
            this.ListCounteris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ListCounteris.ForeColor = System.Drawing.Color.Black;
            this.ListCounteris.Location = new System.Drawing.Point(7, 512);
            this.ListCounteris.Name = "ListCounteris";
            this.ListCounteris.Size = new System.Drawing.Size(158, 25);
            this.ListCounteris.TabIndex = 1;
            this.ListCounteris.Text = " Countries List:";
            this.ListCounteris.Click += new System.EventHandler(this.ListCounteris_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 552);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 253);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CountFligths
            // 
            this.CountFligths.AutoSize = true;
            this.CountFligths.Location = new System.Drawing.Point(200, 110);
            this.CountFligths.Name = "CountFligths";
            this.CountFligths.Size = new System.Drawing.Size(90, 17);
            this.CountFligths.TabIndex = 3;
            this.CountFligths.Text = "Count Fligths";
            this.CountFligths.Click += new System.EventHandler(this.CountFligths_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-1, 275);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(166, 174);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // LIistViewShowIdCAndCountry
            // 
            this.LIistViewShowIdCAndCountry.HideSelection = false;
            this.LIistViewShowIdCAndCountry.Location = new System.Drawing.Point(300, 275);
            this.LIistViewShowIdCAndCountry.Name = "LIistViewShowIdCAndCountry";
            this.LIistViewShowIdCAndCountry.Size = new System.Drawing.Size(298, 220);
            this.LIistViewShowIdCAndCountry.TabIndex = 5;
            this.LIistViewShowIdCAndCountry.UseCompatibleStateImageBehavior = false;
            this.LIistViewShowIdCAndCountry.SelectedIndexChanged += new System.EventHandler(this.LIistViewShowIdCAndCountry_SelectedIndexChanged);
            // 
            // TopFiveCountries
            // 
            this.TopFiveCountries.AutoSize = true;
            this.TopFiveCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TopFiveCountries.Location = new System.Drawing.Point(-6, 232);
            this.TopFiveCountries.Name = "TopFiveCountries";
            this.TopFiveCountries.Size = new System.Drawing.Size(169, 25);
            this.TopFiveCountries.TabIndex = 6;
            this.TopFiveCountries.Text = "Top 5 countries:";
            // 
            // FlightsCounter
            // 
            this.FlightsCounter.AutoSize = true;
            this.FlightsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FlightsCounter.Location = new System.Drawing.Point(7, 102);
            this.FlightsCounter.Name = "FlightsCounter";
            this.FlightsCounter.Size = new System.Drawing.Size(161, 25);
            this.FlightsCounter.TabIndex = 7;
            this.FlightsCounter.Text = "Flights counter:";
            // 
            // Flights
            // 
            this.Flights.AutoSize = true;
            this.Flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Flights.Location = new System.Drawing.Point(304, 247);
            this.Flights.Name = "Flights";
            this.Flights.Size = new System.Drawing.Size(83, 25);
            this.Flights.TabIndex = 8;
            this.Flights.Text = "Flights:";
            // 
            // listViewFlightDetails
            // 
            this.listViewFlightDetails.HideSelection = false;
            this.listViewFlightDetails.Location = new System.Drawing.Point(753, 275);
            this.listViewFlightDetails.Name = "listViewFlightDetails";
            this.listViewFlightDetails.Size = new System.Drawing.Size(176, 173);
            this.listViewFlightDetails.TabIndex = 9;
            this.listViewFlightDetails.UseCompatibleStateImageBehavior = false;
            this.listViewFlightDetails.SelectedIndexChanged += new System.EventHandler(this.listViewFlightDetails_SelectedIndexChanged);
            // 
            // FiligthDetails
            // 
            this.FiligthDetails.AutoSize = true;
            this.FiligthDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FiligthDetails.Location = new System.Drawing.Point(751, 247);
            this.FiligthDetails.Name = "FiligthDetails";
            this.FiligthDetails.Size = new System.Drawing.Size(149, 25);
            this.FiligthDetails.TabIndex = 10;
            this.FiligthDetails.Text = "Filigth Details:";
            // 
            // HighestFlight
            // 
            this.HighestFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HighestFlight.Location = new System.Drawing.Point(753, 23);
            this.HighestFlight.Name = "HighestFlight";
            this.HighestFlight.Size = new System.Drawing.Size(173, 36);
            this.HighestFlight.TabIndex = 11;
            this.HighestFlight.Text = "Highest Flight:";
            this.HighestFlight.UseVisualStyleBackColor = true;
            this.HighestFlight.Click += new System.EventHandler(this.HighestFlight_Click);
            // 
            // LowestFlight
            // 
            this.LowestFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LowestFlight.Location = new System.Drawing.Point(756, 136);
            this.LowestFlight.Name = "LowestFlight";
            this.LowestFlight.Size = new System.Drawing.Size(173, 42);
            this.LowestFlight.TabIndex = 12;
            this.LowestFlight.Text = "Lowest Flight:";
            this.LowestFlight.UseVisualStyleBackColor = true;
            this.LowestFlight.Click += new System.EventHandler(this.LowestFlight_Click);
            // 
            // LastUpdate
            // 
            this.LastUpdate.AutoSize = true;
            this.LastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LastUpdate.Location = new System.Drawing.Point(12, 161);
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Size = new System.Drawing.Size(135, 25);
            this.LastUpdate.TabIndex = 13;
            this.LastUpdate.Text = "Last Update:";
            this.LastUpdate.Click += new System.EventHandler(this.LastUpdate_Click);
            // 
            // ShowLastUpdate
            // 
            this.ShowLastUpdate.AutoSize = true;
            this.ShowLastUpdate.Location = new System.Drawing.Point(200, 161);
            this.ShowLastUpdate.Name = "ShowLastUpdate";
            this.ShowLastUpdate.Size = new System.Drawing.Size(127, 17);
            this.ShowLastUpdate.TabIndex = 15;
            this.ShowLastUpdate.Text = "Show Last Update:";
            this.ShowLastUpdate.Click += new System.EventHandler(this.ShowLastUpdate_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(178, 12);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(133, 47);
            this.Stop.TabIndex = 16;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 817);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.ShowLastUpdate);
            this.Controls.Add(this.LastUpdate);
            this.Controls.Add(this.LowestFlight);
            this.Controls.Add(this.HighestFlight);
            this.Controls.Add(this.FiligthDetails);
            this.Controls.Add(this.listViewFlightDetails);
            this.Controls.Add(this.Flights);
            this.Controls.Add(this.FlightsCounter);
            this.Controls.Add(this.TopFiveCountries);
            this.Controls.Add(this.LIistViewShowIdCAndCountry);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.CountFligths);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ListCounteris);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label ListCounteris;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label CountFligths;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView LIistViewShowIdCAndCountry;
        private System.Windows.Forms.Label TopFiveCountries;
        private System.Windows.Forms.Label FlightsCounter;
        private System.Windows.Forms.Label Flights;
        private System.Windows.Forms.ListView listViewFlightDetails;
        private System.Windows.Forms.Label FiligthDetails;
        private System.Windows.Forms.Button HighestFlight;
        private System.Windows.Forms.Button LowestFlight;
        private System.Windows.Forms.Label LastUpdate;
        private System.Windows.Forms.Label ShowLastUpdate;
        private System.Windows.Forms.Button Stop;
    }
}

