using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Data;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CandidatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Candidates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidates()
        {
            return await _context.Candidates
                .Include(p => p.User)
                .ThenInclude(p => p.DocumentType)
                .Include(p => p.User)
                .ThenInclude(p => p.Role)
                .Include(p => p.Election)
                    .ThenInclude(e => e.Owner)
                        .ThenInclude(o => o.DocumentType)  // Incluye DocumentType del Owner
                .Include(p => p.Election)
                    .ThenInclude(e => e.Owner)
                        .ThenInclude(o => o.Role)
                .ToListAsync();
        }

        // GET: api/Candidates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            var candidate = await _context.Candidates
                .Include(p => p.User)
                .ThenInclude(p => p.DocumentType)
                .Include(p => p.User)
                .ThenInclude(p => p.Role)
                .Include(p => p.Election)
                    .ThenInclude(e => e.Owner)
                        .ThenInclude(o => o.DocumentType)  // Incluye DocumentType del Owner
                .Include(p => p.Election)
                    .ThenInclude(e => e.Owner)
                        .ThenInclude(o => o.Role)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (candidate == null)
            {
                return NotFound();
            }

            return candidate;
        }

        // PUT: api/Candidates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidate(int id, Candidate candidate)
        {
            if (id != candidate.Id)
            {
                return BadRequest();
            }

            _context.Entry(candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Candidates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidate", new { id = candidate.Id }, candidate);
        }

        // DELETE: api/Candidates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidate(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CandidateExists(int id)
        {
            return _context.Candidates.Any(e => e.Id == id);
        }
    }
}
