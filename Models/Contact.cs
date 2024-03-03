﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }


        [NotMapped]
        [Display(Name = "Name")]
        public string? FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public string? Sex { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


        public DateTime Created { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }
    }
}
