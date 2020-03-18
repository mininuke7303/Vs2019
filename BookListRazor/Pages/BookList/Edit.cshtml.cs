﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookListRazor.Model;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor {
    public class EditModel : PageModel {

        private readonly ApplicationDbContext _db;


        public EditModel(ApplicationDbContext db) {
            _db = db;
        }


        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id) {
            Book = await _db.Book.FindAsync(id);
        }
    }
}