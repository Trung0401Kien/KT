﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDoAn.Models.EF
{
    [Table("Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150, ErrorMessage = "Không vượt quá 150 ký tự")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "Không vượt quá 150 ký tự")]
        public string Email { get; set; }

        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }

        public bool IsRead { get; set; }

    }
}