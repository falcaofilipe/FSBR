using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace desafioMVC.Models
{
    public class Regiao
    {

        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }

    public class UF
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public Regiao Regiao { get; set; }

        public static List<SelectListItem> ConsultaUf()
        {
            string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/";
            string json = (new System.Net.WebClient()).DownloadString(url);

            var mun = JsonConvert.DeserializeObject<List<UF>>(json);

            List<SelectListItem> item = mun.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Sigla.ToString(),
                    Value = a.Id.ToString(),
                };
            });

            return item;

        }
    }

    public class Mesorregiao {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UF Uf { get; set; }
    }

    public class Microregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Mesorregiao Mesorregiao { get; set; }
    }

    public class Municipios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Microregiao Microregiao { get; set; }

        public static List<SelectListItem> ConsultaMunicipios(string uf)
        {
            string url = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/distritos";
            string json = (new System.Net.WebClient()).DownloadString(url);

            var mun = JsonConvert.DeserializeObject<List<Municipios>>(json);

            List<SelectListItem> item = mun.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Nome.ToString(),
                    Value = a.Id.ToString(),
                };
            });

            return item;

        }

    }

}
