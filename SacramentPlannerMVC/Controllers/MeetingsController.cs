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
    public class MeetingsController : Controller
    {
        private readonly SacramentContext _context;

        public MeetingsController(SacramentContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            var sacramentContext = _context.Meetings.Include(m => m.Conductor).Include(m => m.Hymn);
            return View(await sacramentContext.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.Conductor)
                .Include(m => m.Hymn)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "FullName");
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Date,OpeningPrayer,ClosingPrayer,BishopricID,OpeningHymnID,SacramentHymnID,IntermediateHymnID,ClosingHymnID")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "FullName", meeting.BishopricID);
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel", meeting.OpeningHymnID);
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings.SingleOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "FullName", meeting.BishopricID);
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnID", meeting.OpeningHymnID);
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,OpeningPrayer,ClosingPrayer,BishopricID,OpeningHymnID,SacramentHymnID,IntermediateHymnID,ClosingHymnID")] Meeting meeting)
        {
            if (id != meeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
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
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "FullName", meeting.BishopricID);
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnID", meeting.OpeningHymnID);
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns, "HymnID", "HymnLabel");
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.Conductor)
                .Include(m => m.Hymn)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meetings.SingleOrDefaultAsync(m => m.ID == id);
            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.ID == id);
        }
    }
}
