using System;

namespace MBP.Entity
{
    public class Role
    {
        public int? Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDesctription { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
