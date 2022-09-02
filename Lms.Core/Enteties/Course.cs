﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Core.Enteties
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public ICollection<Module> Modules{ get; set; } = new List<Module>();
    }
}
