using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Models;

namespace project.Controllers;

public class CommentController: Controller
{
    
    public async Task<ActionResult> Index()
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://localhost:7222/api/Comment";

            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

                var commentDataList = JsonConvert.DeserializeObject<List<Comment>>(data).ToList();

                return View(commentDataList);
            }
            else
            {
                return View();
            }
        }
    }
    
   
}

    

    


