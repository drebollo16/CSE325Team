using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeeting.Data;
using SacramentMeeting.Models;

namespace SacramentMeeting.Controllers
{
    public class MeetingPlannersController : Controller
    {
        private readonly MeetingContext _context;

        public MeetingPlannersController(MeetingContext context)
        {
            _context = context;
        }

        // GET: MeetingPlanners
        public async Task<IActionResult> Index()
        {
              return _context.MeetingPlanners != null ? 
                          View(await _context.MeetingPlanners.ToListAsync()) :
                          Problem("Entity set 'MeetingContext.MeetingPlanners'  is null.");
        }

        // GET: MeetingPlanners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MeetingPlanners == null)
            {
                return NotFound();
            }

            var meetingPlanner = await _context.MeetingPlanners
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetingPlanner == null)
            {
                return NotFound();
            }

            return View(meetingPlanner);
        }

        // GET: MeetingPlanners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MeetingPlanners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,OpeningPrayer,ConductingLeader,OpeningSong,SacramentHym,NumOfSpeakers,SpeakerSubjects,ClosingSong,ClosingPrayer")] MeetingPlanner meetingPlanner)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(meetingPlanner);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(meetingPlanner);
        
            //CHANGED TO EXAMPLE DONT DELETE ORGINAL CODE
            /*
            if (ModelState.IsValid)
            {
                _context.Add(meetingPlanner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meetingPlanner);

            */
        }

        // GET: MeetingPlanners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MeetingPlanners == null)
            {
                return NotFound();
            }

            var meetingPlanner = await _context.MeetingPlanners.FindAsync(id);
            if (meetingPlanner == null)
            {
                return NotFound();
            }
            return View(meetingPlanner);
        }

        // POST: MeetingPlanners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,OpeningPrayer,ConductingLeader,OpeningSong,SacramentHym,NumOfSpeakers,SpeakerSubjects,ClosingSong,ClosingPrayer")] MeetingPlanner meetingPlanner)
        {
            if (id != meetingPlanner.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetingPlanner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingPlannerExists(meetingPlanner.ID))
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
            return View(meetingPlanner);
        }

        // GET: MeetingPlanners/Delete/5
        //MADE CHANGES ADDED ERROR 
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null || _context.MeetingPlanners == null)
            {
                return NotFound();
            }

            var meetingPlanner = await _context.MeetingPlanners
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meetingPlanner == null)
            {
                return NotFound();
            }
            if(saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " + "See your System Administrator.";
            }
            return View(meetingPlanner);
        }

        // POST: MeetingPlanners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.MeetingPlanners.FindAsync(id);

            if(meeting == null)
            {
                return RedirectToAction(nameof (Index));
            }

            try
            {
                _context.MeetingPlanners.Remove(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            catch (Exception ex)
            {
                return RedirectToAction(nameof(Delete), new {id= id, saveChangesError = true});
            }


            //Orginal if new dont work this code works
            /*
            if (_context.MeetingPlanners == null)
            {
                return Problem("Entity set 'MeetingContext.MeetingPlanners'  is null.");
            }
            var meetingPlanner = await _context.MeetingPlanners.FindAsync(id);
            if (meetingPlanner != null)
            {
                _context.MeetingPlanners.Remove(meetingPlanner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));*/
        }

        private bool MeetingPlannerExists(int id)
        {
          return (_context.MeetingPlanners?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
