
using System;
using System.ComponentModel.DataAnnotations;

namespace CourseReviewPortal.Models
{
    public class CourseReview
    {
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(40, MinimumLength = 2,
            ErrorMessage = "Name must be 2 to 40 characters.")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the course name.")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        [Range(1, 5, ErrorMessage = "Choose a rating from 1 to 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please write your review.")]
        [StringLength(300, MinimumLength = 5,
            ErrorMessage = "Review must be 5 to 300 characters.")]
        [Display(Name = "Your Review")]
        public string Comments { get; set; }

        public DateTime SubmittedAt { get; set; }
    }
}
