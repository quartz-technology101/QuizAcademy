using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuizAcademy.Models
{
    public class AnswerFromOptions: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var question = (Question)validationContext.ObjectInstance;
            if (question.CorrectAnswer == question.Option1 || question.CorrectAnswer == question.Option2 ||
                        question.CorrectAnswer == question.Option3 || question.CorrectAnswer == question.Option4)
            {
                return ValidationResult.Success;
            }
                
            else {
                 return new ValidationResult("Options should include a correct answer.");
            }
           
        }
    }
}