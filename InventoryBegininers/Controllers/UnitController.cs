using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryBegininers.Data;
using Microsoft.EntityFrameworkCore;
using InventoryBegininers.Models;
using InventoryBegininers.Interfaces;

namespace InventoryBegininers.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            List<Unit> units = _UnitRepo.GetItem(); 
            return View(units);
        }
        private readonly InventoryContext _context;

        private readonly IUnit _UnitRepo;

        public UnitController(InventoryContext context,IUnit unitrepo)
        {
            _context = context;
            _UnitRepo = unitrepo;
        }
        public IActionResult Create()
        {
            Unit unit = new Unit();
            return View(unit);
        }
        [HttpPost]
        public IActionResult Create(Unit unit)
        {
            try
            {
               unit= _UnitRepo.Create(unit);
            }
            catch
            {

            }
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Unit unit = _UnitRepo.GetUnit(id);
            return View(unit);
        }
        public IActionResult Edit(int id)
        {
            Unit unit = _UnitRepo.GetUnit(id);
            return View(unit);
        }       
        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                unit = _UnitRepo.Edit(unit);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Unit unit = _UnitRepo.GetUnit(id);
            return View(unit);
        }
        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                unit = _UnitRepo.Delete(unit);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
        }       
    }
}
