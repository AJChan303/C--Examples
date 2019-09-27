using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapStoneTrial.Models {
    public class Vendor {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Code { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [MaxLength(30)]
        [Required]
        public string  Address { get; set; }
        [Required]
        [MaxLength(30)]
        public string  City { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }
        [Required]
        [MaxLength(5)]
        
        public string Zip { get; set; }
        [MaxLength(12)][DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [MaxLength(255)][DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
