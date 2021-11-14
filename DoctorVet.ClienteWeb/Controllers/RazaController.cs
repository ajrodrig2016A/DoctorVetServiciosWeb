using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using DoctorVet.BAL;
using System.Net.Http.Formatting;

namespace DoctorVet.ClienteWeb.Controllers
{
    public class RazaController : Controller
    {
        // GET: Raza
        public ActionResult Index()
        {
            //Invocar servicio Rest
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://doctorvetwebapi.azurewebsites.net/");

            var request = clienteHttp.GetAsync("api/Raza").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Raza>>(resultString);

                return View(listado);
            }
            return View(new List<Raza>());
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Raza raza)
        {
            //Invocar servicio Rest
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://doctorvetwebapi.azurewebsites.net/");

            var request = clienteHttp.PostAsync("api/Raza", raza, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var correcto = JsonConvert.DeserializeObject<bool>(resultString);

                if (correcto)
                {
                    return RedirectToAction("Index");
                }
                return View(raza);
            }
            return View(raza);
        }

        [HttpGet]
        public ActionResult Actualizar(int id)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://doctorvetwebapi.azurewebsites.net/");

            var request = clienteHttp.GetAsync("api/Raza?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var informacion = JsonConvert.DeserializeObject<Raza>(resultString);
                return View(informacion);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Actualizar(Raza raza)
        {
            //Invocar servicio Rest
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://doctorvetwebapi.azurewebsites.net/");

            var request = clienteHttp.PutAsync("api/Raza", raza, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var correcto = JsonConvert.DeserializeObject<bool>(resultString);

                if (correcto)
                {
                    return RedirectToAction("Index");
                }
                return View(raza);
            }
            return View(raza);
        }

        [HttpGet]

        public ActionResult Eliminar(int id)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://doctorvetwebapi.azurewebsites.net/");

            var request = clienteHttp.DeleteAsync("api/Raza?idRaza=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var correcto = JsonConvert.DeserializeObject<bool>(resultString);
                if (correcto)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Detalle(int id)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://doctorvetwebapi.azurewebsites.net/");

            var request = clienteHttp.GetAsync("api/Raza?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var informacion = JsonConvert.DeserializeObject<Raza>(resultString);
                return View(informacion);
            }

            return View();
        }

    }
}