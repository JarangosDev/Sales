using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.API.Helpers;
using Sales.Shared.DTOs;
using Sales.Shared.Entities;

namespace Sales.API.Controllers
{
    [ApiController]
    [Route("/api/prodcategories")]
    public class ProdCategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public ProdCategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] PaginationDTO pagination)
        {
            var queryable = _context.ProdCategories
                .Include(x => x.Products)
                .Where(x => x.Categories!.Id == pagination.Id)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Name.ToLower().Contains(pagination.Filter.ToLower()));
            }


            return Ok(await queryable
                .OrderBy(x => x.Name)
                .Paginate(pagination)
                .ToListAsync());
        }

        [HttpGet("totalPages")]
        public async Task<ActionResult> GetPages([FromQuery] PaginationDTO pagination)
        {
            var queryable = _context.ProdCategories
                .Where(x => x.Categories!.Id == pagination.Id)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(pagination.Filter))
            {
                queryable = queryable.Where(x => x.Name.ToLower().Contains(pagination.Filter.ToLower()));
            }


            double count = await queryable.CountAsync();
            double totalPages = Math.Ceiling(count / pagination.RecordsNumber);
            return Ok(totalPages);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var prodCategories = await _context.ProdCategories
                .Include(x => x.Products)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (prodCategories == null)
            {
                return NotFound();
            }

            return Ok(prodCategories);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(ProdCategory prodCategories)
        {
            try
            {
                _context.Add(prodCategories);
                await _context.SaveChangesAsync();
                return Ok(prodCategories);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una ProdCategories con el mismo nombre.");
                }

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(ProdCategory prodCategories)
        {
            try
            {
                _context.Update(prodCategories);
                await _context.SaveChangesAsync();
                return Ok(prodCategories);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una categoría con el mismo nombre.");
                }

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var prodCategories = await _context.States.FirstOrDefaultAsync(x => x.Id == id);
            if (prodCategories == null)
            {
                return NotFound();
            }

            _context.Remove(prodCategories);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
