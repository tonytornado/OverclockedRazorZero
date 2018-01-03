using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OverclockedRazor.Data;
using Microsoft.EntityFrameworkCore;

namespace OverclockedRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Context _db;

        public IndexModel(Context db)
        {
            _db = db;
        }

        public IList<Client> Clients { get; private set; }

        public async Task OnGetAsync(int ID)
        {
            Clients = await _db.Clients.AsNoTracking().ToListAsync();
        }
    }
}
