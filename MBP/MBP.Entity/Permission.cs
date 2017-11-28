using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBP.Entity
{
    public class Permission
    {
        public int? Id { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
