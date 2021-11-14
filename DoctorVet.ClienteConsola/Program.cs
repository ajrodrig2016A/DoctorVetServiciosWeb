using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DoctorVet.WebApi.Models;
using Newtonsoft.Json;

namespace DoctorVet.ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invocar servicio Rest
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("https://localhost:44371/");

            var request = clienteHttp.GetAsync("api/Raza").Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                var listado = JsonConvert.DeserializeObject<List<Raza>>(resultString);

                foreach(var item in listado)
                {
                    Console.WriteLine(item.nombre);
                }
                Console.ReadLine();
            }


        }
    }
}
