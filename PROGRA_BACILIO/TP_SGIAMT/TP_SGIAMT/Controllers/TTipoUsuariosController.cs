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
    public class TTipoUsuariosController : Controller
    {
        private readonly DB_A4D4D9_BDSGIAMTContext _context;

        public TTipoUsuariosController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }

        // GET: TTipoUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.TTipoUsuario.ToListAsync());
        }

        // GET: TTipoUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTipoUsuario = await _context.TTipoUsuario
                .FirstOrDefaultAsync(m => m.PkItuTipoUsuario == id);
            if (tTipoUsuario == null)
            {
                return NotFound();
            }

            return View(tTipoUsuario);
        }

        // GET: TTipoUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TTipoUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkItuTipoUsuario,VtuNombreTipoUsuario")] TTipoUsuario tTipoUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tTipoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tTipoUsuario);
        }

        // GET: TTipoUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTipoUsuario = await _context.TTipoUsuario.FindAsync(id);
            if (tTipoUsuario == null)
            {
                return NotFound();
            }
            return View(tTipoUsuario);
        }

        // POST: TTipoUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkItuTipoUsuario,VtuNombreTipoUsuario")] TTipoUsuario tTipoUsuario)
        {
            if (id != tTipoUsuario.PkItuTipoUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tTipoUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TTipoUsuarioExists(tTipoUsuario.PkItuTipoUsuario))
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
            return View(tTipoUsuario);
        }

        // GET: TTipoUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTipoUsuario = await _context.TTipoUsuario
                .FirstOrDefaultAsync(m => m.PkItuTipoUsuario == id);
            if (tTipoUsuario == null)
            {
                return NotFound();
            }

            return View(tTipoUsuario);
        }

        // POST: TTipoUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tTipoUsuario = await _context.TTipoUsuario.FindAsync(id);
            _context.TTipoUsuario.Remove(tTipoUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TTipoUsuarioExists(int id)
        {
            return _context.TTipoUsuario.Any(e => e.PkItuTipoUsuario == id);
        }
    }
}
