using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBP.Entity
{
    public class Login
    {
        public int? Id { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsVarified { get; set; }

        public DateTime LastLOgin { get; set; }

        public bool IsDeleted { get; set; }
    }
}
