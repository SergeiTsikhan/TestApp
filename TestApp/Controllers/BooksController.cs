using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;
using TestApp.Data;
using TestApp.Filter;
using TestApp.Helpers;
using TestApp.Services;
using TestApp.Wrappers;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BooksContext _context;
        private readonly IUriService _uriService;

        private readonly ILogger<BooksController> _logger;


        public BooksController(BooksContext context, ILogger<BooksController> logger, IUriService uriService)
        {
            _context = context;
            _logger = logger;
            _uriService = uriService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll( string? ageFilter, [FromQuery] PaginationFilter filter)
        {

            var route = Request.Path.Value;

            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);

            var pagedData = await _context.Authors.ToListAsync();

            var totalRecords = await _context.Authors.AsNoTracking().CountAsync();

            if (ageFilter == null)
            {
                 pagedData = await _context.Authors
                 .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                 .Take(validFilter.PageSize)
                 .ToListAsync();
            }
            else
            {
                if (Int32.TryParse(ageFilter, out int val))
                {
                    pagedData = await _context.Authors
                   .Where(n => n.Age > val)
                   .ToListAsync();
                    totalRecords = pagedData.Count;
                    validFilter = new PaginationFilter();
                }
            }

            var pagedReponse = PaginationHelper.CreatePagedReponse(pagedData, validFilter, totalRecords, _uriService, route);

            return Ok(pagedReponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await _context.Authors
                .Where(a => a.Id == id)
                .Include(n => n.Books)
                .FirstOrDefaultAsync();
            return Ok(new Response<Author>(author));
        }
    }
}