using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWCFDBPoliedro.Infraestructure.Services;
using System.Runtime.Serialization;
using TestWCFDBPoliedro.Infraestructure.Services.ServiceActivation;

namespace TestWCFDBPoliedro.GUI.MvcFront.Controllers
{
    public class ServicesTestController : Controller
    {
        // GET: /ServicesTest/
        public ActionResult Index(decimal activationUID = 0)
        {
            //85606242
            try
            {
                ViewBag.Error = string.Empty;
                var services = new CallServices();
                var result = (activationUID == 0 ? new List<Validator>() :
                              services.GetValidateActivation(activationUID, 0));
                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(new List<Validator>());
            }
        }


	}
}