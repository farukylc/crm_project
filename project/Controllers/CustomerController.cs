using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Models;

namespace project.Controllers;

public class CustomerController: Controller
{
    
    public async Task<ActionResult> Index()
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://localhost:7222/api/Customer";

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

                var customerDataList = JsonConvert.DeserializeObject<List<Customer>>(data).ToList();

                return View(customerDataList);
            }
            else
            {
                return View();
            }
        }
    }

    public ActionResult DeleteOneBook(int id)
    {
        
        string apiUrl = "https://localhost:7222/api/Customer/";

        using (HttpClient client = new HttpClient())
        {
            string deleteUrl = apiUrl + id.ToString();
            HttpResponseMessage response = client.DeleteAsync(deleteUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                return RedirectToAction("Index", "Customer");
            }
        }
    }

    public ActionResult GetProfile(int id)
    {
        string apiUrl = "https://localhost:7222/api/Customer/";
        using (HttpClient client = new HttpClient())
        {
            string profileUrl = apiUrl + id.ToString();
            HttpResponseMessage response = client.GetAsync(profileUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseData = response.Content.ReadAsStringAsync().Result;
                var customerProfile = JsonConvert.DeserializeObject<Customer>(responseData);
                
                
                return View("Profile", new List<Customer> { customerProfile });
            }
            else
            {
                return RedirectToAction("Index", "Customer");
            }
        }
    }

    public IActionResult CreateCustomerPage()
    {
        return View();
    }

    public ActionResult CreateCustomer(int CustomerID, string Name, string Surname, string Email, DateTime DateOfBirth, string Address, string PhoneNumber)
    {
      string apiUrl = "https://localhost:7222/api/Customer/";

        // Create a new Customer object with the provided data
        Customer newCustomer = new Customer
        {
            CustomerID = CustomerID,
            Name = Name,
            Surname = Surname,
            Email = Email,
            DateOfBirth = DateOfBirth,
            Address = Address,
            PhoneNumber = PhoneNumber
        };

        // Serialize the customer object to JSON
        string jsonCustomer = JsonConvert.SerializeObject(newCustomer);

        // Use HttpClient to make a POST request
        using (HttpClient client = new HttpClient())
        {
            // Create StringContent from the serialized JSON data
            StringContent content = new StringContent(jsonCustomer, Encoding.UTF8, "application/json");

            // Make the POST request
            HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

            // Check if the request was successful (HTTP status code 2xx)
            if (response.IsSuccessStatusCode)
            { 
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                return RedirectToAction("Index", "Customer");
            }
        }
   
}

    

    

}
