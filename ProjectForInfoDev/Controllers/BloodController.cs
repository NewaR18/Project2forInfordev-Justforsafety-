using Microsoft.AspNetCore.Mvc;
using ProjectForInfoDev.Models;
using ProjectForInfoDev.Repository;

namespace ProjectForInfoDev.Controllers
{
    public class BloodController : Controller
    {
        public readonly IBloodRepo _repo;
        public BloodController(IBloodRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blood b1)
        {
            _repo.AddHospital(b1);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var s1=_repo.GetHospital();
            return View(s1);
        }
        public IActionResult GetSingle(int id)
        {
            var s1=_repo.GetSingleHospital(id);
            return View(s1);
        }
        public IActionResult editing(int id)
        {
            var s1=_repo.GetSingleHospital(id);
            return View(s1);
        }
        [HttpPost]
        public IActionResult editing(Blood s)
        {
            _repo.Updatehospital(s);
            return RedirectToAction("Index");
        }
        public IActionResult deleting(int id)
        {
            var s1=_repo.GetSingleHospital(id);
            return View(s1);
        }
        [HttpPost]
        public IActionResult deleting(Blood s)
        {
            _repo.RemoveHospital(s.Id);
            return RedirectToAction("Index");
        }
        public IActionResult ReviewForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ReviewForm(SpecialQuery s1)
        {
            _repo.AddQuery(s1);
            return RedirectToAction("Index");
        }
    }
}
