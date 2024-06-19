using System.ComponentModel.DataAnnotations;

namespace DoThuThuy.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTTPP {get;set;}
        public string TenHTPP {get;set;}
        public ICollection<DaiLy> DaiLy {get;set;} 
    }
}