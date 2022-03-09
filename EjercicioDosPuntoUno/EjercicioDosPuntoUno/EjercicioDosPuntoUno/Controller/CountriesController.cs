using Newtonsoft.Json;
using EjercicioDosPuntoUno.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDosPuntoUno.Controllers
{
    public class CountriesControllers
    {
        public async static Task<List<Models.Countries.Example>> getpaisesamerica()
        {
            List<Models.Countries.Example> listapersonas = new List<Models.Countries.Example>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/america");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapersonas = JsonConvert.DeserializeObject<List<Models.Countries.Example>>(contenido);

                }
            }
            return listapersonas;
        }

        public async static Task<List<Models.Countries.Example>> getpaiseseuropa()
        {
            List<Models.Countries.Example> listapersonas = new List<Models.Countries.Example>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/europe");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapersonas = JsonConvert.DeserializeObject<List<Models.Countries.Example>>(contenido);

                }
            }
            return listapersonas;
        }

        public async static Task<List<Models.Countries.Example>> getpaisesafrica()
        {
            List<Models.Countries.Example> listapersonas = new List<Models.Countries.Example>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/africa");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapersonas = JsonConvert.DeserializeObject<List<Models.Countries.Example>>(contenido);

                }
            }
            return listapersonas;
        }

        public async static Task<List<Models.Countries.Example>> getpaisesoceania()
        {
            List<Models.Countries.Example> listapersonas = new List<Models.Countries.Example>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/oceania");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapersonas = JsonConvert.DeserializeObject<List<Models.Countries.Example>>(contenido);

                }
            }
            return listapersonas;
        }

        public async static Task<List<Models.Countries.Example>> getpaisesasia()
        {
            List<Models.Countries.Example> listapersonas = new List<Models.Countries.Example>();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://restcountries.com/v3.1/region/asia");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = response.Content.ReadAsStringAsync().Result;
                    listapersonas = JsonConvert.DeserializeObject<List<Models.Countries.Example>>(contenido);

                }
            }
            return listapersonas;
        }

    }
}