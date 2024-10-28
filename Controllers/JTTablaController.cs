using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JulianTorres_ExamenP1.Data;
using JulianTorres_ExamenP1.Models;

namespace JulianTorres_ExamenP1.Controllers
{
    public class JTTablaController : Controller
    {
        private readonly JulianTorres_ExamenP1Context _context;

        public JTTablaController(JulianTorres_ExamenP1Context context)
        {
            _context = context;
        }

        // GET: JTTabla
        public async Task<IActionResult> Index()
        {
              return _context.JTTabla != null ? 
                          View(await _context.JTTabla.ToListAsync()) :
                          Problem("Entity set 'JulianTorres_ExamenP1Context.JTTabla'  is null.");
        }

        // GET: JTTabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.JTTabla == null)
            {
                return NotFound();
            }

            var jTTabla = await _context.JTTabla
                .FirstOrDefaultAsync(m => m.JTTablaId == id);
            if (jTTabla == null)
            {
                return NotFound();
            }

            return View(jTTabla);
        }

        // GET: JTTabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JTTabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JTTablaId,JTTablaObjeto,JTCostoBruto,JTALaVenta,JTEmailAddress,JTFecha,JTPVP")] JTTabla jTTabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jTTabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jTTabla);
        }

        // GET: JTTabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.JTTabla == null)
            {
                return NotFound();
            }

            var jTTabla = await _context.JTTabla.FindAsync(id);
            if (jTTabla == null)
            {
                return NotFound();
            }
            return View(jTTabla);
        }

        // POST: JTTabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JTTablaId,JTTablaObjeto,JTCostoBruto,JTALaVenta,JTEmailAddress,JTFecha,JTPVP")] JTTabla jTTabla)
        {
            if (id != jTTabla.JTTablaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jTTabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JTTablaExists(jTTabla.JTTablaId))
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
            return View(jTTabla);
        }

        // GET: JTTabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.JTTabla == null)
            {
                return NotFound();
            }

            var jTTabla = await _context.JTTabla
                .FirstOrDefaultAsync(m => m.JTTablaId == id);
            if (jTTabla == null)
            {
                return NotFound();
            }

            return View(jTTabla);
        }

        // POST: JTTabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.JTTabla == null)
            {
                return Problem("Entity set 'JulianTorres_ExamenP1Context.JTTabla'  is null.");
            }
            var jTTabla = await _context.JTTabla.FindAsync(id);
            if (jTTabla != null)
            {
                _context.JTTabla.Remove(jTTabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JTTablaExists(int id)
        {
          return (_context.JTTabla?.Any(e => e.JTTablaId == id)).GetValueOrDefault();
        }
    }
}
