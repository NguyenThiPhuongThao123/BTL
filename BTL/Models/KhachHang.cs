using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string KhachHangIB { get; set; }
        public string TenKhachHang { get; set; }
        public string Diachi { get; set; }
        
    }
}