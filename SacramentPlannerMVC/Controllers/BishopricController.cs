using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlannerMVC.Data;
using SacramentPlannerMVC.Models;

namespace SacramentPlannerMVC.Controllers
{
    public class BishopricController : Controller
    {
        private readonly SacramentContext _context;

        public BishopricController(SacramentContext context)
        {
            _context = context;
        }

        // GET: Bishopric
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bishopric.ToListAsync());
        }

        // GET: Bishopric/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bishopric = await _context.Bishopric
                .SingleOrDefaultAsync(m => m.ID == id);
            if (bishopric == null)
            {
                return NotFound();
            }

            return View(bishopric);
        }

        // GET: Bishopric/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bishopric/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,IsActive")] Bishopric bishopric)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bishopric);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bishopric);
        }

        // GET: Bishopric/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bishopric = await _context.Bishopric.SingleOrDefaultAsync(m => m.ID == id);
            if (bishopric == null)
            {
                return NotFound();
            }
            return View(bishopric);
        }

        // POST: Bishopric/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,IsActive")] Bishopric bishopric)
        {
            if (id != bishopric.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bishopric);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BishopricExists(bishopric.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bishopric);
        }

        // GET: Bishopric/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bishopric = await _context.Bishopric
                .SingleOrDefaultAsync(m => m.ID == id);
            if (bishopric == null)
            {
                return NotFound();
            }

            return View(bishopric);
        }

        // POST: Bishopric/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bishopric = await _context.Bishopric.SingleOrDefaultAsync(m => m.ID == id);
            _context.Bishopric.Remove(bishopric);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BishopricExists(int id)
        {
            return _context.Bishopric.Any(e => e.ID == id);
        }
    }
}
