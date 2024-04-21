using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crud.Models;
using Crud.Repository;
namespace Crud.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index()
        {
            var results = _service.GetAll();
            return View(await results);
        }

        public async Task<IActionResult> Get(int CategoryID)
        {
            var category = await _service.Get(CategoryID);
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Store(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if (await _service.Create(category))
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int CategoryId)
        {
            var category = await _service.Get(CategoryId);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            if(!ModelState.IsValid)
            {
                return View(category);
            }
            if(await _service.Update(category))
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public async Task<IActionResult> Delete(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            if(await _service.Delete(category))
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
