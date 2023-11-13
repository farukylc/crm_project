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

}
