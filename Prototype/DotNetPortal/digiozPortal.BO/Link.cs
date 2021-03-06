﻿using System;
using System.Collections.Generic;

namespace digiozPortal.BO
{
    public partial class Link
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int LinkCategoryId { get; set; }
        public bool? Visible { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
