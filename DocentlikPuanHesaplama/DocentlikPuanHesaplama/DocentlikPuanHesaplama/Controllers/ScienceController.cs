﻿using DocentlikPuanHesaplama.Helper.ConvertToModel;
using DocentlikPuanHesaplama.IdentityModel.Entity;
using DocentlikPuanHesaplama.Models;
using DocentlikPuanHesaplama.Models.DocentModels;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DocentlikPuanHesaplama.Controllers
{
    public class ScienceController : Controller
    {
        // get url yerine dinamik işlem yapmayı denicem
        [HttpGet]
        public IActionResult Answer(string link)
        {

            ViewBag.link = link;
            if (!TempData.ContainsKey("message"))
            {// Form sayfasına dönüş için tasarlandı
                var model = JsonSerializer.Deserialize<object>(TempData["model"].ToString());
                TempData.Remove("model");
                TempData["modelagain"] = JsonSerializer.Serialize(model);
                //var action = JsonSerializer.Deserialize<string>(TempData["lasturl"].ToString());
                //TempData.Remove("lasturl");
                return RedirectToAction(link, "Science");
            }
            TempData.Remove("modelagain");
            Messages? m = JsonSerializer.Deserialize<Messages>(TempData["message"].ToString());
            TempData.Remove("message");

            return View(m);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Egitim()
        {
            // yeni açılan sayfa veya geri dönüş olduğunu tespit ediyorum.
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Egitim(EgitimDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(EgitimConvert.EgitimModelToEgitimEntity(model));
            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            //TempData["lasturl"] = JsonSerializer.Serialize("Egitim");
            //TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
            ViewBag.OldData = false;

            return RedirectToAction("Answer", "Science", new { link = "Egitim" });

        }




        [HttpGet]
        public IActionResult Filoloji()
        {
            // yeni açılan sayfa veya geri dönüş olduğunu tespit ediyorum.
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Filoloji(FilolojiDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(FilolojiConvert.EgitimModelToEgitimEntity(model));


            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            //TempData["lasturl"] = JsonSerializer.Serialize("Filoloji");
            //TempData["lasturl"] = JsonSerializer.Serialize(GetUrl());
            return RedirectToAction("Answer", "Science", new { link = "Filoloji" });
            //return RedirectToAction("Answer");
        }


        [HttpGet]
        public IActionResult Hukuk()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Hukuk(HukukDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(HukukConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            //TempData["lasturl"] = JsonSerializer.Serialize("Hukuk");
            return RedirectToAction("Answer", "Science", new { link = "Hukuk" });
            //return RedirectToAction("Answer");
        }







        [HttpGet]
        public IActionResult ilahiyat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult ilahiyat(ilahiyatDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(ilahiyatConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            //TempData["lasturl"] = JsonSerializer.Serialize("ilahiyat");
            return RedirectToAction("Answer", "Science", new { link = "ilahiyat" });
            //return RedirectToAction("Answer");
        }




        [HttpGet]
        public IActionResult SosyalBeseri()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult SosyalBeseri(SosyalBeseriDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(SosyalBeseriConvert.EgitimModelToEgitimEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            //TempData["lasturl"] = JsonSerializer.Serialize("SosyalBeseri");
            return RedirectToAction("Answer", "Science", new { link = "SosyalBeseri" });
            //return RedirectToAction("Answer");
        }






        [HttpGet]
        public IActionResult Spor()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Spor(SporDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(SporConvert.SporModelToSporEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Spor" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Spor");
            //return RedirectToAction("Answer");
        }





        [HttpGet]
        public IActionResult Muhendis()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Muhendis(MuhendislikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MuhendislikConvert.MuhendislikModelToMuhendislikEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Muhendis" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Muhendis");
            //return RedirectToAction("Answer");
        }





        [HttpGet]
        public IActionResult Fen()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Fen(FenDocentModel model)
        {

            TempData["model"] = JsonSerializer.Serialize(FenConvert.FenModelToFenEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Fen" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Fen");
            //return RedirectToAction("Answer");
        }




        [HttpGet]
        public IActionResult Ziraat()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Ziraat(ZiraatDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(ZiraatConvert.ZiraatModelToZiraatEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Ziraat" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Ziraat");
            //return RedirectToAction("Answer");
        }





        [HttpGet]
        public IActionResult Mimarlik()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Mimarlik(MimarlikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(MimarlikConvert.MimarlikModelToMimarlikEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Mimarlik" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Mimarlik");
            //return RedirectToAction("Answer");
        }





        [HttpGet]
        public IActionResult Saglik()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult Saglik(SaglikDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(SaglikConvert.SaglikModelToSaglikEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "Saglik" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Saglik");
            //return RedirectToAction("Answer");
        }



        [HttpGet]
        public IActionResult GuzelSanatlar()
        {
            ViewBag.OldData = false;
            if (TempData.ContainsKey("modelagain"))
                ViewBag.OldData = true;

            return View();
        }

        [HttpPost]
        public IActionResult GuzelSanatlar(GuzelSanatlarDocentModel model)
        {
            TempData["model"] = JsonSerializer.Serialize(GuzelSanatlarConvert.GuzelSanatlarModelToGuzelSanatlarEntity(model));

            Messages message = new();
            message = model.Hesapla();
            TempData["message"] = JsonSerializer.Serialize(message);
            return RedirectToAction("Answer", "Science", new { link = "GuzelSanatlar" });
            //TempData["lasturl"] = JsonSerializer.Serialize("Saglik");
            //return RedirectToAction("Answer");
        }






        [NonAction]
        private string GetUrl()
        {
            var url = HttpContext.Request.GetEncodedUrl();
            string[] words = url.Split('/');
            string action = words[words.Length - 1];
            return action;
        }
    }
}
