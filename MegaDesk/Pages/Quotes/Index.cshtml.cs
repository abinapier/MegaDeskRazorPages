using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDesk.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskContext _context;

        public IndexModel(MegaDeskContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }

        public IList<Quote> Quote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string QuoteName { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            DateSort = String.IsNullOrEmpty(sortOrder) ? "Date" : "";
            NameSort = sortOrder == "Name" ? "name_desc" : "Name";


            IQueryable<Quote> quotes = from s in _context.Quote
                                       select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.Name.Contains(SearchString));
            }



            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderByDescending(i => i.Name);
                    break;
                case "Name":
                    quotes = quotes.OrderBy(i => i.Name);
                    break;
                case "Date":
                    quotes = quotes.OrderBy(i => i.DateAdded);
                    break;
                default:
                    quotes = quotes.OrderByDescending(i => i.DateAdded);
                    break;
            }

            Quote = await quotes.AsNoTracking().ToListAsync();
        }
    }


}

