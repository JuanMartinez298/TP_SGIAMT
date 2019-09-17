using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_SGIAMT.Models;

namespace TP_SGIAMT.Controllers
{
    public class TModalidadConsController : Controller
    {
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TModalidadConsController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }

        // GET: TModalidadCons
        public async Task<IActionResult> Index()
        {
            return View(await _context.TModalidadCon.ToListAsync());
        }

        // GET: TModalidadCons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tModalidadCon = await _context.TModalidadCon
                .FirstOrDefaultAsync(m => m.PkImIdModalidadCon == id);
            if (tModalidadCon == null)
            {
                return NotFound();
            }

            return View(tModalidadCon);
        }

        // GET: TModalidadCons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TModalidadCons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkImIdModalidadCon,VmNombreModCon")] TModalidadCon tModalidadCon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tModalidadCon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tModalidadCon);
        }

        // GET: TModalidadCons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tModalidadCon = await _context.TModalidadCon.FindAsync(id);
            if (tModalidadCon == null)
            {
                return NotFound();
            }
            return View(tModalidadCon);
        }

        // POST: TModalidadCons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkImIdModalidadCon,VmNombreModCon")] TModalidadCon tModalidadCon)
        {
            if (id != tModalidadCon.PkImIdModalidadCon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tModalidadCon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TModalidadConExists(tModalidadCon.PkImIdModalidadCon))
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
            return View(tModalidadCon);
        }

        // GET: TModalidadCons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tModalidadCon = await _context.TModalidadCon
                .FirstOrDefaultAsync(m => m.PkImIdModalidadCon == id);
            if (tModalidadCon == null)
            {
                return NotFound();
            }

            return View(tModalidadCon);
        }

        // POST: TModalidadCons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tModalidadCon = await _context.TModalidadCon.FindAsync(id);
            _context.TModalidadCon.Remove(tModalidadCon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TModalidadConExists(int id)
        {
            return _context.TModalidadCon.Any(e => e.PkImIdModalidadCon == id);
        }
    }
}
