using BeFit.Application.CwiczenieApplication;
using BeFit.Application.CwiczenieApplication.CwiczenieApplication;
using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    public class CwiczenieController : Controller
    {
        private readonly ICwiczeniaApplication _cwiczeniaApplication;

        public CwiczenieController(ICwiczeniaApplication cwiczeniaApplication)
        {
            _cwiczeniaApplication = cwiczeniaApplication;
        }

        public IActionResult CreateCwiczenie()
        {
            return View();
        }
        public IActionResult Index()
        {
            var ListaCwiczen = _cwiczeniaApplication.GetAll();
            return View(ListaCwiczen);
        }
        [HttpPost]
        public IActionResult CreateCwiczenie(CwiczenieDTO dto)
        {
            if(!ModelState.IsValid) 
            {
                return View(dto);
            }
            _cwiczeniaApplication.Create(dto);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            _cwiczeniaApplication.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edition(int id)
        {
            var edycja = _cwiczeniaApplication.GetById(id);
            if(edycja == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(edycja);
        }
        [HttpPost]
        public IActionResult Edition(Cwiczenie cwiczenie)
        {
            var edycja = _cwiczeniaApplication.Edition(cwiczenie);
            if (edycja == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
