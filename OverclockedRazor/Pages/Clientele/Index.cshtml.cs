using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OverclockedRazor.Data;

namespace OverclockedRazor.Pages.Clientele
{
    public class IndexModel : PageModel
    {
        private readonly OverclockedRazor.Data.Context _context;

        public IndexModel(OverclockedRazor.Data.Context context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Clients.ToListAsync();
        }
    }
}
