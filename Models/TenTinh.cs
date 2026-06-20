using System.ComponentModel.DataAnnotations;

namespace 2526_2221050384_BaiThi.Models
{
    public class TenTinh
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        
    }
}