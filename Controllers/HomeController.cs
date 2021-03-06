﻿using BookingService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Controllers
{
    public class HomeController : Controller
    {
        private DBContext db;

        public HomeController(DBContext context)
        {
            db = context;
            DbInitilazer.Initialize(db);
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {

            return View(await db.HousePosts.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string country, string city)
        {

            var houses = db.HousePosts.Where(house => house.City == city && house.Country == country);
            return View(await houses.ToListAsync());

        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddHouse(int postId)
        {

            User user = await db.Users.FirstOrDefaultAsync(u => u.Mail == User.Identity.Name);

            var house = await db.HousePosts.FirstOrDefaultAsync(u => u.HousePostId == postId);
            if (user != null && house != null)
            {

                db.Journals.Add(new GuestJournal { HousePost = house, LodgerId = user });

                await db.SaveChangesAsync();

            }

            return View("GetInfo",house);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetHistory()
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Mail == User.Identity.Name);
            var userHistoryList = db.Journals.Where(j => j.LodgerId.Id == user.Id).Select(h => h.HousePost).ToList();
          
            return View("GetHistory",userHistoryList);
        }

        [HttpPost]
        [Authorize]
        //TO DO Action for create new house post
        public async Task<IActionResult> AddNewHousePost(HousePost model)
        {
            if (ModelState.IsValid)
            {
                
            }
                return View("Home");
        }
        public async Task<IActionResult> AddNewHouse()
        {
            return View();
        }

         [HttpGet]
        [Authorize]
        public async Task<IActionResult> MyHouses()
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Mail == User.Identity.Name);
            var OwnerHistoryList = db.HousePosts.Where(j => j.User == user).ToList();
            return View(OwnerHistoryList);
        }
        public async Task<IActionResult> GetInfo(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var housepost = await db.HousePosts.FindAsync(id);
            if (housepost == null)
            {
                return NotFound();
            }
            return View(housepost);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
