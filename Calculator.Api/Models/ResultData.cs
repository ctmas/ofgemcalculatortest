﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Calculator.Api.Models
{
    public class ResultData
    {
        public double Result { get; set; }
        public string ErrorMessage { get; set; }
    }
}