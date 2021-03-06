﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Model.Entities
{
    public class CategoryParent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryParentID { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên danh mục cha")]
        [Required]
        public string CategoryParentName { get; set; }

        [Display(Name ="Mô tả")]
        public string Description { get; set; }


        public virtual IEnumerable<CategoryChild> CategoryChilds { get; set; }
    }
}