using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using MySql.Data.MySqlClient;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        [HttpGet("/items")]
        public ActionResult Index()
        {
         return View(City.GetAll());
        }

        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        // [HttpPost("/items")]
        // public ActionResult Create()
        // {
        // //  Item newItem = new Item (Request.Form["new-item"]);
        //   //newItem.Save();
        //   List<Item> allItems = Item.GetAll();
        //   return View("Index", allItems);
        // }

        // [HttpPost("/items/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Item.ClearAll();
        //     return View();
        // }

    }
}
