﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir.")]

        public string Desciription { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Popüler")]
        public bool Popular { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Onay")]
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Resim")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Adet")]
        public  int Quantitiy { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez!")]
        [Display(Name = "Kategori")]
        public int CategoriId { get; set; }

        public virtual Category Category { get; set; }
    }
}
