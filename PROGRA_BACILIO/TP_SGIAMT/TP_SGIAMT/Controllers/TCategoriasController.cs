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
    public class TCategoriasController : Controller
    {
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TCategoriasController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }

        // GET: TCategorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.TCategoria.ToListAsync());
        }

        // GET: TCategorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tCategoria = await _context.TCategoria
                .FirstOrDefaultAsync(m => m.PkIcCodCat == id);
            if (tCategoria == null)
            {
                return NotFound();
            }

            return View(tCategoria);
        }

        // GET: TCategorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIcCodCat,VcNomCategoria")] TCategoria tCategoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tCategoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tCategoria);
        }

        // GET: TCategorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tCategoria = await _context.TCategoria.FindAsync(id);
            if (tCategoria == null)
            {
                return NotFound();
            }
            return View(tCategoria);
        }

        // POST: TCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIcCodCat,VcNomCategoria")] TCategoria tCategoria)
        {
            if (id != tCategoria.PkIcCodCat)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tCategoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TCategoriaExists(tCategoria.PkIcCodCat))
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
            return View(tCategoria);
        }

        // GET: TCategorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tCategoria = await _context.TCategoria
                .FirstOrDefaultAsync(m => m.PkIcCodCat == id);
            if (tCategoria == null)
            {
                return NotFound();
            }

            return View(tCategoria);
        }

        // POST: TCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tCategoria = await _context.TCategoria.FindAsync(id);
            _context.TCategoria.Remove(tCategoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TCategoriaExists(int id)
        {
            return _context.TCategoria.Any(e => e.PkIcCodCat == id);
        }
    }
}
