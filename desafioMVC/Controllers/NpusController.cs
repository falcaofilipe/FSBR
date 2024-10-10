using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using desafioMVC.Data;
using desafioMVC.Models;
using desafioMVC.Data.Migrations;

namespace desafioMVC.Controllers
{
    public class NpusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment environment;
        private readonly Npu ibgeApi = new()
        {
            ListaUf = UF.ConsultaUf(),
            ListaMunicipio = Municipios.ConsultaMunicipios("")
        };

        public NpusController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            this.environment = environment;
        }

        // GET: Npus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Npus.ToListAsync());
        }

        // GET: Npus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var npu = await _context.Npus
                .FirstOrDefaultAsync(m => m.id == id);
            if (npu == null)
            {
                return NotFound();
            }

            return View(npu);
        }

        // GET: Npus/Create
        public IActionResult Create()
        {
            return View(ibgeApi);
        }

        // POST: Npus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(Npu npus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(npus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(npus);
        }

        // GET: Npus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var npu = await _context.Npus.FindAsync(id);
            if (npu == null)
            {
                return NotFound();
            }
            return View(npu);
        }

        // POST: Npus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nomeProcesso,npu,dataCadastro,dataVisualizacao,uf,municipio")] Npu npus)
        {
            if (id != npus.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(npus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NpuExists(npus.id))
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
            return View(npus);
        }

        // GET: Npus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var npu = await _context.Npus
                .FirstOrDefaultAsync(m => m.id == id);
            if (npu == null)
            {
                return NotFound();
            }

            return View(npu);
        }

        // POST: Npus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var npu = await _context.Npus.FindAsync(id);
            if (npu != null)
            {
                _context.Npus.Remove(npu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NpuExists(int id)
        {
            return _context.Npus.Any(e => e.id == id);
        }

        public ViewResult ConsultaMunicipio(string uf)
        {

            ibgeApi.ListaMunicipio = Municipios.ConsultaMunicipios(uf);


            return View(ibgeApi.ListaMunicipio);
        }
    }
}
