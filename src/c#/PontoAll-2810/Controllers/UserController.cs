using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PontoAll_2810.Models;
using Microsoft.AspNetCore.Identity;
using Hanssens.Net;
using Xamarin.Forms.PlatformConfiguration;
using EO.WebBrowser.DOM;

namespace PontoAll_2810.Controllers
{
    public class UserController : Controller
    {
        private readonly Contexto _context;

        public UserController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }
    //Região sensivel do login
        [HttpPost]
        public async Task<IActionResult> Login([Bind("UserId,UsuarioId,Nome,Senha")] User user)
        {           
            var user1 = await _context.User.FirstOrDefaultAsync(m => m.Nome == user.Nome);

            if (user1 == null)
            {
                ViewBag.Message = "Usuário e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOK = BCrypt.Net.BCrypt.Verify(user.Senha, user1.Senha);
    //Região sensivel do login
            if (isSenhaOK)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user1.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user1.Nome),
                    new Claim(ClaimTypes.Role, user1.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                   
                    
                };
                               
             
                    await HttpContext.SignInAsync(principal, props);

                return Redirect("/");

            }                        
            
            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();            
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login","User");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }


        // GET: Operador2
        public async Task<IActionResult> Index()
        {
            var contexto = _context.User.Include(o => o.Usuario);
            return View(await contexto.ToListAsync());
        }

        // GET: Operador2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(o => o.Usuario)
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Operador2/Relatorio/5

        public async Task<IActionResult> Relatorio(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
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
        public async Task<IActionResult> Create([Bind("Id,Nome,Senha,Perfil,UsuarioId")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Senha = BCrypt.Net.BCrypt.HashPassword(user.Senha);
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome", user.UsuarioId);
            return View(user);
        }

        // GET: Operador2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome", user.UsuarioId);
            return View(user);
        }

        // POST: Operador2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Senha,Perfil,UsuarioId")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.Senha = BCrypt.Net.BCrypt.HashPassword(user.Senha);
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperadorExists(user.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Colaborador, "Id", "Nome", user.UsuarioId);
            return View(user);
        }

        // GET: Operador2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(o => o.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Operador2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
