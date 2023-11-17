using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebApi.Models;

public class CommentController : Controller
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

    public ActionResult DeleteOneComment(int id)
    {
        string apiUrl = "https://localhost:7222/api/Comment/";

        using (HttpClient client = new HttpClient())
        {
            string deleteUrl = apiUrl + id.ToString();
            HttpResponseMessage response = client.DeleteAsync(deleteUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Comment");
            }
            else
            {
                return RedirectToAction("Index", "Comment");
            }
        }
    }
}
