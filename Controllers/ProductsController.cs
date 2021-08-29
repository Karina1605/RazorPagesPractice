using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPages.DataBaseModels;
using TestPages.Repo;

namespace TestPages.Controllers
{
    public class ProductsController : Controller
    {
        DataBaseRepo _repo;
        public ProductsController(DataBaseRepo repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index(int page)
        {
            var res = await _repo.Products.GetAll();
            var final = res.OrderBy(e => e.Id);
            return View((page, res));
        }
        public IActionResult CreateNew()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateNew([FromForm] Product product)
        {
            await _repo.Products.Create(product);
            return RedirectToAction("Index");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var res = await _repo.Products.GetById(id);
            return View(res);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOne([FromForm] Product product)
        {
            await _repo.Products.Update(product);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOne(int id)
        {
            var res = await _repo.Products.GetById(id);
            await _repo.Products.Delete(res);
            return RedirectToAction("Index");
        }
    }
}
