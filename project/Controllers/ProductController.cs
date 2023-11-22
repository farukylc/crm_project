using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;
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

        

        public IActionResult CreateProductPage()
        {
            return View();
        }

        public ActionResult CreateProduct(int ProductID, string ProductName, int Price, float stars, int SalesAmount, string imgurl)
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
            };

            
            string jsonProduct = JsonConvert.SerializeObject(newProduct);

            
            using (HttpClient client = new HttpClient())
            {
                
                StringContent content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                
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

                    
                    return View(productDataList);
                }
                else
                {
                    return View();
                }
            }
        }
        
        public IActionResult UpdateProductPage()
        {
            return View();
        }
        public async Task<ActionResult> UpdateProduct(string updatedProductName, int updatedPrice, float updatedStars, int updatedSalesAmount, string updatedImgUrl)
        {
            string apiUrl = "https://localhost:7222/api/Product/1";

            Product updatedProduct = new Product
            {
                ProductName = updatedProductName,
                Price = updatedPrice,
                Stars = updatedStars,
                SalesAmount = updatedSalesAmount,
                imgUrl = updatedImgUrl,
            };

            // Serialize the updated product object to JSON
            string jsonUpdatedProduct = JsonConvert.SerializeObject(updatedProduct);

            // Use HttpClient to make a PUT request
            using (HttpClient client = new HttpClient())
            {
                // Create StringContent from the serialized JSON data
                StringContent content = new StringContent(jsonUpdatedProduct, Encoding.UTF8, "application/json");

                // Make the PUT request
                HttpResponseMessage response = await client.PutAsync(apiUrl, content);

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


        
        
    }
}
