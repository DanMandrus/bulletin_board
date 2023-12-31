﻿using System.ComponentModel.DataAnnotations;

namespace BulletinBoard.Service.Controllers.Entities;

public class CreateUserRequest : IValidatableObject
{
    [Required]
    [MinLength(2)]
    public string FirstName { get; set; }
    
    [Required]
    [MinLength(2)]
    public string LastName { get; set; }

    [Required]
    [MinLength(2)]
    public string Patronymic { get; set; }

    [Range(0,1)]
    public int Sex { get; set; }
    
    public DateTime Birthday { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var errors = new List<ValidationResult>();
        if (Birthday < new DateTime(1900, 1, 1))
        {
            errors.Add(new ValidationResult("Birthday must be greater than 1900 year."));
        }

        return errors;
    }
}