using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuadoviWebAplikacija.Models;

namespace QuadoviWebAplikacija.Controllers
{
    public class BiciklController : Controller
    {
        private readonly IRepozitorijUpita _repozitorijUpita;
        public BiciklController(IRepozitorijUpita repozitorijUpita)
        {
            _repozitorijUpita = repozitorijUpita;
        }

        public IActionResult Index()
        {
            return View(_repozitorijUpita.PopisBicikl());
        }

        public IActionResult Create()
        {
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv");
            int sljedeciId = _repozitorijUpita.SljedeciId();
            Bicikl bicikl = new Bicikl() { Id = sljedeciId };
            return View(bicikl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Naziv,GodinaProizvodnje,Cijena,SlikaUrl,KategorijaId")] Bicikl bicikl)
        {
            ModelState.Remove("Kategorija");//uklanjanje veze

            if (ModelState.IsValid)
            {
                _repozitorijUpita.Create(bicikl);
                return RedirectToAction("Index"); // ako je sve ok, tu završava metoda 
            }
            //ako je doslo do greške sljedeci dio se izvrsava
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", bicikl.KategorijaId);
            return View(bicikl);

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            Bicikl bicikl = _repozitorijUpita.DohvatiBiciklSIdom(id);

            if (bicikl == null) { return NotFound(); }

            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", bicikl.KategorijaId);
            return View(bicikl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, [Bind("Id,Naziv,GodinaProizvodnje,Cijena,SlikaUrl,KategorijaId")] Bicikl bicikl)
        {
            if (id != bicikl.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Kategorija");

            if (ModelState.IsValid)
            {
                _repozitorijUpita.Update(bicikl);
                return RedirectToAction("Index");
            }
            //ako je doslo do greške sljedeci dio se izvrsava
            ViewData["KategorijaId"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Id", "Naziv", bicikl.KategorijaId);
            return View(bicikl);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var bicikl = _repozitorijUpita.DohvatiBiciklSIdom(Convert.ToInt16(id));

            if (bicikl == null)
            {
                return NotFound();
            }

            return View(bicikl);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var bicikl = _repozitorijUpita.DohvatiBiciklSIdom(id);
            _repozitorijUpita.Delete(bicikl);
            return RedirectToAction("Index");

        }

        //Trazilica
        public ActionResult SearchIndex(string biciklVrsta, string searchString)
        {
            var vrsta = new List<string>();

            var vrstaUpit = _repozitorijUpita.PopisKategorija();

            ViewData["biciklVrsta"] = new SelectList(_repozitorijUpita.PopisKategorija(), "Naziv", "Naziv", vrstaUpit);

            var bicikli = _repozitorijUpita.PopisBicikl();

            if (!String.IsNullOrWhiteSpace(searchString))
            {
                bicikli = bicikli.Where(s => s.Naziv.Contains(searchString, StringComparison.OrdinalIgnoreCase)); // StringComparison.OrdinalIgnoreCase ignorira velika-mala slova 
            }

            if (string.IsNullOrWhiteSpace(biciklVrsta))
                return View(bicikli);
            else
            {
                return View(bicikli.Where(x => x.Kategorija.Naziv == biciklVrsta));
            }
        }
    }
}
