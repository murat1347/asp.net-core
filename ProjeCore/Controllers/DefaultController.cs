﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;

namespace ProjeCore.Controllers
{
    public class DefaultController : Controller
    {
        private Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Birims.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBirim(Birim d)
        {
            c.Birims.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
  
        public IActionResult BirimSil(int id)
    {
        var dep = c.Birims.Find(id);
        c.Birims.Remove(dep);
        c.SaveChanges();
        return RedirectToAction("Index");

    }

    public IActionResult BirimGetir(int id)
    {
        var depart = c.Birims.Find(id);
        return View("BirimGetir", depart);
    }

    public IActionResult BirimGuncelle(Birim d)
    {
        var dep = c.Birims.Find(d.BirimId);
        dep.BirimAd = d.BirimAd;
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult BirimDetay(int id)
    {
        var degerler = c.Personels.Where(x => x.BirimID == id).ToList();
        var brmad = c.Birims.Where(x => x.BirimId == id).Select(y => y.BirimAd).FirstOrDefault();
        ViewBag.brmad = brmad;
        return View(degerler);
    }
}
}
