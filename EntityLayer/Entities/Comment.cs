﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        [Display(Name ="Yorum")]
        public string Content { get; set; }

        [Display(Name = "Ürün")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Display(Name = "Kullanıcı")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
    }
}
