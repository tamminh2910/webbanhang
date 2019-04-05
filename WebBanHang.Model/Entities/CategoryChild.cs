﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Model.Entities
{
    public class CategoryChild
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryChildID { get; set; }

        public int? CategoryParentID { get; set; }
        
        [StringLength(255)]
        [Required]
        [Display(Name = "Tên danh mục con")]
        public string CategoryChildName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? State { get; set; }

        [ForeignKey("CategoryParentID")]
        public virtual CategoryParent CategoryParent { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}