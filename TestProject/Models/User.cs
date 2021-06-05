using System;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastActivityDate { get; set; }
    }
}
