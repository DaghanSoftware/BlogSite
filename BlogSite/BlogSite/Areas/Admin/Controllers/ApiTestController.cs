using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class ApiTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44301/api/Default");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }


        public IActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWriter(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonWriter = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonWriter, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44301/api/Default", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditWriter(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44301/api/Default/"+ id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonEmployee = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonEmployee);
                return View(values);
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult> EditWriter(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonWriter = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonWriter, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:44301/api/Default/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
            
        }

        public async Task<IActionResult> DeleteWriter(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:44301/api/Default/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
    public class Class1
    {
        public int WriterID { get; set; }

        public string WriterName { get; set; }

        public string WriterAbout { get; set; }

        public string WriterImage { get; set; }

        public string WriterMail { get; set; }

        public string WriterPassword { get; set; }

        public bool WriterStatus { get; set; }
    }
}
