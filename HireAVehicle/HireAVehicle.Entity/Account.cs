using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HireAVehicle.Entity
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        [MinLength(5)]
        [RegularExpression(@"^[a-zA-Z0-9,-_]+$")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[(@#$%)]).{4,8}$")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z-.]{2,}(\s[a-zA-Z-.]{2,})+$")]
        public string FullName {
            get => FirstName + " " + LastName;
            set => value = FirstName + " " + LastName;
        }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [RegularExpression("^[0-9]{11}$")]
        [DisplayName("Contact No.")]
        public string ContactNo { get; set; }
        public bool RideStatus { get; set; }
        public int? TotalRides { get; set; }
        public AccountType AccountType { get; set; }
        public bool IsDeleted { get; set; }

        [NotMapped]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [NotMapped]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        
    }

    public enum AccountType
    {
        Customer = 1,
        Driver = 2,
        Admin = 3,
        Moderator = 4
    } 
}
