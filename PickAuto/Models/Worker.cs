﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickAuto.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string Occupation { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }


        [Required]
        public Store Workplace { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}