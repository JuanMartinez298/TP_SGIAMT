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
    public class TArchivoUsuariosController : Controller
    {
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TArchivoUsuariosController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }

        // GET: TArchivoUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.TArchivoUsuario.ToListAsync());
        }

        // GET: TArchivoUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tArchivoUsuario = await _context.TArchivoUsuario
                .FirstOrDefaultAsync(m => m.PkIauIdArchivo == id);
            if (tArchivoUsuario == null)
            {
                return NotFound();
            }

            return View(tArchivoUsuario);
        }

        // GET: TArchivoUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TArchivoUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIauIdArchivo,VauArchivo")] TArchivoUsuario tArchivoUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tArchivoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tArchivoUsuario);
        }

        // GET: TArchivoUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tArchivoUsuario = await _context.TArchivoUsuario.FindAsync(id);
            if (tArchivoUsuario == null)
            {
                return NotFound();
            }
            return View(tArchivoUsuario);
        }

        // POST: TArchivoUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIauIdArchivo,VauArchivo")] TArchivoUsuario tArchivoUsuario)
        {
            if (id != tArchivoUsuario.PkIauIdArchivo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tArchivoUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TArchivoUsuarioExists(tArchivoUsuario.PkIauIdArchivo))
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
            return View(tArchivoUsuario);
        }

        // GET: TArchivoUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tArchivoUsuario = await _context.TArchivoUsuario
                .FirstOrDefaultAsync(m => m.PkIauIdArchivo == id);
            if (tArchivoUsuario == null)
            {
                return NotFound();
            }

            return View(tArchivoUsuario);
        }

        // POST: TArchivoUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tArchivoUsuario = await _context.TArchivoUsuario.FindAsync(id);
            _context.TArchivoUsuario.Remove(tArchivoUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TArchivoUsuarioExists(int id)
        {
            return _context.TArchivoUsuario.Any(e => e.PkIauIdArchivo == id);
        }
    }
}
