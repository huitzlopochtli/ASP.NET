using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBP.Entity
{
    public class User
    {
        public int? Id { get; set; }
        public string Fullname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string Url { get; set; }

        public Login Login { get; set; }
        [ForeignKey("Login")]
        public int LoginId { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
