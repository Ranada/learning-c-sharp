using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookstoreApp.API.Data;
using BookstoreApp.API.Models.Author;
using AutoMapper;
using BookstoreApp.API.Static;
using Microsoft.AspNetCore.Authorization;

namespace BookstoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public AuthorsController(BookStoreDbContext context, IMapper mapper, ILogger<AuthorsController> logger)
        {
            _context = context;
            this._mapper = mapper;
            this._logger = logger;
        }

        // GET: api/Authors
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<AuthorReadOnlyDto>>> GetAuthors()
        {
            _logger.LogInformation($"Request made to {nameof(GetAuthors)}");
            try
            { 
                var authors = await _context.Authors.ToListAsync();
                var authorsDto = _mapper.Map<IEnumerable<AuthorReadOnlyDto>>(authors);
                return Ok(authorsDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Oh snap! You got an error during {nameof(GetAuthors)}");
                return StatusCode(500, Messages.ErrorMessage500);
            }
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<AuthorReadOnlyDto>> GetAuthor(int id)
        {
            _logger.LogInformation($"Request made to {nameof(GetAuthor)}");
            try
            {
                var author = await _context.Authors.FindAsync(id);

                if (author == null)
                {
                    return NotFound();
                }

                var authorDto = _mapper.Map<AuthorReadOnlyDto>(author);
                return Ok(authorDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Oh snap! You got an error during {nameof(GetAuthor)}");
                return StatusCode(500, Messages.ErrorMessage500);
            }
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutAuthor(int id, AuthorUpdateDto authorUpdateDto)
        {
            if (id != authorUpdateDto.Id)
            {
                _logger.LogWarning($"Oh snap! You got an error during {nameof(PutAuthor)} -> Parameter Id-{id} does not match Author Id-{authorUpdateDto.Id}");
                return BadRequest();
            }

            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                _logger.LogWarning($"Oh snap! You got an error during {nameof(PutAuthor)} -> Author data does not exist.");
                return NotFound();
            }

            _mapper.Map(authorUpdateDto, author);
            _context.Entry(author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
                {
                    _logger.LogWarning($"Oh snap! You got an error during {nameof(PutAuthor)} -> Could not find Id: {id}");
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Authors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<AuthorCreateDto>> PostAuthor(AuthorCreateDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            if (_context.Authors == null)
            {
                return NotFound();
            }
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthorExists(int id)
        {
            return (_context.Authors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
