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
    public class Operador2Controller : Controller
    {
        private readonly Contexto _context;

        public Operador2Controller(Contexto context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login([Bind("Nome,Senha")] Operador operador)
        {
           
            var user = await _context.Operador
                .FirstOrDefaultAsync(m => m.UsuarioId == operador.Id);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOK = BCrypt.Net.BCrypt.Verify(operador.Senha, user.Senha);

            if (isSenhaOK)
            {
                ViewBag.Message = "Usuário OK!";
                return View();
            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();

            return View();
        }



        // GET: Operador2
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Operador.Include(o => o.Usuario);
            return View(await contexto.ToListAsync());
        }

        // GET: Operador2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador
                .Include(o => o.Usuario)
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // GET: Operador2/Relatorio/5

        public async Task<IActionResult> Relatorio(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }
        // GET: Operador2/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome");
            return View();
        }

        // POST: Operador2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Senha,Perfil,UsuarioId")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                operador.Senha = BCrypt.Net.BCrypt.HashPassword(operador.Senha);
                _context.Add(operador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome", operador.UsuarioId);
            return View(operador);
        }

        // GET: Operador2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador.FindAsync(id);
            if (operador == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome", operador.UsuarioId);
            return View(operador);
        }

        // POST: Operador2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Senha,Perfil,UsuarioId")] Operador operador)
        {
            if (id != operador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    operador.Senha = BCrypt.Net.BCrypt.HashPassword(operador.Senha);
                    _context.Update(operador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperadorExists(operador.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome", operador.UsuarioId);
            return View(operador);
        }

        // GET: Operador2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operador = await _context.Operador
                .Include(o => o.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // POST: Operador2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var operador = await _context.Operador.FindAsync(id);
            _context.Operador.Remove(operador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorExists(int id)
        {
            return _context.Operador.Any(e => e.Id == id);
        }
    }
}
