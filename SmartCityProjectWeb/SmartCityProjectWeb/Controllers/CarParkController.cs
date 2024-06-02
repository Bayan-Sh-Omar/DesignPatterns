﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using SmartCity.Business.Abstract;
using SmartCity.Entities.Concrete;
using SmartCityProjectWeb.Atributes;
using SmartCityProjectWeb.Filters;

namespace SmartCityProjectWeb.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class CarParkController : Controller
    {
        private ICarParkService _carParkService;
        public CarParkController(ICarParkService carkParkService)
        {
            _carParkService = carkParkService;
        }

        [Ignore]
        [Route("Otopark")]
        public ActionResult CarPark()
        {
            var model = _carParkService.GetAll();
            return View(model);
        }

        [Route("Admin/OtoparkBilgiGirisi/{companyId}")]
        public ActionResult CarParkAdd(int companyId)
        {
            var modal = new CarPark
            {
                CarParkDisabled = false,
                CarParkMarket = false,
                CarParkMax = 0,
                CarParkNull = 0,
                CarParkTire = false,
                CarParkWashing = false,
                CompanyId = companyId
            };
            _carParkService.Add(modal);
            return View("CarParkOparation", modal);
        }

        [Route("Admin/OtoparkGuncelle/{id}")]
        public ActionResult CarParkOparation(int id)
        {
            var modal = _carParkService.Get(id);
            return View(modal);
        }

        public ActionResult CarParkOptionsCrud(CarPark carPark)
        {
            _carParkService.Update(carPark);
            return RedirectToAction("CarParkGetList");
        }

        [Route("Admin/OtoparkListesi")]
        public ActionResult CarParkGetList()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            List<CarPark> model = _carParkService.GetAll().Where(x => x.CarParkId == userId).ToList();
            return View(model);
        }
    }
}