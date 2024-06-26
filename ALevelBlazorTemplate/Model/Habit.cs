﻿using System.ComponentModel.DataAnnotations;

namespace ALevelBlazorTemplate.Model
{
    public class Habit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Type")]
        public string Type { get; set; } = "";

        [Required(ErrorMessage = "Please enter the Description")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please enter the difficulty")]
        public string Difficulty { get; set; }

        [Required(ErrorMessage = "Please enter the Point")]
        public int Point { get; set; }

        [Required(ErrorMessage = "Please enter the ImageUrl")]
        public string imageUrl { get; set; }

        public bool IsChecked { get; set; }

    }

}
