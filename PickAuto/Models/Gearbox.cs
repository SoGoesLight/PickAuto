﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PickAuto.Models
{
    public class Gearbox
    {
        public int GearboxId { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string Name { get; set; }

        public ICollection<CarModel> CarModels { get; set; }
    }
}
