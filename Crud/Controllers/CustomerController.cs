using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crud.Models;
using Crud.Repository;


namespace Crud.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        public async Task< IActionResult> Index()
        {
            var results = _service.GetAll();
            return View(await results);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Store(customers customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            if (await _service.Create(customer))
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int CustomerId)
        {
            var customer = await _service.GetById(CustomerId);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Update(customers customer)
        {
            if(!ModelState.IsValid)
            {
                return View(customer);
            }
            if(await  _service.Update(customer))
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public async Task<IActionResult> Delete(customers customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            if (await _service.Delete(customer))
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }
    }
}
