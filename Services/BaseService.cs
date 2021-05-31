using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Services
{
    public class BaseService<T>
    {

        public List<T> GetAll(string url)
        {

            using(WebClient wc = new WebClient())
            {

                string json = wc.DownloadString(url);

                return JsonConvert.DeserializeObject<List<T>>(json);

            }

        }

    }
}
