using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class GalleryService : BaseService<string>
    {

        private readonly string url = "https://localhost:44389/api/filter";

        public List<string> GetCategories()
        {

            return GetAll(url);

        }

    }
}
