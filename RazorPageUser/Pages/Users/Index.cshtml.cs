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
    public class IndexModel : PageModel
    {
        private readonly RazorPageUser.Data.RazorPageUserContext _context;

        public IndexModel(RazorPageUser.Data.RazorPageUserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
