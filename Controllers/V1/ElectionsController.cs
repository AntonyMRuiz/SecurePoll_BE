﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Data;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ElectionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ElectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Elections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Election>>> GetElections()
        {
            return await _context.Elections.Include(p => p.Owner)
                .ThenInclude(o => o.DocumentType)  
                .Include(p => p.Owner)
                .ThenInclude(o => o.Role)
                .ToListAsync();
        }

        // GET: api/Elections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Election>> GetElection(int id)
        {
            var election = await _context.Elections
                .Include(p => p.Owner)
                .ThenInclude(o => o.DocumentType)  
                .Include(p => p.Owner)
                .ThenInclude(o => o.Role)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (election == null)
            {
                return NotFound();
            }

            return election;
        }

        // PUT: api/Elections/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElection(int id, Election election)
        {
            if (id != election.Id)
            {
                return BadRequest();
            }

            _context.Entry(election).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElectionExists(id))
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

        // POST: api/Elections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Election>> PostElection(Election election)
        {
            _context.Elections.Add(election);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElection", new { id = election.Id }, election);
        }

        // DELETE: api/Elections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElection(int id)
        {
            var election = await _context.Elections.FindAsync(id);
            if (election == null)
            {
                return NotFound();
            }

            _context.Elections.Remove(election);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElectionExists(int id)
        {
            return _context.Elections.Any(e => e.Id == id);
        }
    }
}
