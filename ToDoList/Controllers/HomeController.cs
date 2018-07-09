using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public IActionResult Index()
        {
          // City newCity = new City();
          //  List<City> allItems = City.GetAll();
            return View(City.GetAll());
        }
        //

        // public ActionResult Index()
        // {
        //   return new EmptyResult();
        // }


    }
}
