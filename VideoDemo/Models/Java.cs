﻿using System;
using System.Collections.Generic;

namespace VideoDemo.Models
{
    public partial class Java
    {
        public int VideoId { get; set; }
        public string Url { get; set; }
        public string LinkText { get; set; }
        public string Description { get; set; }
        public int? LengthMinutes { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
