using Degradation_Calculator.Types.OpenWeather;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace Degradation_Calculator
{
    public partial class Form1 : Form
    {
        private const string OPENWEATHERAPPID = "";
        List<Tyre> Tyres = new List<Tyre>();
        List<Tyre> FilteredTyreListType = new List<Tyre>();
        List<Track> Tracks = new List<Track>();
        List<int> TrackDegridationPoints = new List<int>();
        List<int> DegradationResults = new List<int>();

        double TrackTemp = 0.0;

        Track SelectedTrack;

        public Form1()
        {
            InitializeComponent();
            LoadTyres();
            LoadTracks();
            ClearResultText();

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
        public void LoadTyres()
        {
            var tyreXMLFile = FileLoader.LoadXml("TyresXML.xml"); // Loads XML File

            foreach (XmlNode node in tyreXMLFile.DocumentElement) //ForEach XML element in document
            {
                var name = node["Name"].InnerText;
                var family = node["Family"].InnerText;
                var type = node["Type"].InnerText;
                var placement = node["Placement"].Value;
                var degradationcoefficient = double.Parse(node["DegradationCoefficient"].InnerText);

                var tyre = new Tyre(name, family, type, placement, degradationcoefficient);

                Tyres.Add(tyre); //Adds the new tyre object to tyre list

                FrontLeftBox.Items.Add(tyre); //Adds the new tyre object to combo box
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
        public void LoadTracks()
        {
            var lines = FileLoader.LoadText("TrackDegradationCoefficients.txt").Split('\n').ToList();

            foreach (var line in lines)
            {
                var tracks = line.Split('|').ToList();

                var track = new Track(tracks[0], tracks[1], tracks[2]);

                Tracks.Add(track);

                TrackBox.Items.Add(track);
            }

        }

        public void FrontLeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrackBox.SelectedItem == null)
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message

            ValidateTyreSelection();

            //clears tyres from list allowing addition of new filtered tyres
            RearLeftBox.Items.Clear();
            FrontRightBox.Items.Clear();
            RearRightBox.Items.Clear();

            var frontLeftTyre = (Tyre)FrontLeftBox.SelectedItem; //Casts selected item to tyre type 

            //Filters tyre list by type, ensuring all tyres are of same type
            FilteredTyreListType = Tyres
                .Where(t => t.Type == frontLeftTyre.Type)
                .ToList();

            // Filters tyre listby family, ensures front tyres are of same family and type
            var filteredTyreListFamily = FilteredTyreListType
                .Where(t => t.Family == frontLeftTyre.Family)
                .ToList(); 


            foreach (Tyre tyre in filteredTyreListFamily)
            {
                FrontRightBox.Items.Add(tyre); // Addds filtered tyres to combo box (dropdown)
            }

            foreach (Tyre tyre in FilteredTyreListType)
            {
                RearLeftBox.Items.Add(tyre); // Addds filtered tyres to combo box (dropdown)
            }
       
            ExecuteCalcs(frontLeftTyre, FLAvgResult, FLRangeResult, FLModeResult); //Executes calculation for front left tyre
           
            //Enables combobox selection as filtered tyres added to combobox 
            ComboBoxSelectionControl(FrontRightBox);
            ComboBoxSelectionControl(RearLeftBox);

        }

        private void FrontRightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrackBox.SelectedItem == null)
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message

            var frontRightTyre = (Tyre)FrontRightBox.SelectedItem; //Casts selected item to tyre type 
            ExecuteCalcs(frontRightTyre, FRAverageResult, FRRangeResult, FRModeResult); //Executes calculation for front right tyre
            
        }

        private void RearLeftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrackBox.SelectedItem == null)
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message

            var rearLeftTyre = (Tyre)RearLeftBox.SelectedItem; //Casts selected item to tyre type  

            //filters list by family, ensuring back tyres are of same family and type
            var rightTyreList = FilteredTyreListType
                .Where(t => t.Family == rearLeftTyre.Family)
                .ToList(); 

            foreach (Tyre tyre in rightTyreList)
            {
                RearRightBox.Items.Add(tyre); // Addds filtered tyres to combo box (dropdown)
            }

            ExecuteCalcs(rearLeftTyre, RLAverageResult, RLRangeResult, RLModeResult); //Executes calculation for rear left tyre
            
            ComboBoxSelectionControl(RearRightBox); //Enables combobox selection as filtered tyres added to combobox
        }

        private void RearRightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TrackBox.SelectedItem == null)
                MessageBox.Show("Track Must Be Selected, Please Select a Track", "Track Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Track selection error message

            var rearRightTyre = (Tyre)RearRightBox.SelectedItem; //Casts selected item to tyre type 
            ExecuteCalcs(rearRightTyre, RRAverageResult, RRRangeResult, RRModeResult); //Executes calculation for rear right tyre
           
        }

        private void TrackBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTrack = (Track)TrackBox.SelectedItem; //Casts selected item to tyre type 

            TrackDegridationPoints.Clear();

            //Converts Track degragation point from string to list<int> to allow for use in formula
            List<string> DegPoints = SelectedTrack.DegragationPoint.Split(',').ToList(); //splits string and stores values in list<string>

            foreach (string D in DegPoints)
            {
                int ConvertedPoint = Convert.ToInt32(D); //Converts string values in list<string> to int

                TrackDegridationPoints.Add(ConvertedPoint); //Adds converted deg point to TrackDegPoints list<int>
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

            using (var web = new WebClient())
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
            using (var web = new WebClient())
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
        public void CalculateDegradation(Tyre tyre, Track track)
        {
            var tyreType = tyre.Type;
            var tyreDegCoe = tyre.DegradationCoefficient;

            //Check type of tyre and applies percentage to tyre degregation coefficient 
            if (tyreType == "SuperSoft" || tyreType == "Soft")
            {
                tyreDegCoe = tyreDegCoe - (tyreDegCoe * 0.8);
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
            foreach (double degPoint in TrackDegridationPoints)
            {
                int DegResult = Convert.ToInt32((degPoint * TrackTemp) / tyreDegCoe);
                DegradationResults.Add(DegResult);
            }
        }



        //Calculates average of DegResults list 
        public void AverageCalc(Label averagelbl)
        {
            var average = Convert.ToInt32(DegradationResults.Average());

            averagelbl.Text = average.ToString();

            ColourLegend(average, averagelbl);
        }



        //Calculates mode of DegResults list 
        public void ModeCalc(Label modelbl)
        {
            var mode = DegradationResults.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            modelbl.Text = mode.ToString();

            ColourLegend(mode, modelbl);
        }

        //Calculates range of DegResults list 
        public void RangeCalc(Label rangelbl)
        {
            var range = DegradationResults.Max() - DegradationResults.Min();

            rangelbl.Text = range.ToString();

            ColourLegend(range, rangelbl);
        }

        //Calculates tyre point degragation, average, mode, range displaying results 
        public void ExecuteCalcs(Tyre tyre, Label averageLbl, Label rangeLbl, Label modeLbl)
        {
            DegradationResults.Clear();
            CalculateDegradation(tyre, SelectedTrack);
            AverageCalc(averageLbl);
            RangeCalc(rangeLbl);
            ModeCalc(modeLbl);
        }

        //Colour legend for result average, mode and range values
        public void ColourLegend(int results, Label resultsLbl)
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
        public void ValidateTyreSelection()
        {
            var frontLeftTyre = (Tyre)FrontLeftBox.SelectedItem;
            var frontRightTyre = (Tyre)FrontRightBox.SelectedItem;
            var rearLeftTyre = (Tyre)RearLeftBox.SelectedItem;
            var rearRightTyre = (Tyre)RearRightBox.SelectedItem;

            if (frontRightTyre != null || rearLeftTyre != null || rearRightTyre != null)
            {
                if (frontLeftTyre.Type != frontRightTyre.Type)
                {
                    FRAverageResult.Text = "";
                    FRModeResult.Text = "";
                    FRRangeResult.Text = "";
                    FRAverageResult.BackColor = Color.White;
                    FRModeResult.BackColor = Color.White;
                    FRRangeResult.BackColor = Color.White;
                }
                if (frontLeftTyre.Type != rearLeftTyre.Type)
                {
                    RLAverageResult.Text = "";
                    RLModeResult.Text = "";
                    RLRangeResult.Text = "";
                    RLAverageResult.BackColor = Color.White;
                    RLModeResult.BackColor = Color.White;
                    RLRangeResult.BackColor = Color.White;
                }
                if (frontLeftTyre.Type != rearRightTyre.Type)
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
