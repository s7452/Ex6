﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6.DTOs.Requests
{
    public class PromoteStudentRequest
    {
        [Required]
        public int semester;
        [Required]
        public string studies;
    }
}
