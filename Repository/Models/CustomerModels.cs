using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Repository.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name = "Short name")]
        public string ShortName { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(10)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Website { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        [Display(Name = "NIP")]
        [Required]
        public string Nip { get; set; }

    }
}
