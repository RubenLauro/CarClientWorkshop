using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CarClient
{
    public partial class Form1 : Form
    {
        string baseURI = "http://localhost:59227/api/";
        RestClient restClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpecificParkDetails_Click(object sender, EventArgs e)
        {
            //var parkID = GetParkIdFromCombobox();
            ///api/parks/{id} 
            restClient = new RestClient(baseURI + "parks/" + parkID);

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                /*
                Park park = jSer.Deserialize<Park>(response.Content.ToString());
                richTextBox.AppendText(parkID);
                richTextBox.AppendText("\nDescription : " + park.Description);
                richTextBox.AppendText("\nNumber of Spots : " + park.NumberOfSpots);
                richTextBox.AppendText("\nOperating Hours : " + park.OperatingHours);
                richTextBox.AppendText("\nNumber of Special Spots : " + park.NumberOfSpecialSpots);
                richTextBox.AppendText("\nTimestamp : " + park.Timestamp);
                richTextBox.AppendText("\nGeoLocation File: " + park.GeoLocationFile + "\n\n");
                */
            }
            else
            {
                PrintErrorMessage(response.StatusCode);
            }

        }
        private void PrintErrorMessage(HttpStatusCode statusCode)
        {
            if (statusCode == HttpStatusCode.NotFound)
            {
                //richTextBox.AppendText("No record(s) found. \n");
            }
            else
            {
                //richTextBox.AppendText("Error connecting to the RESTful service. \n");
            }
        }
    }
}
