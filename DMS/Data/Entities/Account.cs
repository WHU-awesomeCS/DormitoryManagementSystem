using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Data.Entities
{
    public class Account
    {
        public string? id { get; set; }
        public string? USERNAME { get; set; }
        public string? PASSWORD { get; set; }
        public string? USERROLE { get; set; }
    }
}
