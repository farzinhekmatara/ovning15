﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Core.Enteties
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;   
        public DateTime StartDate { get; set; }
        public int CourseId;
    }
}
