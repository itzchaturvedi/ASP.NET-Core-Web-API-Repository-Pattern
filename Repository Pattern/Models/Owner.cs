using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository_Pattern.Models
{
    [Table("owner")]
    public class Owner
    {
        public Guid OwnerId { get; set; }

        //constrain the strings, we can use the[StringLength] attribute
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string? Address { get; set; }

        //Accounts property which suggests that one Owner is related to multiple Accounts.
        public ICollection<Account>? Accounts { get; set; }
    }
}