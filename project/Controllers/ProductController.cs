using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using WebApi.Models;

namespace project.Controllers
{
    public class ProductController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://localhost:7222/api/Product";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();

                    var productDataList = JsonConvert.DeserializeObject<List<Product>>(data).ToList();

                    return View(productDataList);
                }
                else
                {
                    return View();
                }
            }
        }

        public ActionResult DeleteOneProduct(int id)
        {
            string apiUrl = "https://localhost:7222/api/Product/";

            using (HttpClient client = new HttpClient())
            {
                string deleteUrl = apiUrl + id.ToString();
                HttpResponseMessage response = client.DeleteAsync(deleteUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    return RedirectToAction("Index", "Product");
                }
            }
        }

        public ActionResult GetProfile(int id)
        {
            string apiUrl = "https://localhost:7222/api/Product/";

            using (HttpClient client = new HttpClient())
            {
                string profileUrl = apiUrl + id.ToString();
                HttpResponseMessage response = client.GetAsync(profileUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result;
                    var productProfile = JsonConvert.DeserializeObject<Product>(responseData);

                    return View("Profile", new List<Product> { productProfile });
                }
                else
                {
                    return RedirectToAction("Index", "Product");
                }
            }
        }

        public IActionResult CreateProductPage()
        {
            return View();
        }

        public ActionResult CreateProduct(int ProductID, string ProductName, int Price, float stars, int SalesAmount, string imgurl, string category)
        {
            string apiUrl = "https://localhost:7222/api/Product/";

            
            Product newProduct = new Product
            {
                ProductID = ProductID,
                ProductName = ProductName,
                Price = Price,
                Stars =  stars,
                SalesAmount = SalesAmount,
                imgUrl = imgurl,
                Category = category
            };

            // Serialize the product object to JSON
            string jsonProduct = JsonConvert.SerializeObject(newProduct);

            // Use HttpClient to make a POST request
            using (HttpClient client = new HttpClient())
            {
                // Create StringContent from the serialized JSON data
                StringContent content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                // Make the POST request
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                // Check if the request was successful (HTTP status code 2xx)
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    return RedirectToAction("Index", "Product");
                }
            }
        }

        public async Task<ActionResult> Chart()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://localhost:7222/api/Product";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();

                    var productDataList = JsonConvert.DeserializeObject<List<Product>>(data).ToList();

                    // Pass the data to the view
                    return View(productDataList);
                }
                else
                {
                    return View();
                }
            }
        }
        
        }
        
        
    }

