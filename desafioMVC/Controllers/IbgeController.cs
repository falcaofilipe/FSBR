using desafioMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace desafioMVC.Controllers
{
    public class IbgeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Municipios> ConsultaMunicipios()
        {
            string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/PB/distritos";
            string json = (new System.Net.WebClient()).DownloadString(url);

            var mun = JsonConvert.DeserializeObject<List<Municipios>>(json);

            return mun;
        }


    }
}
