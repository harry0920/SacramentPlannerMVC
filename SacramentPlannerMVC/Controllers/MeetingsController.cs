﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlannerMVC.Data;
using SacramentPlannerMVC.Models;
using SacramentPlannerMVC.Models.ViewModels;

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
        public async Task<IActionResult> Index(int? id)
        {
            var viewModel = new MeetingIndexModel
            {
                Meetings = await _context.Meetings
                .Include(m => m.ClosingHymnNav)
                .Include(m => m.Conductor)
                .Include(m => m.IntermediateHymnNav)
                .Include(m => m.OpeningHymnNav)
                .Include(m => m.SacramentHymnNav)
                .ToListAsync()
            };

            if (id != null)
            {
                ViewData["MeetingID"] = id.Value;

                var speakers = await _context.Speakers
                    .Where(s => s.MeetingID == id)
                    .ToListAsync();

                viewModel.Speakers = speakers;

                ViewData["MeetingID"] = id;
            }

            return View(viewModel);
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(m => m.ClosingHymnNav)
                .Include(m => m.Conductor)
                .Include(m => m.IntermediateHymnNav)
                .Include(m => m.OpeningHymnNav)
                .Include(m => m.SacramentHymnNav)
                .SingleOrDefaultAsync(m => m.MeetingId == id);

            MeetingDetailView viewModel = new MeetingDetailView();
            viewModel.Meeting = meeting;

            var conductor = await _context.Bishopric
                .SingleOrDefaultAsync(m => m.ID == meeting.BishopricID);

            viewModel.Conductor = conductor;

            ViewData["MeetingID"] = id.Value;

            var speakers = await _context.Speakers
                .Where(s => s.MeetingID == id)
                .ToListAsync();

            viewModel.Speakers = speakers;

            if (meeting == null)
            {
                return NotFound();
            }

            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "Name");
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");

            return View(viewModel);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "Name");
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel");
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MeetingId,Date,OpeningPrayer,ClosingPrayer,BishopricID,OpeningHymnID,SacramentHymnID,IntermediateHymnID,ClosingHymnID")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.ClosingHymnID);
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "Name", meeting.BishopricID);
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.IntermediateHymnID);
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.OpeningHymnID);
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.SacramentHymnID);
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings.SingleOrDefaultAsync(m => m.MeetingId == id);
            if (meeting == null)
            {
                return NotFound();
            }
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.ClosingHymnID);
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "Name", meeting.BishopricID);
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.IntermediateHymnID);
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.OpeningHymnID);
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.SacramentHymnID);
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeetingId,Date,OpeningPrayer,ClosingPrayer,BishopricID,OpeningHymnID,SacramentHymnID,IntermediateHymnID,ClosingHymnID")] Meeting meeting)
        {
            if (id != meeting.MeetingId)
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
                    if (!MeetingExists(meeting.MeetingId))
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
            ViewData["ClosingHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.ClosingHymnID);
            ViewData["BishopricID"] = new SelectList(_context.Bishopric.Where(b => b.IsActive == true), "ID", "Name", meeting.BishopricID);
            ViewData["IntermediateHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.IntermediateHymnID);
            ViewData["OpeningHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.OpeningHymnID);
            ViewData["SacramentHymnID"] = new SelectList(_context.Hymns.OrderBy(h => h.HymnNumber), "ID", "HymnLabel", meeting.SacramentHymnID);
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
                .Include(m => m.ClosingHymnNav)
                .Include(m => m.Conductor)
                .Include(m => m.IntermediateHymnNav)
                .Include(m => m.OpeningHymnNav)
                .Include(m => m.SacramentHymnNav)
                .SingleOrDefaultAsync(m => m.MeetingId == id);
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
            var meeting = await _context.Meetings.SingleOrDefaultAsync(m => m.MeetingId == id);
            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.MeetingId == id);
        }
    }
}
