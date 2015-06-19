using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tulpep.IsAccessible.Controllers
{
    public class IsAccessibleController : ApiController
    {
        // GET api/values
        public string Get(string nombre, string sexo)
        {
            return "Hola " + nombre + ". Usted es: " + sexo;
        }

    }
}
