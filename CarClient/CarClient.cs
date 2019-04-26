using CarClient.Model;
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
        private string baseURI = "http://my-json-server.typicode.com/RubenLauro/CarClientWorkshop/";
        private RestClient restClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void PrintErrorMessage()
        {
            listBoxCars.Items.Add("Error connecting to the RESTful service.");
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            restClient = new RestClient(baseURI + "cars");

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                List<Car> cars = jSer.Deserialize<List<Car>>(response.Content.ToString());

                foreach (Car car in cars)
                {
                    listBoxCars.Items.Add(car.brand + " " + car.model);
                }
            }
            else
            {
                PrintErrorMessage();
            }
        }

        private void ListBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int carId = listBoxCars.SelectedIndex+1;

            restClient = new RestClient(baseURI + "cars/" + carId);

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                Car car = jSer.Deserialize<Car>(response.Content.ToString());

                carImage.ImageLocation = car.image;
                lblBrand.Text = car.brand;
                lblModel.Text = car.model;
                lblVersion.Text = car.version;
                lblEngine.Text = car.engine;
                lblHorsePower.Text = car.horsepower;
                lblFuel.Text = car.fuel;
                lblPrice.Text = int.Parse(car.price).ToString("C");
            }
            else
            {
                PrintErrorMessage();
            }
        }
    }
}
