//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using TheTipTopSiteweb.Models;

//namespace TheTipTopSiteweb.Controllers
//{
//    public class ConcoursController : Controller
//    {
//        private readonly thetiptoptestContext _context;

//        public ConcoursController(thetiptoptestContext context)
//        {
//            _context = context;
//        }

//        // GET: Concours
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Concours.ToListAsync());
//        }

//        // GET: Concours/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var concour = await _context.Concours
//                .FirstOrDefaultAsync(m => m.Idconcours == id);
//            if (concour == null)
//            {
//                return NotFound();
//            }

//            return View(concour);
//        }

//        // GET: Concours/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Concours/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Idconcours,NomConcours,Descriptionconcours")] Concour concour)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(concour);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(concour);
//        }

//        // GET: Concours/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var concour = await _context.Concours.FindAsync(id);
//            if (concour == null)
//            {
//                return NotFound();
//            }
//            return View(concour);
//        }

//        // POST: Concours/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Idconcours,NomConcours,Descriptionconcours")] Concour concour)
//        {
//            if (id != concour.Idconcours)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(concour);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ConcourExists(concour.Idconcours))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(concour);
//        }

//        // GET: Concours/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var concour = await _context.Concours
//                .FirstOrDefaultAsync(m => m.Idconcours == id);
//            if (concour == null)
//            {
//                return NotFound();
//            }

//            return View(concour);
//        }

//        // POST: Concours/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var concour = await _context.Concours.FindAsync(id);
//            _context.Concours.Remove(concour);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ConcourExists(int id)
//        {
//            return _context.Concours.Any(e => e.Idconcours == id);
//        }
//    }
//}
