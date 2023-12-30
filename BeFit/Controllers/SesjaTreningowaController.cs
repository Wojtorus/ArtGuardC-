using BeFit.Application.SesjaTreningowaApplication;
using BeFit.Infrastructure.SesjaTreningowaRespositories.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class SesjaTreningowaController : Controller
    {
        private readonly ISesjaTreningowaApplication _sesja;

        public SesjaTreningowaController(ISesjaTreningowaApplication sesja)
        {
            _sesja = sesja;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DodajSesjeTreningowa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DodajSesjeTreningowa(SesjaTreningowaDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var sesjaTreningowa = _sesja.DodajSesjeTreningowa(1);
            if (sesjaTreningowa == null)
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
