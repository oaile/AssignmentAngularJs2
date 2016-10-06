﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.API.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}