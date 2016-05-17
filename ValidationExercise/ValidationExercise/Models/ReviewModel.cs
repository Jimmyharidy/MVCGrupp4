using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationExercise.Models
{
    public class ReviewModel
    {
        [Required (ErrorMessage = "Id is required."), DisplayName("Id")]
        public int ReviewID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100, ErrorMessage = "Name can not have more than 100 caracters."),]
        public string Name { get; set; }

        [Required(ErrorMessage = "Summary is required.")]
        [MaxLength(1000, ErrorMessage = "Summary can not have more than 1000 caracters. ")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Ingredients is required.")]
        [MaxLength(4000, ErrorMessage = "Ingredients can not have more than 4000 caracters.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Instructions is required.")]
        [MaxLength(4000, ErrorMessage = "Instructions can not have more than 4000 caracters")]
        public string Instructions { get; set; }

        [Required(ErrorMessage = "Cooking Time is required.")]
        [Range(1, 180, ErrorMessage = "Cooking Time must be a value between 1 and 180 minutes.")]
        public int CookingTime { get; set; }

    }
}