using System.ComponentModel.DataAnnotations;

namespace DoThuThuy.Models
{
    public class Person
    {
        [Key]
        public string PersonId {get;set;}
        public string FullName {get;set;}
        public string Address {get;set;}
    }
}