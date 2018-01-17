using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OverclockedRazor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace OverclockedRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Context _db;
        public string Message { get; set; }

        public IndexModel(Context db)
        {
            _db = db;
        }
        
        public IList<Newsletter> Newsletters { get; private set; }

        [BindProperty]
        public Newsletter Newsletter { get; set; }

        public async Task OnGetAsync(int ID)
        {
            Newsletters = await _db.Newsletters.AsNoTracking().ToListAsync();
        }

        public async Task OnPostAsync(int ID)
        {
            Newsletters = await _db.Newsletters.AsNoTracking().ToListAsync();
            Message = "We've got you subscribed. You'll be hearing from us soon.";
        }

    }
}
