using Microsoft.AspNetCore.Mvc;
using Tomagatchi.Models;
using System.Collections.Generic;
using System;

namespace Tomagatchi.Controllers
{
    public class TomagatchiController: Controller
    {
        [HttpGet("/tomagatchi/index")]
        public ActionResult Index()
        {
            
            return View(TomagatchiPlayer.Instance);
        }
        [HttpPost("/tomagatchi/new")]
        public ActionResult Index(string aName)
        {
            TomagatchiPlayer.Instance = new TomagatchiPlayer(aName);
            return View(TomagatchiPlayer.Instance);
        }
    }
}