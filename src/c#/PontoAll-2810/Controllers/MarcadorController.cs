using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        public async Task<IActionResult> Index2()
        {
            return View(await _context.RegistroPonto.ToListAsync());
        }
        public async Task<IActionResult> Index()
        {
            string nome = User.Identity.Name;
            var user = await _context.User.FirstOrDefaultAsync(m => m.Nome == nome);

            var model = from registroPonto in _context.RegistroPonto
                        orderby registroPonto.IdRegistroPonto
                        where registroPonto.UserId == user.Id
                        select registroPonto;

            return View(model);
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
            var ultimoPonto = await _context.RegistroPonto.OrderByDescending(r => r.IdRegistroPonto).FirstOrDefaultAsync(r => r.UserId == user.Id) != null ? await _context.RegistroPonto.OrderByDescending(r => r.IdRegistroPonto).FirstOrDefaultAsync(r => r.UserId == user.Id) : null; // (Comentar essa linha para inserir a primeira marcação do usuario por enquanto)

            registroPonto.DataRegistro = DateTime.Now.ToString("dd/MM/yyyy");// melhorado em 16/11/2022
            registroPonto.HoraRegistro = DateTime.Now.ToString("HH:mm"); // melhorado em 16/11/2022
            registroPonto.Perfil = (Perfil)1;

            if (ultimoPonto != null)
                registroPonto.SomaHora = registroPonto.CalculoHoras(registroPonto.HoraRegistro, ultimoPonto.HoraRegistro);
            else
                registroPonto.SomaHora = "0";

            // função responsavel por preencher a localização
            await PreencherLocalizacaoAsync(registroPonto);

            registroPonto.UserId = user.Id;


            if (!ModelState.IsValid)
            {
                _context.Add(registroPonto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroPonto);
        }

        private async Task PreencherLocalizacaoAsync(RegistroPonto registroPonto)
        {
            // instancia a classe que vcs criaram pra acessar o geo locator
            var x = new GeoHelper();
            // chama a funcao que obtem as coordenadas
            var json = await x.GetGeoInfo();
            // converte o resultado num objeto model (JSONToViewModel) que vcs mapearam
            var objeto = JsonConvert.DeserializeObject<JSONToViewModel>(json);
            // seta o valor no resultado - objeto que sera persistido contra o banco
            registroPonto.LocalizacaoRegistro = objeto.City;
            // GG MODAFOKA
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
