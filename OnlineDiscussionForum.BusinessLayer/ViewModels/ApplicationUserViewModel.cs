using OnlineDiscussionForum.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineDiscussionForum.BusinessLayer.ViewModels
{
    public class ApplicationUserViewModel
    {
        public string Name { get; set; }
        [Required]
        [Display(Name = "User Type")]
        public UserType? UserTypes { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Phone Number")]
        public double PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsApproved { get; set; }
    }
}
