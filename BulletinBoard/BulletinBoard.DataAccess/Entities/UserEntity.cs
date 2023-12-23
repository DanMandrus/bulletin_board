﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BulletinBoard.DataAccess.Entities;

[Table("users")]
public class UserEntity : BaseEntity
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Patronymic { get; set; }
    public DateTime Birthday { get; set; }
    public string Mail { get; set; }
    public string PasswordHash { get; set; }
}
