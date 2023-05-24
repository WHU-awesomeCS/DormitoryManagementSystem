using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Data.Entities
{
    public class Account
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserRole { get; set; }
    }
}
