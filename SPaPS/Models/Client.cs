﻿using System;
using System.Collections.Generic;

namespace SPaPS.Models
{
    public partial class Client
    {
        public long ClientId { get; set; }
        public string UserId { get; set; } = null!;
        public int ClientTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string IdNo { get; set; } = null!;
        public int ClientCategoryId { get; set; }
        public int CityId { get; set; }
        public int? CountryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
