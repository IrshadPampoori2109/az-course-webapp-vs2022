using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using az_course_webapp_vs2022.Data;

namespace az_course_webapp_vs2022.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly az_course_webapp_vs2022.Data.AppDbContext _context;

        public IndexModel(az_course_webapp_vs2022.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
