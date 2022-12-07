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
    public class BancoHorasController : Controller
    {
        private readonly Contexto _context;

        public BancoHorasController(Contexto context)
        {
            _context = context;
        }

        // GET: BancoHoras
        public async Task<IActionResult> Index()
        {
            return View(await _context.BancoHoras.ToListAsync());
        }

        // GET: BancoHoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bancoHoras = await _context.BancoHoras
                .FirstOrDefaultAsync(m => m.IdBancoHoras == id);
            if (bancoHoras == null)
            {
                return NotFound();
            }

            return View(bancoHoras);
        }

        // GET: BancoHoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BancoHoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdBancoHoras,UserId,HoraEntrada,HoraSaida,Data")] BancoHoras bancoHoras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bancoHoras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bancoHoras);
        }

        // GET: BancoHoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bancoHoras = await _context.BancoHoras.FindAsync(id);
            if (bancoHoras == null)
            {
                return NotFound();
            }
            return View(bancoHoras);
        }

        // POST: BancoHoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdBancoHoras,UserId,HoraEntrada,HoraSaida,Data")] BancoHoras bancoHoras)
        {
            if (id != bancoHoras.IdBancoHoras)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bancoHoras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BancoHorasExists(bancoHoras.IdBancoHoras))
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
            return View(bancoHoras);
        }

        // GET: BancoHoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bancoHoras = await _context.BancoHoras
                .FirstOrDefaultAsync(m => m.IdBancoHoras == id);
            if (bancoHoras == null)
            {
                return NotFound();
            }

            return View(bancoHoras);
        }

        // POST: BancoHoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bancoHoras = await _context.BancoHoras.FindAsync(id);
            _context.BancoHoras.Remove(bancoHoras);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BancoHorasExists(int id)
        {
            return _context.BancoHoras.Any(e => e.IdBancoHoras == id);
        }
    }
}
