using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı boş geçilemez.")]
        [MaxLength(30,ErrorMessage ="Ad alanı en fazla 30 karakter olabilir.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        [MinLength(3, ErrorMessage = "Soyad alanı en az 3 karakter olabilir.")]
        public string  LastName { get; set; }
        [Range(18,40,ErrorMessage = "En az 18 ve En fazla 40 olabilir.")]
        public int Age { get; set; }
    }
}
