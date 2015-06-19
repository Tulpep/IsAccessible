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
        public bool Get(string url)
        {
            try
            {
                using (HttpClient browser = new HttpClient())
                {
                    var result = browser.GetAsync(url).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
