﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookList_v1.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Books.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }
    }
}