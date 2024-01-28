﻿using _012.FruitsWebGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _012.FruitsWebGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static int rowsCount = 3;
        static int colsCount = 9;
        static string[,] fruits = GenerateRandomFruits();
        static int score = 0;
        static bool gameOver = false;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.rowsCount = rowsCount;
            ViewBag.colsCount = colsCount;
            ViewBag.fruits = fruits;
            ViewBag.score = score;
            ViewBag.gameOver = gameOver;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static string[,] GenerateRandomFruits()
        {
            var rand = new Random();

            fruits = new string[rowsCount, colsCount];
            
            for(var row = 0; row < rowsCount; row++)
            {
                for(var col = 0; col < colsCount; col++)
                {
                    var r = rand.Next(9);

                    if (r < 2)
                        fruits[row, col] = "apple";
                    else if (r < 4)
                        fruits[row, col] = "banana";
                    else if (r < 6)
                        fruits[row, col] = "orange";
                    else if (r < 8)
                        fruits[row, col] = "kiwi";
                    else
                        fruits[row, col] = "dynamite";
                }
            }

            return fruits;
        }
    }
}
