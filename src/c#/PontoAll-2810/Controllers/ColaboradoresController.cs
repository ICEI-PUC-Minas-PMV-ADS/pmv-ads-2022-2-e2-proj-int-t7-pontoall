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
    public class ColaboradoresController : Controller
    {
        private readonly Contexto _context;

        public ColaboradoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Colaboradors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Colaborador.ToListAsync());
        }

        // GET: Colaboradors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Colaborador = await _context.Colaborador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Colaborador == null)
            {
                return NotFound();
            }

            return View(Colaborador);
        }

        // GET: Colaboradors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Colaboradors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CPF,Email,Celular,CargaHoraria,DataCadastro,Admissao,Senha,Funcao,Salario,Desligamento")] Colaborador Colaborador)
        {
            if (ModelState.IsValid)
            {
                Colaborador.Senha = BCrypt.Net.BCrypt.HashPassword(Colaborador.Senha);
                _context.Add(Colaborador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Colaborador);
        }

        // GET: Colaboradors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Colaborador = await _context.Colaborador.FindAsync(id);
            if (Colaborador == null)
            {
                return NotFound();
            }
            return View(Colaborador);
        }

        // POST: Colaboradors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,CPF,Email,Celular,CargaHoraria,DataCadastro,Admissao,Senha,Funcao,Salario,Desligamento")] Colaborador Colaborador)
        {
            if (id != Colaborador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Colaborador.Senha = BCrypt.Net.BCrypt.HashPassword(Colaborador.Senha);
                    _context.Update(Colaborador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ColaboradorExists(Colaborador.Id))
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
            return View(Colaborador);
        }

        // GET: Colaboradors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Colaborador = await _context.Colaborador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Colaborador == null)
            {
                return NotFound();
            }

            return View(Colaborador);
        }

        // POST: Colaboradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Colaborador = await _context.Colaborador.FindAsync(id);
            _context.Colaborador.Remove(Colaborador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColaboradorExists(int id)
        {
            return _context.Colaborador.Any(e => e.Id == id);
        }
    }
}
