using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLSach.Models
{
    public class Books
    {
        public int Id { get; set; }
        [DisplayName("Tên Sách")]
        [Required(ErrorMessage = "Tên sách không được bỏ trống")]
        [MinLength(3, ErrorMessage = "Tên sách tối thiểu phải có 3 ký tự")]
        public string Name { get; set; }
        [DisplayName("Tên tác giả")]
        public string NameAuthor { get; set; }
        [DisplayName("Mô tả ngắn")]
        public string Short_content { get; set; }
        [DisplayName("Năm xuất bản")]
        public int Year { get; set; }
        [DisplayName("Số lượng :")]
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
