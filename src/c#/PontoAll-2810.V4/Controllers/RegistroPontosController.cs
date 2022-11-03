using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PontoAll_2810.Models;

namespace PontoAll_2810.Controllers
{
    public class RegistroPontosController : Controller
    {
        private readonly Contexto _context;

        public RegistroPontosController(Contexto context)
        {
            _context = context;
        }

        // GET: RegistroPontos
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroPonto.ToListAsync());
        }

        // GET: RegistroPontos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroPonto = await _context.RegistroPonto
                .FirstOrDefaultAsync(m => m.IdRegistroPonto == id);
            if (registroPonto == null)
            {
                return NotFound();
            }

            return View(registroPonto);
        }

        // GET: RegistroPontos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroPontos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRegistroPonto,DataRegistro,HoraRegistro,LocalizacaoRegistro,SomaHora")] RegistroPonto registroPonto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroPonto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroPonto);
        }

        // GET: RegistroPontos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroPonto = await _context.RegistroPonto.FindAsync(id);
            if (registroPonto == null)
            {
                return NotFound();
            }
            return View(registroPonto);
        }

        // POST: RegistroPontos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRegistroPonto,DataRegistro,HoraRegistro,LocalizacaoRegistro,SomaHora")] RegistroPonto registroPonto)
        {
            if (id != registroPonto.IdRegistroPonto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroPonto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroPontoExists(registroPonto.IdRegistroPonto))
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
            return View(registroPonto);
        }

        // GET: RegistroPontos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroPonto = await _context.RegistroPonto
                .FirstOrDefaultAsync(m => m.IdRegistroPonto == id);
            if (registroPonto == null)
            {
                return NotFound();
            }

            return View(registroPonto);
        }

        // POST: RegistroPontos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroPonto = await _context.RegistroPonto.FindAsync(id);
            _context.RegistroPonto.Remove(registroPonto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroPontoExists(int id)
        {
            return _context.RegistroPonto.Any(e => e.IdRegistroPonto == id);
        }
    }
}
