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
    public class TEstadoConsController : Controller
    {
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TEstadoConsController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }

        // GET: TEstadoCons
        public async Task<IActionResult> Index()
        {
            return View(await _context.TEstadoCon.ToListAsync());
        }

        // GET: TEstadoCons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tEstadoCon = await _context.TEstadoCon
                .FirstOrDefaultAsync(m => m.PkIeIdEstado == id);
            if (tEstadoCon == null)
            {
                return NotFound();
            }

            return View(tEstadoCon);
        }

        // GET: TEstadoCons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TEstadoCons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIeIdEstado,VeNombreEsta")] TEstadoCon tEstadoCon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tEstadoCon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tEstadoCon);
        }

        // GET: TEstadoCons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tEstadoCon = await _context.TEstadoCon.FindAsync(id);
            if (tEstadoCon == null)
            {
                return NotFound();
            }
            return View(tEstadoCon);
        }

        // POST: TEstadoCons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIeIdEstado,VeNombreEsta")] TEstadoCon tEstadoCon)
        {
            if (id != tEstadoCon.PkIeIdEstado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tEstadoCon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TEstadoConExists(tEstadoCon.PkIeIdEstado))
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
            return View(tEstadoCon);
        }

        // GET: TEstadoCons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tEstadoCon = await _context.TEstadoCon
                .FirstOrDefaultAsync(m => m.PkIeIdEstado == id);
            if (tEstadoCon == null)
            {
                return NotFound();
            }

            return View(tEstadoCon);
        }

        // POST: TEstadoCons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tEstadoCon = await _context.TEstadoCon.FindAsync(id);
            _context.TEstadoCon.Remove(tEstadoCon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TEstadoConExists(int id)
        {
            return _context.TEstadoCon.Any(e => e.PkIeIdEstado == id);
        }
    }
}
