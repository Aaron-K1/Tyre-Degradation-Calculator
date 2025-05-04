using Newtonsoft.Json;
using Renault_F1_Application.Types.OpenWeather;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace Renault_F1_Application
{
    public partial class Form1 : Form
    {
        private const string OPENWEATHERAPPID = "";
        List<Tyre> TyreList = new List<Tyre>();
        List<Tyre> FilteredTyreListType = new List<Tyre>();
        List<Track> TrackList = new List<Track>();
        List<int> TrackDegPoints = new List<int>();
        List<int> DegResults = new List<int>();

        double TrackTemp = 0.0;

        Track SelectedTrack;

        public Form1()
        {
            InitializeComponent();
            LoadTyre();
            LoadTrack();
            ClearResultText();

            TempLbl.Text = "Temperature " + "(\u00B0" + "C):";

            //Enables or disables combobox selection if no values present in list
            ComboBoxSelectionControl(FrontLeftBox);  
            ComboBoxSelectionControl(FrontRightBox);
            ComboBoxSelectionControl(RearLeftBox);
            ComboBoxSelectionControl(RearRightBox);

            if (TrackBox.SelectedItem == null) 
            {
                FrontLeftBox.Enabled = false;
                TempTBox.Enabled = false;
            }
            else
            {
                FrontLeftBox.Enabled = true;
                TempTBox.Enabled = true;
            }
        }
        


        //Loads tyres into application
        public void LoadTyre()
        {
            var tyreXMLFile = Properties.Resources.TyresXML;

            XmlDocument docXml = new XmlDocument();
            docXml.LoadXml(tyreXMLFile); //Loads XML File

            foreach (XmlNode node in docXml.DocumentElement) //ForEach XML element in document
            {
                string name = node["Name"].InnerText; //Collects and stores tyre name 
                string family = node["Family"].InnerText; //Collects and stores tyre family
                string type = node["Type"].InnerText; //Collects and stores tyre type
                string placement = node["Placement"].Value; //Collects and stores tyre placement
                double degradationcoefficient = double.Parse(node["DegradationCoefficient"].InnerText); //Collects and stores tyre Degradation Coefficient

                Tyre newTyre = new Tyre(name, family, type, placement, degradationcoefficient); //Creats new tyre object

                TyreList.Add(newTyre); //Adds the new tyre object to tyre list
             
                FrontLeftBox.Items.Add(newTyre); //Adds the new tyre object to combo box
            }
        }



        //Clears result label text
        public void ClearResultText()
        {
            
            FLAvgResult.Text = "";
            FLModeResult.Text = "";
            FLRangeResult.Text = "";

            FRAverageResult.Text = "";
            FRModeResult.Text = "";
            FRRangeResult.Text = "";

            RLAverageResult.Text = "";
            RLModeResult.Text = "";
            RLRangeResult.Text = "";

            RRAverageResult.Text = "";
            RRModeResult.Text = "";
            RRRangeResult.Text = "";
        }



        //Controls the selection of combo boxes/ drop down lists ensuring they are only selectable when values are avaliable (user flow control)
        public void ComboBoxSelectionControl(ComboBox box)
        {
            if (box.Items.Count == 0)
            {
                box.Enabled = false;
            }
            else
            {
                box.Enabled = true;
            } 
        }



        //Loads Tracks into application
        public void LoadTrack()
        {
            List<string> lines = Properties.Resources.TrackDegradationCoefficients.Split('\n').ToList();

            foreach (string line in lines)
            {
                List<string> Tracks = line.Split('|').ToList();

                string name = Tracks[0];
                string location = Tracks[1];
                string degragationpoint = Tracks[2];

                Track newTrack = new Track(name, location, degragationpoint);

                TrackList.Add(newTrack);

                TrackBox.Items.Add(newTrack);
            }

        }



        public void FrontLeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tyreCheck(FrontRightBox, RearLeftBox, RearRightBox);

            Tyre tyreFL = (Tyre)FrontLeftBox.SelectedItem; //Casts selected item to tyre type 

            FilteredTyreListType = TyreList.Where(t => t.Type == tyreFL.Type).ToList(); //Filters tyre list by type, ensuring all tyres are of same type

            List<Tyre> FilteredTyreListFamily = FilteredTyreListType.Where(t => t.Family == tyreFL.Family).ToList(); // Filters tyre listby family, ensures front tyres are of same family and type

            //clears tyres from list allowing addition of new filtered tyres
            RearLeftBox.Items.Clear(); 
            FrontRightBox.Items.Clear();
            RearRightBox.Items.Clear();

            foreach (Tyre t in FilteredTyreListFamily)
            {
                FrontRightBox.Items.Add(t); // Addds filtered tyres to combo box (dropdown)
            }

            foreach (Tyre t in FilteredTyreListType)
            {
                RearLeftBox.Items.Add(t); // Addds filtered tyres to combo box (dropdown)

            }

            if (TrackBox.SelectedItem != null)
            {
                ExecuteCalcs(tyreFL, FLAvgResult, FLRangeResult, FLModeResult); //Executes calculation for front left tyre
            }
            else
            {
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message
            }

           

            //Enables combobox selection as filtered tyres added to combobox 
            ComboBoxSelectionControl(FrontRightBox);
            ComboBoxSelectionControl(RearLeftBox);
    
        }

        private void FrontRightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tyre tyreFR = (Tyre)FrontRightBox.SelectedItem; //Casts selected item to tyre type 

            if (TrackBox.SelectedItem != null)
            {
                ExecuteCalcs(tyreFR, FRAverageResult, FRRangeResult, FRModeResult); //Executes calculation for front right tyre
            }
            else
            {
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message
            }
        }



        private void RearLeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tyre tyreRL = (Tyre)RearLeftBox.SelectedItem; //Casts selected item to tyre type 

            List<Tyre> RightTyreList = FilteredTyreListType.Where(t => t.Family == tyreRL.Family).ToList(); //filters list by family, ensuring back tyres are of same family and type

            foreach (Tyre t in RightTyreList)
            {
                RearRightBox.Items.Add(t); // Addds filtered tyres to combo box (dropdown)
            }


            if (TrackBox.SelectedItem != null)
            {
                ExecuteCalcs(tyreRL, RLAverageResult, RLRangeResult, RLModeResult); //Executes calculation for rear left tyre
            }
            else
            {
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message
            }

            ComboBoxSelectionControl(RearRightBox); //Enables combobox selection as filtered tyres added to combobox
        }



        private void RearRightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tyre tyreRR = (Tyre)RearRightBox.SelectedItem; //Casts selected item to tyre type 

            if (TrackBox.SelectedItem != null)
            {
                ExecuteCalcs(tyreRR, RRAverageResult, RRRangeResult, RRModeResult); //Executes calculation for rear right tyre
            }
            else
            {
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message
            }
        }



        private void TrackBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTrack = (Track)TrackBox.SelectedItem; //Casts selected item to tyre type 

            TrackDegPoints.Clear();

            //Converts Track degragation point from string to list<int> to allow for use in formula
            List<string> DegPoints = SelectedTrack.DegragationPoint.Split(',').ToList(); //splits string and stores values in list<string>

            foreach (string D in DegPoints)
            {
                int ConvertedPoint = Convert.ToInt32(D); //Converts string values in list<string> to int
                
                TrackDegPoints.Add(ConvertedPoint); //Adds converted deg point to TrackDegPoints list<int>
            }

            GetWeather(SelectedTrack.Location); //Track Temp API call made

            //Re-Performs calculations if track is changed
            if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null && FrontRightBox.SelectedItem != null && RearLeftBox.SelectedItem != null && RearRightBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
                ExecuteCalcs((Tyre)FrontRightBox.SelectedItem, FRAverageResult, FRRangeResult, FRModeResult);
                ExecuteCalcs((Tyre)RearLeftBox.SelectedItem, RLAverageResult, RLRangeResult, RLModeResult);
                ExecuteCalcs((Tyre)RearRightBox.SelectedItem, RRAverageResult, RRRangeResult, RRModeResult);
            }
            else if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null && FrontRightBox.SelectedItem != null && RearLeftBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
                ExecuteCalcs((Tyre)FrontRightBox.SelectedItem, FRAverageResult, FRRangeResult, FRModeResult);
                ExecuteCalcs((Tyre)RearLeftBox.SelectedItem, RLAverageResult, RLRangeResult, RLModeResult);
            }
            else if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null && FrontRightBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
                ExecuteCalcs((Tyre)FrontRightBox.SelectedItem, FRAverageResult, FRRangeResult, FRModeResult);
            }
            else if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
            }


            if (TrackBox.SelectedItem == null) //Selection control
            {
                FrontLeftBox.Enabled = false;
                TempTBox.Enabled = false;
            }
            else
            {
                FrontLeftBox.Enabled = true;
                TempTBox.Enabled = true;
            }
        }


        //Makes Track Tempreture Web Service (API) call. 
        public void GetWeather(string location)
        {
            var latLong = ConvertTrackLocationLongAndLat(location);

            using (WebClient web = new WebClient())
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?lat={latLong.Item1}&lon={latLong.Item2}&appid={OPENWEATHERAPPID}";

                var json = web.DownloadString(url);

                var getCurrentWeatherResponse = JsonConvert.DeserializeObject<GetCurrentWeatherResponse>(json);

                var tempreture = getCurrentWeatherResponse.Main.Temp;
                TempTBox.Text = tempreture.ToString();
                TrackTemp = tempreture;
            }

        }

        public Tuple<double, double> ConvertTrackLocationLongAndLat(string location)
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    var url = $"http://api.openweathermap.org/geo/1.0/direct?q={location}&limit=1&appid={OPENWEATHERAPPID}";

                    var json = web.DownloadString(url);

                    var geocodeResults = JsonConvert.DeserializeObject<List<GeocodeResult>>(json);

                    if (geocodeResults.Any())
                    {
                        var geocodeResult = geocodeResults.First();
                        return Tuple.Create(geocodeResult.latitude, geocodeResult.longitude);      
                    }
                    else
                    {
                        MessageBox.Show("No results found for the specified location.", "Geocoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return Tuple.Create(0.0, 0.0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while fetching geocoding data: {ex.Message}", "Geocoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Tuple.Create(0.0, 0.0);
                }
            }
        }

        //Calculates tyre point degragation and stores result within DegResults List
        public void CalculateDeg(Tyre x, Track xs)
        {
            string tyreType = x.Type;

            double tyreDegCoe = x.DegradationCoefficient;

            //Check type of tyre and applies percentage to tyre degregation coefficient 
            if (tyreType == "SuperSoft" || tyreType == "Soft") 
            {
                tyreDegCoe = tyreDegCoe-(tyreDegCoe * 0.8);
            }
            else if (tyreType == "Medium")
            {
                tyreDegCoe = tyreDegCoe - (tyreDegCoe * 0.9);
            }
            else if (tyreType == "Hard")
            {
                tyreDegCoe = tyreDegCoe - (tyreDegCoe * 0.75);
            }

            //Calculates point tyre degregation for all degregation points on a track and adds results to DegResults list
            foreach (double degPoint in TrackDegPoints)
            {
                int DegResult = Convert.ToInt32( (degPoint * TrackTemp) / tyreDegCoe);
                DegResults.Add(DegResult);
            }
        }



        //Calculates average of DegResults list 
        public void AverageCalc(Label averagelbl)
        {
            int ResultsAverage = Convert.ToInt32(DegResults.Average());

            averagelbl.Text = ResultsAverage.ToString();

            ColourLegend(ResultsAverage, averagelbl);
        }



        //Calculates mode of DegResults list 
        public void ModeCalc(Label modelbl)
        {
            int ResultsMode = DegResults.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First(); 

            modelbl.Text = ResultsMode.ToString();

            ColourLegend(ResultsMode, modelbl);
        }



        //Calculates range of DegResults list 
        public void RangeCalc(Label rangelbl)
        {
            int ResultsMax = DegResults.Max();
            int ResultsMin = DegResults.Min();

            int ResultsRange = ResultsMax - ResultsMin;
            
            rangelbl.Text = ResultsRange.ToString();

            ColourLegend(ResultsRange, rangelbl);
        }



        //Calculates tyre point degragation, average, mode, range displaying results 
        public void ExecuteCalcs(Tyre tyre, Label averageLbl, Label rangeLbl, Label modeLbl)
        {
            DegResults.Clear();

            CalculateDeg(tyre, SelectedTrack);

            AverageCalc(averageLbl); 
            RangeCalc(rangeLbl);
            ModeCalc(modeLbl);
        }



        //Colour legend for result average, mode and range values
        public void ColourLegend(int results,Label resultsLbl)
        {
            if (results <= 999)
            {
                resultsLbl.BackColor = Color.LightGreen;
            }
            else if (results >= 1000 && results <= 2999)
            {
                resultsLbl.BackColor = Color.Yellow;
            }
            else if (results >= 3000)
            {
                resultsLbl.BackColor = Color.Red;
            }
        }



        private void TempTBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TrackTemp = Convert.ToDouble(TempTBox.Text);
            }
            catch
            {
                return;
            }


            //Redo calculations if temp is in changed by the user     
            if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null && FrontRightBox.SelectedItem != null && RearLeftBox.SelectedItem != null && RearRightBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
                ExecuteCalcs((Tyre)FrontRightBox.SelectedItem, FRAverageResult, FRRangeResult, FRModeResult);
                ExecuteCalcs((Tyre)RearLeftBox.SelectedItem, RLAverageResult, RLRangeResult, RLModeResult);
                ExecuteCalcs((Tyre)RearRightBox.SelectedItem, RRAverageResult, RRRangeResult, RRModeResult);
            }
            else if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null && FrontRightBox.SelectedItem != null && RearLeftBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
                ExecuteCalcs((Tyre)FrontRightBox.SelectedItem, FRAverageResult, FRRangeResult, FRModeResult);
                ExecuteCalcs((Tyre)RearLeftBox.SelectedItem, RLAverageResult, RLRangeResult, RLModeResult);
            }
            else if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null && FrontRightBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
                ExecuteCalcs((Tyre)FrontRightBox.SelectedItem, FRAverageResult, FRRangeResult, FRModeResult);
            }
            else if (TrackTemp != 0.0 && FrontLeftBox.SelectedItem != null)
            {
                ExecuteCalcs((Tyre)FrontLeftBox.SelectedItem, FLAvgResult, FLRangeResult, FLModeResult);
            }
        }


        //Checks tyre selection ensuring they are valid
        public void tyreCheck(ComboBox tyreBox1, ComboBox tyreBox2, ComboBox tyreBox3)
        {
            Tyre FLTyre = (Tyre) FrontLeftBox.SelectedItem;
            Tyre T1 = (Tyre)tyreBox1.SelectedItem;
            Tyre T2 = (Tyre)tyreBox2.SelectedItem;
            Tyre T3 = (Tyre)tyreBox3.SelectedItem;

            if (T1 != null || T2 != null || T3 != null)
            {
                if (FLTyre.Type != T1.Type)
                {
                    FRAverageResult.Text = "";
                    FRModeResult.Text = "";
                    FRRangeResult.Text = "";
                    FRAverageResult.BackColor = Color.White;
                    FRModeResult.BackColor = Color.White;
                    FRRangeResult.BackColor = Color.White;
                }
                if (FLTyre.Type != T2.Type)
                {
                    RLAverageResult.Text = "";
                    RLModeResult.Text = "";
                    RLRangeResult.Text = "";
                    RLAverageResult.BackColor = Color.White;
                    RLModeResult.BackColor = Color.White;
                    RLRangeResult.BackColor = Color.White;
                }
                if (FLTyre.Type != T3.Type)
                {
                    RRAverageResult.Text = "";
                    RRModeResult.Text = "";
                    RRRangeResult.Text = "";
                    RRAverageResult.BackColor = Color.White;
                    RRModeResult.BackColor = Color.White;
                    RRRangeResult.BackColor = Color.White;
                }
            }

        }
    }
}
