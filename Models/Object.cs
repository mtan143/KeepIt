//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeepIt.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Object
    {
        public Object()
        {
            ImageName = "~/Content/Img/admin.jpg";
        }

        public int ObjectId { get; set; }

        [Display(Name = "Image Profile")]
        public string ImageName { get; set; }


        [RegularExpression(@"{20,}", ErrorMessage = "Full Name must be at least 20 character!")]
        [Required(ErrorMessage = "Please provied full name!")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }


        public string Gender { get; set; }


        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy}")]
        [Required(ErrorMessage ="Please provied your birthday!")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }


        [Display(Name = "Place of Birth")]
        [Required(ErrorMessage = "Please provied place of birth!")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "Please provied your address!")]
        public string Address { get; set; }

        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid Email!")]
        [Required(ErrorMessage = "You must provied email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must provide a phone number!")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number!")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Material Status")]
        public string MaterialStatus { get; set; }

        [RegularExpression(@"{5,}", ErrorMessage = "Invalid Career!")]
        [Required(ErrorMessage = "Please provied career!")]
        public string Career { get; set; }

        [RegularExpression(@"{5,}", ErrorMessage = "Invalid Education!")]
        [Required(ErrorMessage = "Please provied education!")]
        public string Education { get; set; }


        [RegularExpression(@"{5,}", ErrorMessage = "Invalid Skill!")]
        [Required(ErrorMessage = "Please provied skill!")]
        public string Skill { get; set; }

        [RegularExpression(@"{5,}", ErrorMessage = "Invalid Hobby!")]
        [Required(ErrorMessage = "Please provied hobby!")]
        public string Hobby { get; set; }


        public int UserId { get; set; }


        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }


        public virtual User User { get; set; }
    }
}
