﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Models
{
    public class UpdateUserTypeRequest
    {
        public int UserId { get; set; }
        public string Type { get; set; }
    }
}
