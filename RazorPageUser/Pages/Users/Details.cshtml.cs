using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageUser.Data;
using RazorPageUser.Models;

namespace RazorPageUser.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageUser.Data.RazorPageUserContext _context;

        public DetailsModel(RazorPageUser.Data.RazorPageUserContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserId == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
