using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Tên loại hàng")]
        public string Name { get; set; }
        [Display(Name = "Tên rút gọn")]
        public string Slug { get; set; }

        [Display(Name = "Cấp cha")]
        public int? ParentId { get; set; }

        [Display(Name = "Sắp xếp")]
        public int? Order { get; set; }

        [Display(Name = "Mô tả")]
        [Required (ErrorMessage ="Không được để trống")]
        public string MetaDesc { get; set; }

        [Display(Name = "Từ khóa")]
        [Required(ErrorMessage = "Không được để trống")]
        public string MetaKey { get; set; }

        [Display(Name = "Tên rút gọn")]
        [Required(ErrorMessage = "Không được để trống")]
        public int CreateBy { get; set; }

        [Display(Name = "Tên rút gọn")]
        [Required]
        public DateTime CreateAt { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Người cập nhật")]
        
        public int UpdateBy { get; set; }

        [Display(Name = "Tên rút gọn")]
        [Required]
        public DateTime UpdateAt { get; set; }

        [Display(Name = "Trạng thái")]
        [Required]
        public int Status { get; set; }

       



    
    }
}
