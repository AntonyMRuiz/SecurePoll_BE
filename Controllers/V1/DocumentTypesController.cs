﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Data;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DocumentTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DocumentTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DocumentTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentType>>> GetDocumentType()
        {
            return await _context.DocumentType.ToListAsync();
        }

        // GET: api/DocumentTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentType>> GetDocumentType(int id)
        {
            var documentType = await _context.DocumentType.FindAsync(id);

            if (documentType == null)
            {
                return NotFound();
            }

            return documentType;
        }

        // PUT: api/DocumentTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocumentType(int id, DocumentType documentType)
        {
            if (id != documentType.Id)
            {
                return BadRequest();
            }

            _context.Entry(documentType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentTypeExists(id))
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

        // POST: api/DocumentTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DocumentType>> PostDocumentType(DocumentType documentType)
        {
            _context.DocumentType.Add(documentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocumentType", new { id = documentType.Id }, documentType);
        }

        // DELETE: api/DocumentTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocumentType(int id)
        {
            var documentType = await _context.DocumentType.FindAsync(id);
            if (documentType == null)
            {
                return NotFound();
            }

            _context.DocumentType.Remove(documentType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocumentTypeExists(int id)
        {
            return _context.DocumentType.Any(e => e.Id == id);
        }
    }
}
