using CarClient.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Car> cars;

        public Form1()
        {
            InitializeComponent();
            /*
            comboBoxOrderHp.SelectedIndex = 2;
            comboBoxModelOrder.SelectedIndex = 2;
            comboBoxBrand.SelectedIndex = 0;
            */
            comboBoxHorsePowerOrder.SelectedIndex = 0;
            comboBoxModelOrderTab.SelectedIndex = 0;
        }

        private void PrintErrorMessage()
        {
            listBoxCars.Items.Add("Error connecting to the RESTful service.");
        }

        private void ListBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int carId = listBoxCars.SelectedIndex;

            Car selectedCar = cars[carId];

            restClient = new RestClient(baseURI + "cars/" + selectedCar.id);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            restClient = new RestClient(baseURI + "cars");

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                cars = jSer.Deserialize<List<Car>>(response.Content.ToString());
                listBoxCars.Items.Clear();
                foreach (Car car in cars)
                {
                    listBoxCars.Items.Add(car.brand + " " + car.model);

                    if (!comboBoxBrands.Items.Contains(car.brand))
                    {
                        comboBoxBrands.Items.Add(car.brand);
                    }
                }
            }
            else
            {
                PrintErrorMessage();
            }
        }

        /*
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxOrderHp.SelectedItem != null && comboBoxOrderHp.SelectedItem.Equals("Ascending"))
            {
                restClient = new RestClient(baseURI + "cars?_sort=horsepower&_order=asc");
            }
            else if(comboBoxOrderHp.SelectedItem != null && comboBoxOrderHp.SelectedItem.Equals("Descending"))
            {
                restClient = new RestClient(baseURI + "cars?_sort=horsepower&_order=desc");
            }
            else if (comboBoxBrand.SelectedItem != null && comboBoxModelOrder.SelectedItem != null && comboBoxModelOrder.SelectedItem.Equals("Ascending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrand.SelectedItem.ToString()}&_sort=model&_order=asc");
            }
            else if (comboBoxBrand.SelectedItem != null && comboBoxModelOrder.SelectedItem != null && comboBoxModelOrder.SelectedItem.Equals("Descending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrand.SelectedItem.ToString()}&_sort=model&_order=desc");
            }
            
            else if (comboBoxBrand.SelectedItem != null && comboBoxOrderHp.SelectedItem != null && comboBoxOrderHp.SelectedItem.Equals("Ascending") && comboBoxModelOrder.SelectedItem.Equals("Descending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrand.SelectedItem.ToString()}&_sort=horsepower,model&_order=asc,desc");
            }
            else if (comboBoxBrand.SelectedItem != null && comboBoxOrderHp.SelectedItem != null && comboBoxOrderHp.SelectedItem.Equals("Ascending") && comboBoxModelOrder.SelectedItem.Equals("Ascending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrand.SelectedItem.ToString()}&_sort=horsepower,model&_order=asc,asc");
            }
            else if (comboBoxBrand.SelectedItem != null && comboBoxOrderHp.SelectedItem != null && comboBoxOrderHp.SelectedItem.Equals("Descending") && comboBoxModelOrder.SelectedItem.Equals("Descending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrand.SelectedItem.ToString()}&_sort=horsepower,model&_order=desc,desc");
            }
            else if (comboBoxBrand.SelectedItem != null && comboBoxOrderHp.SelectedItem != null && comboBoxOrderHp.SelectedItem.Equals("Descending") && comboBoxModelOrder.SelectedItem.Equals("Ascending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrand.SelectedItem.ToString()}&_sort=horsepower,model&_order=desc,asc");
            }
            

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                cars = jSer.Deserialize<List<Car>>(response.Content.ToString());
                listBoxCars.Items.Clear();
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

        */

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
                cars = jSer.Deserialize<List<Car>>(response.Content.ToString());
                listBoxCars.Items.Clear();
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

        private void BtnFilterHorsePower_Click(object sender, EventArgs e)
        {
            if (comboBoxHorsePowerOrder.SelectedItem != null && comboBoxHorsePowerOrder.SelectedItem.Equals("Ascending"))
            {
                restClient = new RestClient(baseURI + "cars?_sort=horsepower&_order=asc");
            }
            else if (comboBoxHorsePowerOrder.SelectedItem != null && comboBoxHorsePowerOrder.SelectedItem.Equals("Descending"))
            {
                restClient = new RestClient(baseURI + "cars?_sort=horsepower&_order=desc");
            }

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                cars = jSer.Deserialize<List<Car>>(response.Content.ToString());
                listBoxCars.Items.Clear();
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

        private void BtnBrandFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxBrands.SelectedItem != null && comboBoxModelOrderTab.SelectedItem != null && comboBoxModelOrderTab.SelectedItem.Equals("Ascending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrands.SelectedItem.ToString()}&_sort=model&_order=asc");
            }
            else if (comboBoxBrands.SelectedItem != null && comboBoxModelOrderTab.SelectedItem != null && comboBoxModelOrderTab.SelectedItem.Equals("Descending"))
            {
                restClient = new RestClient(baseURI + $"cars?brand={comboBoxBrands.SelectedItem.ToString()}&_sort=model&_order=desc");
            }

            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");

            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer jSer = new JavaScriptSerializer();
                cars = jSer.Deserialize<List<Car>>(response.Content.ToString());
                listBoxCars.Items.Clear();
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
        }
}
