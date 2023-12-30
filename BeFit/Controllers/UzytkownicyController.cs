using BeFit.Application.UzytkownicyApplication;
using BeFit.Infrastructure.UzytkownicyRespositories.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class UzytkownicyController : Controller
    {
        private readonly IUzytkownicyApplication _uzytkownikApplication;

        public UzytkownicyController(IUzytkownicyApplication uzytkownikApplication)
        {
            _uzytkownikApplication = uzytkownikApplication;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DodajUzytkownika(UzytkownikDTO dto)
        {
            var uzytkownik = _uzytkownikApplication.DodawanieUzytkownika(dto);
            if(uzytkownik != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Logowanie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logowanie(UzytkownikDTO dto)
        {
            var uzytkownik = _uzytkownikApplication.LogowanieUzytkownika(dto);
            if(uzytkownik == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(WidokZalogowanego));
        }
        public IActionResult WidokZalogowanego()
        {
            return View();
        }
    }
}
