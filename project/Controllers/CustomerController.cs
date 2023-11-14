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

    

    

}
