﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Responses.Item
{
    public class GenreResponse
    {
        public Guid GenreId { get; set; }
        public string GenreDescription { get; set; }
    }
}
