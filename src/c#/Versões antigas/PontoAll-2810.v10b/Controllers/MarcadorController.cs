﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PontoAll_2810.Models;

namespace PontoAll_2810.Controllers
{
    public class MarcadorController : Controller
    {
        private readonly Contexto _context;

        public MarcadorController(Contexto context)
        {
            _context = context;
        }

        // GET: Marcador
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroPonto.ToListAsync());
        }

        // GET: Marcador/Details/5
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

        // GET: Marcador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Marcador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRegistroPonto,DataRegistro,HoraRegistro,LocalizacaoRegistro,Perfil,SomaHora")] RegistroPonto registroPonto)
        {
            string nome = User.Identity.Name;
            var user = await _context.User.FirstOrDefaultAsync(m => m.Nome == nome);
            var ultimoPonto = await _context.RegistroPonto.OrderByDescending(r => r.IdRegistroPonto).FirstOrDefaultAsync(r => r.UserId == user.Id); // (Comentar essa linha para inserir a primeira marcação do usuario por enquanto)

            registroPonto.DataRegistro = DateTime.Now.ToString("dd/MM/yyyy");// melhorado em 16/11/2022
            registroPonto.HoraRegistro = DateTime.Now.ToString("HH:mm"); // melhorado em 16/11/2022
            registroPonto.Perfil = (Perfil)1;
            registroPonto.SomaHora = registroPonto.CalculoHoras(registroPonto.HoraRegistro, ultimoPonto.HoraRegistro); // (Comentar essa linha para inserir a primeira marcação do usuario por enquanto)
            registroPonto.LocalizacaoRegistro = "0";
            registroPonto.UserId = user.Id;


            if (!ModelState.IsValid)
            {
                _context.Add(registroPonto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroPonto);
        }

        // GET: Marcador/Edit/5
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

        // POST: Marcador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRegistroPonto,DataRegistro,HoraRegistro,LocalizacaoRegistro,Perfil,SomaHora")] RegistroPonto registroPonto)
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

        // GET: Marcador/Delete/5
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

        // POST: Marcador/Delete/5
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
